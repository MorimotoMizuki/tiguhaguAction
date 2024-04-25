using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float ZPower=0.1f;//前後方向に移動するための力を入れる変数
    public float XPower=0.1f;//横方向に移動するための力を入れる変数

    public float RightLimit = 4.0f;//右方向限界
    public float LeftLimit = -4.0f;//左方向限界

    public float ForwordLimit = 0.0f;//前方向限界
    public float BackwordLimit = 0.0f;//手前方向限界

    int direc = 1;//向き変更用変数


    public bool isX_Axis=false;//X軸方向に移動させたいかどうか
    public bool isZ_Axis=false;//Z軸方向に移動させたいかどうか
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isX_Axis)
            X_Axis_Move();

        if (isZ_Axis)
            Z_Axis_Move();

    }

    void X_Axis_Move()
    {
        if (transform.position.x > RightLimit)//右限界に達したら反対に変更
        {
            direc = -1;
        }
        if (transform.position.x < LeftLimit)//左限界に達したら反対に変更
        {
            direc = 1;
        }

        transform.position += transform.right * XPower * direc;
    }

    public void Z_Axis_Move() 
    {
        if (transform.position.z > ForwordLimit)//前方向限界に達したら反対に変更
        {
            direc = -1;
        }
        if (transform.position.z < BackwordLimit)//手前方向限界に達したら反対に変更
        {
            direc = 1;
        }

        transform.position += transform.forward * ZPower * direc;
    }

}
