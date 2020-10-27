using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

    public GameObject replacement;
    public float resistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            Destroy(gameObject);
            GameObject particle = Instantiate(replacement);
            particle.transform.position = this.transform.position;
        }
    }
}
