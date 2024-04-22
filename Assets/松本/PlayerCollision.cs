using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;

   public void Collision(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {

        }
        playerController.playerHP--;
    }
}
