using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Auto : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        nav.destination = target.transform.position;
    }
}
