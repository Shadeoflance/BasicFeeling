using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float Speed = 3;
	Rigidbody2D rb;
	void Awake()
	{
		rb = (Rigidbody2D)GetComponent (typeof(Rigidbody2D));
	}

	void Update () 
	{
		rb.velocity = Vector2.zero;
		rb.velocity += new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis ("Vertical"));
		rb.velocity.Normalize ();
		rb.velocity *= Speed;
		Vector3 mousePos = Input.mousePosition;
		transform.LookAt(Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0)), new Vector3(0, 0, 1));
	}
}
