using UnityEngine;
using System.Collections;

public class PlayerController : IController 
{
	GameObject gameObject;
	public PlayerController(GameObject gameObject)
	{
		this.gameObject = gameObject;
	}
	public Vector2 NeedVel()
	{
		return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis ("Vertical"));
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
		Vector3 mousePos = Input.mousePosition;
		return VectorUtils.V3ToV2(Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0)));
	}
}