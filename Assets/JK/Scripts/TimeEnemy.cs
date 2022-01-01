using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEnemy : MonoBehaviour
{
    public GameObject EnemyLeft;
    public GameObject EnemyRight;
    //public GameObject EnemyUp;

    private const float LeftStart = 0.0f;
    private const float LeftInterval = 3.0f;

    private const float RightStart = 5.0f;
    private const float RightInterval = 4.0f;

    void Start()
    {
        InvokeRepeating("UpdateMakeLeft", LeftStart, LeftInterval);
        InvokeRepeating("UpdateMakeRight", RightStart, RightInterval);
    }

    private void UpdateMakeLeft()
    {
        Instantiate(EnemyLeft, new Vector3(-20, 0, 0), Quaternion.identity);
    }

    private void UpdateMakeRight()
    {
        Instantiate(EnemyRight, new Vector3(20, 0, 0), Quaternion.identity);
    }
}
