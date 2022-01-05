using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
    [SerializeField]
    string nextScene = "";

    bool sceneChanged=true;

    void Start()
    {
        //sceneChanged = false;
    }

    public void ChangeScene()
    {
        if (sceneChanged) return;

        TinyAudio.PlaySE(TinyAudio.SE.Space);
        SceneManager.LoadScene(nextScene);  
    }
    
    public void SetChangeFalse()
    {
        sceneChanged = false;
        Debug.Log("f");
    }  
    /*
    public void SetChangeTrue()
    {
        sceneChanged = true;
        Debug.Log("t");
    } 
    */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene();
        }
        /*
        if (sceneChanged == true)
        {
            
        }
        */
    }
}