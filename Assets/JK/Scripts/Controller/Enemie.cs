﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    private Animator anim;
    private const string Die = "isDie";
    private const string ATK = "isAttack";

    public float speed = 0.1f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.tag == "sei"))
        {
            this.gameObject.tag = "atata";
            anim.SetBool(Die, true);
            Destroy(gameObject, 1.0f);
        }
        if((collision.collider.tag == "Player"))
        {
            anim.SetBool(ATK, true);
            Destroy(gameObject, 1.0f);
        }
    }
}

/*
 【偽正義のスクリプト】
プレイヤーの攻撃seiに当たったら、isDieのアニメーションを行い、消える
プレイヤーの近くに来たら、isAttackのアニメーションを行い、消える
 */