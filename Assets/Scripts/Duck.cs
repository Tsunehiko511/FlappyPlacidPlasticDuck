using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
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
}
