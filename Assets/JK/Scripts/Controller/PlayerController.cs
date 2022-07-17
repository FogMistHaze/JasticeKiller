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
    private const string Dam = "isDamage";
    private const string Win = "isWin";
    private const string Lose = "isLose";

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
        LSeirb.velocity=(Vector3.left * seispeed);
    }

    void RAttack()
    {
        GameObject obj = Instantiate(RSei);
        Rigidbody RSeirb = obj.GetComponent<Rigidbody>();
        RSeirb.velocity=(Vector3.right * seispeed);
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
                anim.SetBool(Lose, true);
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
/*
 【プレイヤー(正義)のスクリプト】
Aと左矢印で左側に攻撃、Dと右矢印で右側に攻撃する
攻撃は「正」という文字を重力の力で飛ばす

Enemyに当たったら、isDamegeのアニメーションを行い、命が１削られる

プレイヤーのHPは命として数字で表示される
*/