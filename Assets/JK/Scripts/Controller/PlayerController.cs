using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 pos;
    //private Rigidbody rb;
    private Animator anim;

    private const string LA = "isLeftAttack";
    private const string RA = "isRightAttack";
    private const string UA = "isUpAttack";
    private const string Dam = "isDamage";

    void Start()
    {
        anim = GetComponent<Animator>();
        //rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W) ||Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool(UA, true);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool(LA, true);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool(RA, true);
        }
        
        /*
        if (Input.GetKeyDown(KeyCode.G))
        {
            this.anim.SetBool(Dam, true);
        }
        */
    }
}
