using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor (typeof(Grid))]
public class GridEditor :  Editor
{
	Grid grid;
	GameObject level;
	public override void OnInspectorGUI()
	{
		grid.color = EditorGUILayout.ColorField("Grid Color", grid.color);
		grid.current = EditorGUILayout.ObjectField("Current Object", grid.current, typeof(GameObject), true) as GameObject;
	}
	void Awake()
	{
		grid = (Grid)target;
		level = GameObject.Find("Level");
		SceneView.onSceneGUIDelegate = GridUpdate;
	}

	void GridUpdate(SceneView sceneview)
	{
		Event e = Event.current;

		Ray r = Camera.current.ScreenPointToRay(new Vector3(e.mousePosition.x, -e.mousePosition.y + Camera.current.pixelHeight));
		Vector3 mousePos = r.origin;
		if (e.isKey && e.character == 'a')
		{
			GameObject obj;
			Object prefab = grid.current == null ? PrefabUtility.GetPrefabParent(Selection.activeObject) : grid.current;
			Debug.Log(prefab);
			if (prefab)
			{
				obj = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
				Vector3 aligned = new Vector3(Mathf.Floor(mousePos.x/grid.width)*grid.width + grid.width/2.0f,
				                              Mathf.Floor(mousePos.y/grid.height)*grid.height + grid.height/2.0f, 0.0f);
				obj.transform.position = aligned;
				obj.transform.SetParent(level.transform);
				Undo.RegisterCreatedObjectUndo(obj, "Create " + obj.name);
			}
		}
		else if (e.isKey && e.character == 'd')
		{
			foreach (GameObject obj in Selection.gameObjects)
				Undo.DestroyObjectImmediate(obj);
		}
	}
}
