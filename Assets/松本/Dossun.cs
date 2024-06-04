using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dossun : MonoBehaviour
{
    public PlayerController playerController;

    public float forwordlimit=20.0f;//���m�J�n�ʒu�ݒ�p
    public float backlimit=10.0f;//���m�I���ʒu�ݒ�p

    public bool isRight;//�E�����Ɉړ�����h�b�X��
    public bool isLeft;//�������Ɉړ�����h�b�X��
    public bool isFB;//�O��h�b�X��

    public float forwordpower;//�O�i�^���ɕK�v�ȕϐ�
    public float sidepower;//�������^���ɕK�v�ȕϐ�
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
