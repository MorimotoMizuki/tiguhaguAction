using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;
    public Blinkinger blinkinger;
    public Gameclearover gameclearover;
    public HPbarManager hpbarManager;

    public bool isBlink = false;//�_�ł��Ă��邩�ǂ���
    ScoreManager scoreManager;

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
