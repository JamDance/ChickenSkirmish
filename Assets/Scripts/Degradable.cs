using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degradable : MonoBehaviour {

    public float stickyMagnitude;
    private bool touchingFloor;

	void Update () {
		if (touchingFloor)
        {
            StartCoroutine(Decay());
        }
	}

    IEnumerator Decay()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            if (this.GetComponent<Rigidbody>().velocity.magnitude > stickyMagnitude) 
            {
                this.GetComponent<Rigidbody>().isKinematic = true;
                this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            }
            touchingFloor = true;
        }
    }
}
