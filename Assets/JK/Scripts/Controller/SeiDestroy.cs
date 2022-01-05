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
