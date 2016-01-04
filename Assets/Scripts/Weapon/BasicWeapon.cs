using UnityEngine;
using System.Collections;

public class BasicWeapon : Weapon 
{
	public GameObject Bullet;
	public float BulletSpeed = 14;
	public float CoolDown = 0.3f;
	float Timer = 0;
	void Update()
	{
		Timer -= Time.deltaTime;
	}
	public override void Shoot(Vector2 dir)
	{
		if(Timer > 0)
			return;
		else Timer = CoolDown;
		dir -= VectorUtils.V3ToV2(transform.position);
		var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		GameObject createdBullet = Instantiate(Bullet, transform.position, Quaternion.AngleAxis(angle, Vector3.forward)) as GameObject;
		createdBullet.GetComponent<Rigidbody2D>().velocity = createdBullet.transform.up * BulletSpeed;
		createdBullet.GetComponent<Bullet>().KillMask = KillMask.value;
		createdBullet.GetComponent<Bullet>().NoCollisionMask = NoCollisionMask.value;
	}
}
