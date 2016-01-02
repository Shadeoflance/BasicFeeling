using UnityEngine;
using System.Collections;

public class VectorUtils 
{
	public static Vector2 V3ToV2(Vector3 vec)
	{
		return new Vector2(vec.x, vec.y);
	}
	public static Vector3 V2ToV3(Vector2 vec)
	{
		return new Vector3(vec.x, vec.y, 0);
	}
}
