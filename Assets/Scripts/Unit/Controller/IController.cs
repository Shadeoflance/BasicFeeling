using UnityEngine;
using System.Collections;

public interface IController 
{
	Vector2 NeedVel();
	bool NeedShoot();
	bool NeedUse();
	Vector2 LookAt();
}
