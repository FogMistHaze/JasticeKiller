using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI lifeText = default;
    public static int life;

    private Vector3 pos;
    private Rigidbody rb;
    private Animator anim;

    private const string LA = "isLeftAttack";
    private const string RA = "isRightAttack";
    //private const string UA = "isUpAttack";
    private const string Dam = "isDamage";

    public GameObject LSei, RSei;
    public float seispeed;

    void Awake()
    {
        life = 10;
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.W) ||Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool(UA, true);
            UpAttack();
        }
        */
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            TinyAudio.PlaySE(TinyAudio.SE.sei);
            anim.SetBool(LA, true);            
            LAttack();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            TinyAudio.PlaySE(TinyAudio.SE.sei);
            anim.SetBool(RA, true);          
            RAttack();
        }
    }

    void LAttack()
    {
        GameObject obj = Instantiate(LSei);
        Rigidbody LSeirb = obj.GetComponent<Rigidbody>();
        LSeirb.AddForce(Vector3.forward * seispeed);
    }

    void RAttack()
    {
        GameObject obj = Instantiate(RSei);
        Rigidbody RSeirb = obj.GetComponent<Rigidbody>();
        RSeirb.AddForce(Vector3.forward * seispeed);
    }   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Damage);
            anim.SetBool(Dam, true);

            life--;
            //Debug.Log(life);

            if (life <= 0)
            {
                GameManager.ToGameover();
            }
            UpdateLifeText();
        }
    }

    void UpdateLifeText()
    {
        lifeText.text = $"命 {life}";
    }
}
