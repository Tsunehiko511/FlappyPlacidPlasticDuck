using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �Q�[���̏�Ԃ̊Ǘ��F�I�[�o�[�������ǂ���


    [SerializeField] GameObject gameOverPanel;


    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
}
