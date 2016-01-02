using UnityEngine;
using System.Collections;

public class Player : Unit
{
	public static GameObject instance;
	void Start()
	{
		controller = new PlayerController(gameObject);
		if(instance != gameObject)
		{
			Destroy(instance);
			instance = gameObject;
		}
	}
}
