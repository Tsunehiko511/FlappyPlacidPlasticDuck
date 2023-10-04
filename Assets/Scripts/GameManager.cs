using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // ゲームの状態の管理：オーバーしたかどうか
    // ゲームオーバーしていれば、エンターでリトライできる
    // ・ユーザーのキーボード入力を受け付ける
    // ・ゲームオーバーになったかどうかはフラグで判断する

    [SerializeField] GameObject gameOverPanel;
    bool isGameOver = false;


    private void Update()
    {
        
        if (isGameOver && Input.GetKeyDown(KeyCode.Return))
        {
            // リトライ=同じシーンを読み込む
            string thisScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(thisScene);
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        isGameOver = true;
    }
}
