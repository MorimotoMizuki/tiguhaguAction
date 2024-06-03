using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFloor : MonoBehaviour
{
    public PlayerController playerController;
    public HPbarManager hpbarManager;
    public StageSEManager stageSEManager;
    public PlayerCollision playerCollision;

    //Playerがダメージ床に乗っているかどうか判定する
    private bool PlayerStay = false;

    private void OnTriggerEnter(Collider other)
    {
        PlayerStay = true;
        Damage();
    }
    private void OnTriggerExit(Collider other)//離れたら
    {
        PlayerStay = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" &&PlayerStay == false)//Playerと接触
        {
            PlayerStay = true;

            Invoke("Damage", 1.0f);
        }
    }

    private void Damage()//ダメージを減らす
    {
        if(PlayerStay)
        {
            playerController.playerHP -= 1;//HP 5減らす
            hpbarManager.HPdamage();
            playerCollision.isBlink = true;
            stageSEManager.DamageSE();
            PlayerStay = false;
        }
    }
}
