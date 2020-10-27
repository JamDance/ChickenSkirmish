using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour {


    public GameObject spawnObject;
    public float spawnDelay;
    private bool occupied;
    private Collider col;
	
	void Update () { 

	}

    private void Start()
    {
        InvokeRepeating("Spawn", 3f, spawnDelay);
    }

    private void Spawn()
    {
        if (!occupied)
        {
            GameObject newGo = GameObject.Instantiate(spawnObject);
            newGo.transform.position = new Vector3(transform.position.x + Random.Range(-4, 4), transform.position.y + Random.Range(-0.5f, 0.5f), transform.position.z - 1);
            GameObject parent = GameObject.Find("MeleePractice");
            newGo.transform.SetParent(parent.transform);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == spawnObject.name + "(Clone)")
        {
            occupied = true;
            //this.col = other;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == spawnObject.name + "(Clone)")
        {
            occupied = false;
        }
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

}
