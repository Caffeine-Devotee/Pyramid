using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunction : MonoBehaviour {

	public float moveSpeed = 0.5f;
	private bool dir = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dir)
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		else
			transform.Translate (-Vector3.forward * 0 * Time.deltaTime);

		if(transform.position.x >= .10f) {
			dir = false;
		}
	}
}

