using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dossun : MonoBehaviour
{
    public PlayerController playerController;

    public float forwordlimit=20.0f;//感知開始位置設定用
    public float backlimit=10.0f;//感知終了位置設定用

    public bool isRight;//右方向に移動するドッスン
    public bool isLeft;//左方向に移動するドッスン
    public bool isFB;//前後ドッスン

    public float forwordpower;//前進運動に必要な変数
    public float sidepower;//横方向運動に必要な変数
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerController.transform.position.z> transform.position.z-forwordlimit&&playerController.transform.position.z< transform.position.z - backlimit)
        {
            if (isRight)
                R();
            if (isLeft)
                L();
            if (isFB)
                FB();
        }
    }

    void L()
    {
        transform.position -= sidepower * transform.right;
    }
    void R()
    {
        transform.position += sidepower * transform.right;
    }
    void FB()
    {
        transform.position -= forwordpower * transform.forward;
    }
}
