using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // Pipeを一定間隔で生成する
    //・Prefabの生成
    //・一定間隔

    [SerializeField] Pipe pipePrefab;
    float spawnTime = 2f;// ２秒間隔で生成したい
    float waitTimer = 0;


    // Update is called once per frame
    void Update()
    {
        waitTimer += Time.deltaTime;
        if (waitTimer >= spawnTime)
        {
            waitTimer = 0;
            Spawn();
        }
    }

    // 生成
    void Spawn()
    {
        Vector3 pos = transform.position;
        // ランダムに生成位置を変えたい
        // int r = Random.Range(0,100); // 0-99までの数字からランダムに１つ選ばれる

        pos.y += Random.Range(-5f, 5f); // -5から5までのランダムな数字
        Instantiate(pipePrefab, pos, Quaternion.identity);
    }
}
