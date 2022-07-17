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

/*
敵が主人公を追うプログラム
NavMeshAgentという機能を使った

当初はフィールドを駆け回るものを想定していた為、これを実装した
*/