using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager: MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        var info = anim.GetCurrentAnimatorStateInfo(0);
        anim.Play(info.nameHash, 0, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
