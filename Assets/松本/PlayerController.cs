using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    float forwordpower = 0.01f;//�O�����̋����ړ��̗�
    float widthpower = 0.1f;//���ړ��̕�
    float jumpforce = 0.2f;//�W�����v���̗͉���
    bool isGround = false;//�n�ʂɂ��Ă��邩�ǂ���
    public int playerHP=10;//�v���C���[��HP

    float times=1.00001f;//���X�ɉ������邽�߂�

    public PlayerCollision playerCollision;
    public Blinkinger blinkinger;

    //public bool isBlink = false;//�_�ł��Ă��邩�ǂ���
    public bool isClear = false;//�N���A���Ă��邩�ǂ���
    public bool isOver = false;//�Q�[���I�[�o�[���Ă��邩�ǂ���



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)&&-5.0f<transform.position.x&&!isClear)//�������Ɉړ�
        {
            transform.position -= widthpower * transform.right;
        }
        if((Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1))&&transform.position.x<5.0f&&!isClear)//�E�����Ɉړ�
        {
            transform.position += widthpower * transform.right;
        }

        if(Input.GetMouseButton(2)&&Input.GetKey(KeyCode.Return)&isGround&&!isClear)//�W�����v
        {
            transform.position += jumpforce * transform.up;
        }

        forwordpower *= times;

        if(isClear||isOver)
        {
            forwordpower = 0.0f;
        }

        transform.position += forwordpower * transform.forward;
        //rb.velocity = Vector3.forward * 2.0f;//�O�����ɂQN�̗͂ňړ�����
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")//�n�ʂƐڐG���Ă邩�ǂ���
        {
            isGround = true;
        }

        
    }
    private void OnCollisionExit(Collision collision)//�R���W�������痣��Ă��遁�n�ʂƐڐG���Ă��Ȃ�
    {
        isGround = false;
    }

    private void OnTriggerEnter(Collider other)//Trigger�ɐڐG�����Ƃ�
    {
        playerCollision.PCollision(other);
        //isBlink = true;
        blinkinger._time = 0.0f;
        
        
    }
}
