using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieLeft : MonoBehaviour
{
    private Animator anim;
    private const string Die = "Die";
    private const string ATK = "isAttack";

    public float speed = 0.1f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Sei")
        {
            anim.SetBool("Die", true);
        }
    }
}
