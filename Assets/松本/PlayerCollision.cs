using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;
    public Blinkinger blinkinger;
    public Gameclearover gameclearover;
    public HPbarManager hpbarManager;
    public GameManager gameManager;

    public bool isBlink = false;//�_�ł��Ă��邩�ǂ���
    ScoreManager scoreManager;

    public int stage1MAXscore;
    public int stage2MAXscore;
    public int stage3MAXscore;
    public int playerHPMAX;

    public void PCollision(Collider other)//�ڐG���ɌĂяo�����
    {
        if (other.gameObject.tag == "Obstacle")//��Q��
        {
            playerController.playerHP--;
            hpbarManager.HPdamage();
            isBlink = true;
        }
        if(other.gameObject.tag=="Clear")//�N���AWall
        {
            gameclearover.GameClearobj.SetActive(true);
            playerController.isClear = true;

            //�X�R�A��ۑ�����Parfect���ǂ�������
            if (gameManager.stage_num == 1)
            {
                PlayerPrefs.SetInt("STAGE1SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage1MAXscore && playerController.playerHP == playerHPMAX)
                    gameManager.stage1_P = true;
            }
            if (gameManager.stage_num == 2)
            {
                PlayerPrefs.SetInt("STAGE2SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage2MAXscore && playerController.playerHP == playerHPMAX)
                    gameManager.stage2_P = true;
            } 
            if (gameManager.stage_num == 3)
            {
                PlayerPrefs.SetInt("STAGE3SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage3MAXscore && playerController.playerHP == playerHPMAX)
                    gameManager.stage3_P = true;
            }
        }
        if(other.gameObject.tag=="Silver")//��R�C���擾��
        {
            scoreManager.score_num += 1500;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Copper")//���R�C���擾��
        {
            scoreManager.score_num += 1000;
            Destroy(other.gameObject);
        }
    }
}
