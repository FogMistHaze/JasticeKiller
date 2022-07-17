using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinyAudio : MonoBehaviour
{
    public static TinyAudio Instance;

    public enum SE
    {
        Space,
        sei,
        Damage,
        Win,
        Lose
    }

    [SerializeField]
    AudioClip[] seList = null;

    AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySE(SE se)
    {
        Instance.audioSource.PlayOneShot(Instance.seList[(int)se]);
    }
}

/*
【音源管理スクリプト】
SEのリストを作り、音源を入れる
PlaySE()で特定のSEを再生する
*/