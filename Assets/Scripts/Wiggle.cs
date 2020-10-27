using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour {

    private Vector3 wiggle;

	void Start () {
        InvokeRepeating("Move", 0, 2f);
	}
	
	void Update () {
        transform.Rotate(wiggle * Time.deltaTime * 3);
    }

    private void Move()
    {
        wiggle = new Vector3(transform.rotation.x, transform.rotation.y + Random.Range(-5, 5), transform.rotation.z);
    }
}
