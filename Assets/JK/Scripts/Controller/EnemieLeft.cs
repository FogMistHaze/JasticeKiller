using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieLeft : MonoBehaviour
{
    private Animator anim;
    private const string Die = "isDie";
    private const string ATK = "isAttack";

    public float speed = 0.1f;
    public GameObject Ene;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.tag == "sei"))
        {
            anim.SetBool(Die, true);
            Destroy(Ene, 2);
        }
        if((collision.collider.tag == "Player"))
        {
            anim.SetBool(ATK, true);
            Destroy(Ene, 1);
        }
    }
}
