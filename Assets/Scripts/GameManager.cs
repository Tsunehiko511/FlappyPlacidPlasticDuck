using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ゲームの状態の管理：オーバーしたかどうか


    [SerializeField] GameObject gameOverPanel;


    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
}
