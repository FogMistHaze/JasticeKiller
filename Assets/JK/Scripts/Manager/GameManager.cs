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
        SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
        Time.timeScale = 0;

        //audio.volume = 0;

        //GetTime();
        //var timeScore = new System.TimeSpan(0, 0, min, sec, 0);
        //naichilab.RankingLoader.Instance.SendScoreAndShowRanking(timeScore);
    }

    public static void ToGameover()
    {
        //audio.volume = 0;
        if (clear || gameover) return;
        SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }

    void Start()
    {
        //audio = GetComponent<AudioSource>();
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
