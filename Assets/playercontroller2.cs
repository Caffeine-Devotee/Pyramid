using UnityEngine;
using System.Collections;

public class playercontroller2 : MonoBehaviour {
	public float moveSpeed = 5f;
	public float turnSpeed = 50f;
	public float JumpSpeed = 10.0f;

	void FixedUpdate ()
	{
		if (Input.GetKey(KeyCode.X))
			transform.Translate(Vector3.up*JumpSpeed*Time.deltaTime );

		if(Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.S))
			transform.Translate(-Vector3.forward * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.D))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}
	}