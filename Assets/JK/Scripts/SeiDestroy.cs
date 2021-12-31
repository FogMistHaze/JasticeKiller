using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeiDestroy : MonoBehaviour
{
    public GameObject Sei;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Instantiate(Sei, transform.position, Quaternion.identity);
            Destroy(Sei);
        }
        else
        {
            Destroy(Sei, 0.1f);
        }
    }
}
