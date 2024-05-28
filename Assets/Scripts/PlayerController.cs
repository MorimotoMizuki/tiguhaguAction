using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;//CharacterController�ϐ�
    private Animator animator;                      //Animator�ϐ�
    private Vector3 vector;                         //�L�����N�^�[�R���g���[���[�𓮂������߂�Vector3�ϐ�

    //public Rigidbody rb;
    public float forwordpower = 0.01f;//�O�����̋����ړ��̗�
    float widthpower = 0.2f;//���ړ��̕�
    float jumpforce = 4.0f;//�W�����v���̗͉���
    public bool isGround = true;//�n�ʂɂ��Ă��邩�ǂ���
    public int playerHP=10;//�v���C���[��HP

    float times=1.0001f;//���X�ɉ������邽�߂�

    public PlayerCollision playerCollision;
    public Blinkinger blinkinger;

    //public bool isBlink = false;//�_�ł��Ă��邩�ǂ���
    public bool isClear = false;//�N���A���Ă��邩�ǂ���
    public bool isOver = false;//�Q�[���I�[�o�[���Ă��邩�ǂ���

    public Vector3 playerpos;//プレイヤーの現在地保存用

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        isClear = false;
        isOver = false;
}

    // Update is called once per frame
    void Update()//入力、判定はこっちで行うこと
    {
        if (StartButtonSC.isStart)
        {

            if (Input.GetKeyDown(KeyCode.Space) && -15.0f < transform.position.x && !isClear)//�������Ɉړ�
            {
                //transform.position -= widthpower * transform.right;
                characterController.Move(this.gameObject.transform.right * -1 * widthpower);
            }
            if ((Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) && transform.position.x < 15.0f && !isClear)//�E�����Ɉړ�
            {
                //transform.position += widthpower * transform.right;
                characterController.Move(this.gameObject.transform.right * widthpower);
            }

            if (Input.GetMouseButton(2) && Input.GetKey(KeyCode.Return) && isGround && !isClear)//�W�����v
            {
                //transform.position += jumpforce * transform.up;
                vector.y = jumpforce;
                animator.SetBool("Jump", true);
                isGround = false;
            }
            else
            {
                //�d�͂�������
                vector.y += Physics.gravity.y * Time.deltaTime;
            }



            

            

            //transform.position += forwordpower * transform.forward;
            //rb.velocity = Vector3.forward * 2.0f;//�O�����ɂQN�̗͂ňړ�����
        }
        playerpos = this.transform.position;
    }
    private void FixedUpdate()//実際に動かすときはこっちの関数を使う
    {
        Transform transform = this.transform;           //transformを保存する
        Vector3 localAngle = transform.localEulerAngles;//現在のプレイヤーの方向をとってくる
        localAngle.y = 0.0f;                            //Y軸回転を0に強制的に変える
        transform.localEulerAngles = localAngle;        //実際にここで回転を変える

        if (StartButtonSC.isStart)
        {
            characterController.Move(this.gameObject.transform.forward * forwordpower);
            animator.SetBool("Run", true);//アニメーションを基本はRunにする

            //前進運動
            characterController.Move(vector * Time.deltaTime);

            if (isClear)
            {
                forwordpower = 0.0f;//前進運動停止
                localAngle.y = 180.0f;//カメラ側を向くように回転
                transform.localEulerAngles = localAngle;//実際にここで回転を変える
                animator.SetBool("Dance", true);//アニメーションをDanceに変更
            }
            if(isOver)
            {
                forwordpower = 0.0f;//前進運動停止
                animator.SetBool("Death", true);//アニメーションをDanceに変更
            }

            forwordpower *= times;
        }
    }

    private void OnCollisionExit(Collision collision)//地面から離れたとき呼び出される
    {
        isGround = false;
        Debug.Log("isground");

    }

    private void OnTriggerEnter(Collider other)//Triggerとの接触判定
    {
        
        playerCollision.PCollision(other);
        //isBlink = true;
        blinkinger._time = 0.0f;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")//地面と接触した時呼び出される
        {
            isGround = true;
            animator.SetBool("Jump", false);
            Debug.Log("Ground");
        }
    }
}
