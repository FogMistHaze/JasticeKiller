using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    ToNextScene toNextScene;

    void Start()
    {
        toNextScene = GetComponent<ToNextScene>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            toNextScene.ChangeScene();
        }
    }
}
