using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 pos;
    //private Rigidbody rb;
    private Animator anim;

    //public float speed = 2;

    private const string key_isJump = "isJump";
    private const string key_isAttack = "isAttack";

    void Start()
    {
        this.anim = GetComponent<Animator>();
        //rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(pos.x+1, pos.y, pos.z);

        //ジャンプ
        if (Input.GetKey(KeyCode.Space))
        {
            this.anim.SetBool(key_isJump, true);
        }
        else
        {
            this.anim.SetBool(key_isJump, false);
        }

        //攻撃
        if (Input.GetKey(KeyCode.E))
        {
            this.anim.SetBool(key_isAttack, true);
        }
        else
        {
            this.anim.SetBool(key_isAttack, false);
        }
    }
}
