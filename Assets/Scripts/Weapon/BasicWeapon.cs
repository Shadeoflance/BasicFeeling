using UnityEngine;
using System.Collections;

public class BasicWeapon : Weapon 
{
	public GameObject Bullet;
	public float BulletSpeed = 14;
	public override void Shoot(Vector2 dir)
	{
		dir -= VectorUtils.V3ToV2(transform.position);
		var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		GameObject createdBullet = Instantiate(Bullet, transform.position, Quaternion.AngleAxis(angle, Vector3.forward)) as GameObject;
		createdBullet.GetComponent<Rigidbody2D>().velocity = createdBullet.transform.up * BulletSpeed;
	}
}
