using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
	GameObject player;
	void Awake()
	{
		player = GameObject.Find("Player");
	}
	void Update () 
	{
		transform.position = new Vector3(player.transform.position.x, 
		                                 player.transform.position.y, 
		                                 transform.position.z);
	}
}
