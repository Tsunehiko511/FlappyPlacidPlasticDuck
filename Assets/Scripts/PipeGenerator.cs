using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // Pipe�����Ԋu�Ő�������
    //�EPrefab�̐���
    //�E���Ԋu

    [SerializeField] Pipe pipePrefab;
    float spawnTime = 2f;// �Q�b�Ԋu�Ő���������
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

    // ����
    void Spawn()
    {
        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }
}
