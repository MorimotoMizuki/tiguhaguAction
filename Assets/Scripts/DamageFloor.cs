using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFloor : MonoBehaviour
{
    public PlayerController playerController;
    public HPbarManager hpbarManager;
    public StageSEManager stageSEManager;
    public PlayerCollision playerCollision;

    //Player���_���[�W���ɏ���Ă��邩�ǂ������肷��
    private bool PlayerStay = false;

    private void OnTriggerEnter(Collider other)
    {
        PlayerStay = true;
        Damage();
    }
    private void OnTriggerExit(Collider other)//���ꂽ��
    {
        PlayerStay = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" &&PlayerStay == false)//Player�ƐڐG
        {
            PlayerStay = true;

            Invoke("Damage", 1.0f);
        }
    }

    private void Damage()//�_���[�W�����炷
    {
        if(PlayerStay)
        {
            playerController.playerHP -= 1;//HP 5���炷
            hpbarManager.HPdamage();
            playerCollision.isBlink = true;
            stageSEManager.DamageSE();
            PlayerStay = false;
        }
    }
}
