using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float min;
    public float max;
    public float minVel;
    public float maxVel;
    public Rigidbody body;
    public bool grounded;
    public bool jumping;

    // Use this for initialization
    void Start () {
        body = transform.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (grounded)
        {
            StartCoroutine("Hop");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Floor") {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            grounded = false;
        }
    }

    IEnumerator Hop()
    {
        yield return new WaitForSeconds(Random.Range(min, max));
        if (grounded)
        {
            body.velocity = new Vector3(body.velocity.x, body.velocity.y + Random.Range(minVel, maxVel), body.velocity.z);
        }
    }
}
