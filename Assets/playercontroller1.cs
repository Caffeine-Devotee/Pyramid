using UnityEngine;
using System.Collections;

public class playercontroller1 : MonoBehaviour {
	public float moveSpeed = 5f;
	public float turnSpeed = 50f;
	public float JumpSpeed = 10.0f;

	void FixedUpdate ()
	{
		if (Input.GetKey(KeyCode.M))
			transform.Translate(Vector3.up*JumpSpeed*Time.deltaTime );

		if(Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.forward * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.DownArrow))
			transform.Translate(-Vector3.forward * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}
	}