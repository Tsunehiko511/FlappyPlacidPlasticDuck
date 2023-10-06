using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    // やりたいこと
    // バグ修正
    // ・ゲームオーバー後も操作/得点ができてしまう
    // ・画面外にでてもゲームオーバーにならない



    [SerializeField] Score score;
    [SerializeField] float upSpeed;
    [SerializeField] GameManager gameManager;
    // Spaceキーを押したら上に上昇する
    // ・RigidBody2Dを取得して上方向の速度を設定してあげる

    Rigidbody2D rb2D;
    bool isDead;

    private void Awake()
    {
        // RigidBody2Dを取得
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            // 関数の処理をここで終わる
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Spaceの入力があったよー");
            //上方向の速度を設定してあげる
            rb2D.velocity = Vector3.up * upSpeed;
        }

        if (transform.position.y < -14 || transform.position.y > 14)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameManager.GameOver();
        isDead = true;
    }


    // 当たり判定：Pipeにぶつかったらログを出す（ゲームオーバー）
    // Colliderを設定する
    // RigidBodyの設定をする
    // コードからぶつかったら自動で実行される関数を利用する

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead)
        {
            // 関数の処理をここで終わる
            return;
        }
        // ゲームオーバーの処理を書いていく
        // UIを表示したい
        GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead)
        {
            // 関数の処理をここで終わる
            return;
        }
        score.AddScore(1);
    }

    // ゲームオーバーの実装
    // ・どのタイミングに、何をするのか？
    // ・土管にぶつかったタイミングに、UIを表示する
}
