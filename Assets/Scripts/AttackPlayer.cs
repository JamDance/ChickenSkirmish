using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour {

    private Transform target;
    private Vector3 position;
    public float speed = 2f;
    private float randX = 0;
    private float randY = 0;
    private float randZ = 0;
    //private Vector3 speedRot = Vector3.right * 50f;

    void Start()
    {
        // target = GameObject.FindGameObjectWithTag("MainCamera").transform;
        // transform.LookAt(target);
        randX = Random.Range(-0.1f, 0.1f);
        randY = Random.Range(-0.1f, 0.1f);
        randZ = Random.Range(-0.1f, 0.1f);
        // Physics.IgnoreCollision(GameObject.FindGameObjectWithTag("Wood").GetComponent<Collider>(), GetComponent<Collider>());

    }

    void FixedUpdate()
    {
        //transform.Rotate(speedRot * Time.deltaTime);
        //transform.LookAt(target);
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
        position = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
        transform.LookAt(target);

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(position.x + randX, position.y + randY, position.z + randZ), speed * Time.deltaTime);
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Physics.IgnoreCollision(enemy.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
