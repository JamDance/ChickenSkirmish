using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour {


    public GameObject spawnObject;
    public float spawnDelay;
    private bool occupied;

    private void Start()
    {
        Debug.Log("Start");
        Invoke("Spawn", spawnDelay);
    }

    private void Spawn()
    {
        if (!occupied)
        {
            GameObject newGo = GameObject.Instantiate(spawnObject);
            newGo.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.05f, this.transform.position.z);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == spawnObject.name + "(Clone)")
        {
            occupied = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Debug.Log(other);
        // Debug.Log(spawnObject.name);
        if (other.name == spawnObject.name + "(Clone)")
        {
            occupied = false;
            Invoke("Spawn", spawnDelay);
        }

    }
}
