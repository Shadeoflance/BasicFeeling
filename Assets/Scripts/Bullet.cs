using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D col)
	{
		GameObject obj = col.gameObject;
		if((obj.layer & LayerMask.NameToLayer("Enemy")) != 0)
			Destroy(obj);
		if(obj.layer == LayerMask.NameToLayer("Player"))
			return;
		Destroy(gameObject);
	}
}
