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
    public Clear_pic_Generate clear_pic_generate;
    public StageSEManager stageSEManager;

    public bool isBlink = false;//�_�ł��Ă��邩�ǂ���
    public ScoreManager scoreManager;

    public int stage1MAXscore;
    public int stage2MAXscore;
    public int stage3MAXscore;
    public int playerHPMAX;

    private Collider otherCol;

    public void PCollision(Collider other)//�ڐG���ɌĂяo�����
    {
        otherCol = null;
        if (other.gameObject.tag == "Obstacle")//��Q��(����)
        {
            playerController.playerHP-=5;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "Obstacle2")//��Q��(��)
        {
            playerController.playerHP -= 10;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "IronBall")//��Q��(�S��)
        {
            playerController.playerHP -= 15;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "Bard")//��Q��(��)
        {
            playerController.playerHP -= 10;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "Obstacle3")//��Q��(�Ă���)
        {
            playerController.playerHP -= 10;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "Obstacle4")//��Q��(�Ă���)
        {
            playerController.playerHP -= 15;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "RedBall")//��Q��(�ԋ�)
        {
            playerController.playerHP -= 20;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "HeelPotion")//�񕜃|�[�V����
        {
            if(playerController.playerHP != playerHPMAX)
            {
                if (playerHPMAX - playerController.playerHP > 5)
                {
                    playerController.playerHP += 5;
                }
                else if(playerHPMAX - playerController.playerHP < 5)
                {
                    playerController.playerHP += playerHPMAX - playerController.playerHP;
                }
                hpbarManager.HPdamage();
                stageSEManager.HeelSE();
            }
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "Over")//�Q�[���I�[�o�[
        {
            playerController.isOver = true;
        }

        if (other.gameObject.tag=="Clear")//�N���AWall
        {
            gameclearover.GameClearobj.SetActive(true);
            playerController.isClear = true;
            stageSEManager.ClearSE();

            //�X�R�A��ۑ�����Parfect���ǂ�������
            if (GameManager.stage_num == 1)
            {
                if(scoreManager.score_num>PlayerPrefs.GetInt("STAGE1SCORE",-1))
                    PlayerPrefs.SetInt("STAGE1SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage1MAXscore && playerController.playerHP == playerHPMAX)
                    GameManager.stage1_P = true;
            }
            if (GameManager.stage_num == 2)
            {
                if (scoreManager.score_num > PlayerPrefs.GetInt("STAGE2SCORE", -1))
                    PlayerPrefs.SetInt("STAGE2SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage2MAXscore && playerController.playerHP == playerHPMAX)
                    GameManager.stage2_P = true;
            } 
            if (GameManager.stage_num == 3)
            {
                if (scoreManager.score_num > PlayerPrefs.GetInt("STAGE3SCORE", -1))
                    PlayerPrefs.SetInt("STAGE3SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage3MAXscore && playerController.playerHP == playerHPMAX)
                    GameManager.stage3_P = true;
            }
            if (GameManager.stage_num == 1)
                GameManager.stage1_clear = true;
            if (GameManager.stage_num == 2)
                GameManager.stage2_clear = true;
            if (GameManager.stage_num == 3)
                GameManager.stage3_clear = true;

            //�N���A�������̉��o
            clear_pic_generate.ClearDisplay();
        }
        if(other.gameObject.tag == "Gold")//���R�C��
        {
            scoreManager.score_num += 3000;
            Destroy(other.gameObject);
            stageSEManager.CoinSE();
        }
        if(other.gameObject.tag == "Silver")//��R�C���擾��
        {
            scoreManager.score_num += 1500;
            Destroy(other.gameObject);
            stageSEManager.CoinSE();
        }
        if(other.gameObject.tag == "Copper")//���R�C���擾��
        {
            scoreManager.score_num += 1000;
            Destroy(other.gameObject);
            stageSEManager.CoinSE();
        }
        Debug.Log(other.gameObject.name);
        Debug.Log(other.gameObject.tag);
    }
}
