using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int score;


    public void AddScore(int point)
    {
        score += point;
        scoreText.text = score.ToString();
        // ‰¹‚ð–Â‚ç‚·
        // audioSource.PlayOneShot(se);
        SoundManager.instance.PlaySE(SE.Point);
    }
}
