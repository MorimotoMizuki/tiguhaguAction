using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Rigidbody rb;
    //float forwordpower = 0.01f;//‘O•ûŒü‚Ì‹­§ˆÚ“®‚Ì—Í
    float times = 1.00001f;//™X‚É‰Á‘¬‚·‚é‚½‚ß‚Ì

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartButtonSC.isStart)
        {
            //rb.velocity = Vector3.forward * 2.0f;//‘O•ûŒü‚É‚QN‚Ì—Í‚ÅˆÚ“®‚·‚é
            transform.position += playerController.forwordpower * transform.forward;

            playerController.forwordpower *= times;

            if (playerController.isClear || playerController.isOver)
            {
                playerController.forwordpower = 0.0f;
            }
        }
    }
}
