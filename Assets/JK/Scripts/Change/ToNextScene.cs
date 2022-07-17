using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
    [SerializeField]
    string nextScene = "";

    bool sceneChanged=true;

    public void ChangeScene()
    {
        if (sceneChanged) return;

        TinyAudio.PlaySE(TinyAudio.SE.Space);
        SceneManager.LoadScene(nextScene);  
    }
    
    public void SetChangeFalse()
    {
        sceneChanged = false;
    }  

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene();
        }
    }
}

/*
【シーン遷移プログラム】
nextSceneに入れた名前のシーンに遷移する。SPACEキーでも遷移する
アニメーションが完了するまで機能しない(sceneChangedがfalseになるまで)
*/