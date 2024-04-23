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
    public int playerHP=10;

    float times=1.00001f;//���X�ɉ������邽�߂�

    public PlayerCollision playerCollision;
    public Blinkinger blinkinger;

    public bool isBlink = false;//�_�ł��Ă��邩�ǂ���
    public bool isClear = false;//�N���A���Ă��邩�ǂ���

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += forwordpower * transform.forward;
        //rb.velocity = Vector3.forward * 2.0f;//�O�����ɂQN�̗͂ňړ�����



        if (Input.GetKeyDown(KeyCode.Space)&&-4.0f<transform.position.x)//�������Ɉړ�
        {
            transform.position -= widthpower * transform.right;
        }
        if((Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1))&&transform.position.x<4.0f)//�E�����Ɉړ�
        {
            transform.position += widthpower * transform.right;
        }

        if(Input.GetMouseButton(2)&&Input.GetKey(KeyCode.Return)&isGround)//�W�����v
        {
            transform.position += jumpforce * transform.up;
        }

        forwordpower *= times;

        if(isClear)
        {
            transform.position = new Vector3(0, 1, 180);
        }
        
    }
 
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")//�n�ʂƐڐG���Ă邩�ǂ���
        {
            isGround = true;
        }

        
    }
    private void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        playerCollision.PCollision(other);
        isBlink = true;
        blinkinger._time = 0.0f;
        
        
    }
}
