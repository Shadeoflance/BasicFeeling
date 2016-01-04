using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour 
{
	public LayerMask KillMask;
	public LayerMask NoCollisionMask;
	public abstract void Shoot(Vector2 dir);
}
