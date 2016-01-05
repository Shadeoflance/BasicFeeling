using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour 
{
	public float width = 64.0f;
	public float height = 64.0f;
	public GameObject current;

	public Color color = Color.white;

	void OnDrawGizmos()
	{
		Vector3 pos = Camera.current.transform.position;

		Gizmos.color = color;

		width = width < 0.001f ? 0.001f : width;
		height = height < 0.001f ? 0.001f : height;
		for (float y = pos.y - 800.0f; y < pos.y + 800.0f; y+= height)
		{
			Gizmos.DrawLine(new Vector3(-1000000.0f, Mathf.Floor(y/height) * height, 0.0f),
			                new Vector3(1000000.0f, Mathf.Floor(y/height) * height, 0.0f));
		}
		
		for (float x = pos.x - 1200.0f; x < pos.x + 1200.0f; x+= width)
		{
			Gizmos.DrawLine(new Vector3(Mathf.Floor(x/width) * width, -1000000.0f, 0.0f),
			                new Vector3(Mathf.Floor(x/width) * width, 1000000.0f, 0.0f));
		}
	}
}
