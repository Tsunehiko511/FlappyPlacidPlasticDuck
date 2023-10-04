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
        // Debug.Log(waitTimer);
    }

    // 生成
    void Spawn()
    {
        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }
}
