using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
	public int KillMask;
	public int NoCollisionMask;
	void OnTriggerEnter2D(Collider2D col)
	{
		GameObject obj = col.gameObject;
		int layer = 1 << obj.layer;
		if((layer & NoCollisionMask) != 0)
			return;
		if((layer & KillMask) != 0)
			Destroy(obj);
		Destroy(gameObject);
	}
}
