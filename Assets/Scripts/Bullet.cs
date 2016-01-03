using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log(col.name);
		GameObject obj = col.gameObject;
		if(obj.layer == LayerMask.NameToLayer("Enemy"))
			Destroy(obj);
		Destroy(gameObject);
	}
}
