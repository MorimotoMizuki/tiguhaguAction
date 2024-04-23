using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;
    public Blinkinger blinkinger;
    public Gameclearover gameclearover;

   public void PCollision(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            playerController.playerHP--;
            blinkinger.Blink();
        }
        if(other.gameObject.tag=="Clear")
        {
            gameclearover.GameClearobj.SetActive(true);
        }
    }
}
