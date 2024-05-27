using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Rigidbody rb;
    //float forwordpower = 0.01f;//前方向の強制移動の力
    //float times = 1.00001f;//徐々に加速するための

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
            //rb.velocity = Vector3.forward * 2.0f;//前方向に２Nの力で移動する
            transform.position += playerController.forwordpower * transform.forward;//プレイヤーの前進スピードに合わせて移動する
            if(playerController.playerpos.x<-5)
            {
                transform.position = new Vector3(playerController.playerpos.x, transform.position.y, transform.position.z);
            }
            else if (playerController.playerpos.x > 5)
            {
                transform.position = new Vector3(playerController.playerpos.x , transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
            }

            if (playerController.isClear || playerController.isOver)//クリアもしくはオーバー時に止める
            {
                playerController.forwordpower = 0.0f;
            }
        }
    }
}
