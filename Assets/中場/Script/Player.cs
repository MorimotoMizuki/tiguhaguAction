using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController characterController;//CharacterController�ϐ�
    private Animator animator;                      //Animator�ϐ�
    private Vector3 vector;                         //�L�����N�^�[�R���g���[���[�𓮂������߂�Vector3�ϐ�
    private int jumpCount = 0;//�W�����v�J�E���g

    public float moveSpeed;//�ړ����x
    public float jumpPower;//�W�����v��

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.transform;           //transform���擾
        Vector3 localAngle = transform.localEulerAngles;//���[�J�����W����ɁA��]���擾
        localAngle.y = 0.0f;                            //���[�J�����W����ɁAy�������ɂ�����]��0�x�ɕύX
        transform.localEulerAngles = localAngle;        //��]�p�x��ݒ�

        characterController.Move(this.gameObject.transform.forward * moveSpeed * Time.deltaTime);
        animator.SetBool("Run", true);//�A�j���[�^�[�p�����[�^�[Run��true�ɂ���

        //A�L�[�������ꂽ��
        if (Input.GetKey(KeyCode.A))
        {
            characterController.Move(this.gameObject.transform.right * -1 * moveSpeed * Time.deltaTime);
        }
        //D�L�[�������ꂽ��
        if (Input.GetKey(KeyCode.D))
        {
            characterController.Move(this.gameObject.transform.right * moveSpeed * Time.deltaTime);
        }

        // �W�����v
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount == 0)
        {
            vector.y = jumpPower;
            jumpCount++;
            animator.SetBool("Jump", true);
            Debug.Log("�W�����v");
        }
        //�󒆂ɂ��鎞
        else
        {
            //�d�͂�������
            vector.y += Physics.gravity.y * Time.deltaTime;
        }

        //�L�����N�^�[�𓮂���
        characterController.Move(vector * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        //�n�ʔ���
        if (collider.gameObject.tag == "Ground")
        {
            jumpCount = 0;
            animator.SetBool("Jump", false);
            Debug.Log("�n��");
        }
    }
}
