using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float ZPower=0.1f;//�O������Ɉړ����邽�߂̗͂�����ϐ�
    public float XPower=0.1f;//�������Ɉړ����邽�߂̗͂�����ϐ�

    public float RightLimit = 4.0f;//�E�������E
    public float LeftLimit = -4.0f;//���������E

    public float ForwordLimit = 0.0f;//�O�������E
    public float BackwordLimit = 0.0f;//��O�������E

    int direc = 1;//�����ύX�p�ϐ�


    public bool isX_Axis=false;//X�������Ɉړ������������ǂ���
    public bool isZ_Axis=false;//Z�������Ɉړ������������ǂ���
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
        if (transform.position.x > RightLimit)//�E���E�ɒB�����甽�΂ɕύX
        {
            direc = -1;
        }
        if (transform.position.x < LeftLimit)//�����E�ɒB�����甽�΂ɕύX
        {
            direc = 1;
        }

        transform.position += transform.right * XPower * direc;
    }

    public void Z_Axis_Move() 
    {
        if (transform.position.z > ForwordLimit)//�O�������E�ɒB�����甽�΂ɕύX
        {
            direc = -1;
        }
        if (transform.position.z < BackwordLimit)//��O�������E�ɒB�����甽�΂ɕύX
        {
            direc = 1;
        }

        transform.position += transform.forward * ZPower * direc;
    }

}
