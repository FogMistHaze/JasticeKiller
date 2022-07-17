using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeiDestroy : MonoBehaviour
{
    public GameObject Effect;

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.tag == "Enemy") || (collision.collider.tag == "atata"))
        {
            //Instantiate(Sei, transform.position, Quaternion.identity);
            Destroy(gameObject);
            GenerateEffect();
        }
        else
        {
            Destroy(gameObject, 1.0f);
        }
    }

    void GenerateEffect()
    {
        GameObject effect = Instantiate(Effect) as GameObject;
        effect.transform.position = gameObject.transform.position;
    }
}

/*
【プレイヤー(正義)の攻撃である「正」のスクリプト】
敵に当たったら爆発(GenerateEffecr())して消える

爆発は正を軸に行われる
*/