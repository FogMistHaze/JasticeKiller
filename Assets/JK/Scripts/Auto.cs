using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Auto : MonoBehaviour
{
    //??('ω')??
    public GameObject target;
    private NavMeshAgent nav;

    //private float rotateSpeed = 45f;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        nav.destination = target.transform.position;

        //var playerDirection = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z) - transform.position;
        //var dir = Vector3.RotateTowards(transform.forward, playerDirection, rotateSpeed * Time.deltaTime, 0f);
        //transform.rotation = Quaternion.LookRotation(dir);
    }
}
