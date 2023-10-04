using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // �Q�[���̏�Ԃ̊Ǘ��F�I�[�o�[�������ǂ���
    // �Q�[���I�[�o�[���Ă���΁A�G���^�[�Ń��g���C�ł���
    // �E���[�U�[�̃L�[�{�[�h���͂��󂯕t����
    // �E�Q�[���I�[�o�[�ɂȂ������ǂ����̓t���O�Ŕ��f����

    [SerializeField] GameObject gameOverPanel;
    bool isGameOver = false;


    private void Update()
    {
        
        if (isGameOver && Input.GetKeyDown(KeyCode.Return))
        {
            // ���g���C=�����V�[����ǂݍ���
            string thisScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(thisScene);
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        isGameOver = true;
    }
}
