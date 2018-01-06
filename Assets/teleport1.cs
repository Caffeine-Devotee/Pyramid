using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport1 : MonoBehaviour {

	public GameObject player;
	public Transform spawnpoint;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

		void OnTriggerEnter(Collider col) {

		if(col.tag == "Player") 
		{
			player = col.transform.gameObject;
			player.transform.position = spawnpoint.transform.position;
			player.transform.rotation = spawnpoint.transform.rotation;
		}
	}
}
