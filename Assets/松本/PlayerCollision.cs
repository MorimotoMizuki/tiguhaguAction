using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;
    public Blinkinger blinkinger;
    public Gameclearover gameclearover;
    public HPbarManager hpbarManager;

    public bool isBlink = false;//点滅しているかどうか

    public void PCollision(Collider other)//接触時に呼び出される
    {
        if (other.gameObject.tag == "Obstacle")//障害物
        {
            playerController.playerHP--;
            hpbarManager.HPdamage();
            isBlink = true;
        }
        if(other.gameObject.tag=="Clear")//クリアWall
        {
            gameclearover.GameClearobj.SetActive(true);
            playerController.isClear = true;
        }
    }
}
