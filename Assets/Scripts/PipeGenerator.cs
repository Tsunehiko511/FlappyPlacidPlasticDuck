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
    }

    // ����
    void Spawn()
    {
        Vector3 pos = transform.position;
        // �����_���ɐ����ʒu��ς�����
        // int r = Random.Range(0,100); // 0-99�܂ł̐������烉���_���ɂP�I�΂��

        pos.y += Random.Range(-5f, 5f); // -5����5�܂ł̃����_���Ȑ���
        Instantiate(pipePrefab, pos, Quaternion.identity);
    }
}
