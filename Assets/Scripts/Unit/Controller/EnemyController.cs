using UnityEngine;
using System.Collections;

public class EnemyController : IController
{
	GameObject gameObject;
	public EnemyController(GameObject gameObject)
	{
		this.gameObject = gameObject;
	}
	bool CanSeePlayer()
	{
		RaycastHit2D rh = Physics2D.Raycast(Position, PlayerPosition - Position, Mathf.Infinity, ~(1 << LayerMask.NameToLayer("Enemy")));
		if(rh.collider == null)
			return false;
		return rh.collider.gameObject.name == "Player";
	}
	Vector2 PlayerPosition
	{
		get { return VectorUtils.V3ToV2(Player.instance.transform.position); }
	}
	Vector2 Position
	{
		get { return VectorUtils.V3ToV2(gameObject.transform.position); }
	}
	public Vector2 NeedVel()
	{
		if(CanSeePlayer())
		{
			return (PlayerPosition - Position).normalized;
		}
		return Vector2.zero;
	}
	public bool NeedShoot()
	{
		return false;
	}
	public bool NeedUse()
	{
		return false;
	}
	public Vector2 LookAt()
	{
		if(CanSeePlayer())
		{
			return PlayerPosition - VectorUtils.V3ToV2(gameObject.transform.position);
		}
		return new Vector2(0, 1);
	}
}
