using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 pos;
    private Rigidbody rb;
    private Animator anim;

    private const string LA = "isLeftAttack";
    private const string RA = "isRightAttack";
    private const string UA = "isUpAttack";
    private const string Dam = "isDamage";

    public GameObject Sei, Gun;
    public float seispeed;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W) ||Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool(UA, true);
            Shot();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool(LA, true);
            Shot();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool(RA, true);
            Shot();
        }
    }

    void Shot()
    {
        GameObject obj = Instantiate(Sei, Gun.transform.position, Quaternion.identity);
        Rigidbody Seirb = obj.GetComponent<Rigidbody>();
        Seirb.AddForce(Gun.transform.forward * seispeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            anim.SetBool(Dam, true);
        }
    }
}
