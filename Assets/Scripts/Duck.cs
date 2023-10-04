using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] float upSpeed;
    // Space�L�[�����������ɏ㏸����
    // �ERigidBody2D���擾���ď�����̑��x��ݒ肵�Ă�����

    Rigidbody2D rb2D;

    private void Awake()
    {
        // RigidBody2D���擾
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Space�̓��͂���������[");
            //������̑��x��ݒ肵�Ă�����
            rb2D.velocity = Vector3.up * upSpeed;

        }
    }


    // �����蔻��FPipe�ɂԂ������烍�O���o���i�Q�[���I�[�o�[�j
    // Collider��ݒ肷��
    // RigidBody�̐ݒ������
    // �R�[�h����Ԃ������玩���Ŏ��s�����֐��𗘗p����

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�Ԃ�������[");
        // �Q�[���I�[�o�[�̏����������Ă���
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.AddScore(1);
    }
}
