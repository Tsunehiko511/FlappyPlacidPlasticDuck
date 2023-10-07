using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceBGM;
    [SerializeField] AudioSource audioSourceSE;


    [SerializeField] AudioClip[] audioClipsBGM;
    [SerializeField] AudioClip[] audioClipsSE;

    // �ǂ̃t�@�C������ł����s�ł���悤�ɂ���i�V���O���g���j
    public static SoundManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // PlayBGM(BGM.Title);
    }

    public void PlayBGM(BGM type)
    {
        int num = (int)type;
        audioSourceBGM.clip = audioClipsBGM[num];
        audioSourceBGM.Play();
    }

    public void PlaySE(SE type)
    {
        int num = (int)type;
        audioSourceSE.PlayOneShot(audioClipsSE[num]);
    }
}

public enum BGM
{
    Title,
    Main,
}

public enum SE
{
    Point,
}