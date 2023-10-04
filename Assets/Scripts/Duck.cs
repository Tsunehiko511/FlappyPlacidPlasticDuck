using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    [SerializeField] float upSpeed;
    // Spaceキーを押したら上に上昇する
    // ・RigidBody2Dを取得して上方向の速度を設定してあげる

    Rigidbody2D rb2D;

    private void Awake()
    {
        // RigidBody2Dを取得
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Spaceの入力があったよー");
            //上方向の速度を設定してあげる
            rb2D.velocity = Vector3.up * upSpeed;

        }
    }
}
