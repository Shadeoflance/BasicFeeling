using UnityEngine;
using System.Collections;

public class Enemy : Unit
{
	void Start()
	{
		controller = new EnemyController(gameObject);
	}
}
