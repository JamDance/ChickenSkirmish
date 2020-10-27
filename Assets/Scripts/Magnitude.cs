using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnitude : MonoBehaviour {

    public float magnitude;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        magnitude = transform.GetComponent<Rigidbody>().velocity.magnitude;
	}
}
