using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour {


    public GameObject spawnObject;
    public float spawnDelay;
    private bool occupied;
    private Collider col;
	
	void Update () {
        if (occupied && !col)
        {
            occupied = false;
            Invoke("Spawn", spawnDelay);
        }	    
	}

    private void Start()
    {
        Invoke("Spawn", spawnDelay);
    }

    private void Spawn()
    {
        if (!occupied)
        {
            GameObject newGo = GameObject.Instantiate(spawnObject);
            newGo.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.05f, this.transform.position.z);
            GameObject parent = GameObject.Find("TargetPractice");
            newGo.transform.SetParent(parent.transform);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == spawnObject.name + "(Clone)")
        {
            occupied = true;
            this.col = other;
        }
    }

}
