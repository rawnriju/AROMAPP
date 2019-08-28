using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public GameObject GameObject;
    public float speed = 1f; 
	// Use this for initialization
	void Start ()
    {
	    	
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject.transform.Rotate(Vector3.up * speed * Time.deltaTime);

	}
}
