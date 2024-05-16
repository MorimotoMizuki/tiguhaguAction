using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dossun : MonoBehaviour
{
    public PlayerController playerController;

    public float forwordlimit=20.0f;//感知開始位置設定用
    public float backlimit=10.0f;//感知終了位置設定用

    public float forwordpower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.transform.position.z> transform.position.z-forwordlimit&&playerController.transform.position.z< transform.position.z - backlimit)
        {
            transform.position -= forwordpower * transform.forward;
        }
    }
}
