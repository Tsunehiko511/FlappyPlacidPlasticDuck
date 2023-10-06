using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    // ��肽������
    // �o�O�C��
    // �E�Q�[���I�[�o�[�������/���_���ł��Ă��܂�
    // �E��ʊO�ɂłĂ��Q�[���I�[�o�[�ɂȂ�Ȃ�



    [SerializeField] Score score;
    [SerializeField] float upSpeed;
    [SerializeField] GameManager gameManager;
    // Space�L�[�����������ɏ㏸����
    // �ERigidBody2D���擾���ď�����̑��x��ݒ肵�Ă�����

    Rigidbody2D rb2D;
    bool isDead;

    private void Awake()
    {
        // RigidBody2D���擾
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            // �֐��̏����������ŏI���
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Space�̓��͂���������[");
            //������̑��x��ݒ肵�Ă�����
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


    // �����蔻��FPipe�ɂԂ������烍�O���o���i�Q�[���I�[�o�[�j
    // Collider��ݒ肷��
    // RigidBody�̐ݒ������
    // �R�[�h����Ԃ������玩���Ŏ��s�����֐��𗘗p����

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead)
        {
            // �֐��̏����������ŏI���
            return;
        }
        // �Q�[���I�[�o�[�̏����������Ă���
        // UI��\��������
        GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead)
        {
            // �֐��̏����������ŏI���
            return;
        }
        score.AddScore(1);
    }

    // �Q�[���I�[�o�[�̎���
    // �E�ǂ̃^�C�~���O�ɁA��������̂��H
    // �E�y�ǂɂԂ������^�C�~���O�ɁAUI��\������
}
