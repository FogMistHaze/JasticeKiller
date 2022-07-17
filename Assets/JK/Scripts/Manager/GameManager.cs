using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{   
    [SerializeField]
    TextMeshProUGUI timeText = default;
    static float time;
    const float StartTime = 30f;

    static bool clear;
    static bool gameover;

    void Awake()
    {
        time = StartTime;

        clear = false;
        gameover = false;
    }

    public static void ToClear()
    {
        if (clear || gameover) return;
        clear = true;

        TinyAudio.PlaySE(TinyAudio.SE.Win);
        SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
        
        Time.timeScale = 0;
    }

    public static void ToGameover()
    {
        if (clear || gameover) return;

        TinyAudio.PlaySE(TinyAudio.SE.Lose);
        SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }

    void Start()
    {
        Time.timeScale = 1;
    }

    void UpdateTimeText()
    {
        timeText.text = $"時間 {time:00}";
    }

    void FixedUpdate()
    {
        time -= Time.fixedDeltaTime;
        if (time <= 0)
        {
            time = 0;
            ToClear();
        }
        UpdateTimeText();
    }
}

/*
【ゲーム中のスクリプト】
全体管理

初期化処理
・時間
・フラグ
・ゲームの時を動かす

クリアの処理
・クリアフラグを立てる
・クリアシーンに遷移
・ゲームの時を止める

ゲームオーバーの処理
・ゲームオーバーフラグを立てる
・ゲームオーバーシーンに遷移
・ゲームの時を止める

FixedUpdate()で時間カウント
テキストに表示(UpdateTimeText())
*/