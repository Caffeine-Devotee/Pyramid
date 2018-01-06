using UnityEngine;
using System.Collections;

public class Lerp : MonoBehaviour {

    public GameObject wall;
    private Vector3 startPos;
    private Vector3 endPos;
    
    private float distance = 30f;
    
    private float lerpTime = 5;
    private float currentLerpTime = 0;
    
    private bool keyHit = false;
    
	// Use this for initialization
	void Start () {
        startPos = wall.transform.position;
		endPos = wall.transform.position + Vector3.forward * distance;
        
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){
            keyHit = true;
        }
        
        if(keyHit == true){
            currentLerpTime += Time.deltaTime;
            if(currentLerpTime >= lerpTime){
                currentLerpTime = lerpTime;
            }
            
            float Perc = currentLerpTime/lerpTime;
            wall.transform.position = Vector3.Lerp(startPos, endPos, Perc);
        }
	}
}