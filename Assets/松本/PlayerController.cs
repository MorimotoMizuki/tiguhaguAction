using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    float speed = 0.1f;//���ړ��̕�
    float jumpforce = 1.0f;//�W�����v���̗͉���
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.forward * 2.0f;//�O�����ɂQN�̗͂ňړ�����

        if(Input.GetKeyDown(KeyCode.Space))//�������Ɉړ�
        {
            transform.position -= speed * transform.right;
        }
        if(Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1))//�E�����Ɉړ�
        {
            transform.position += speed * transform.right;
        }

        if(Input.GetMouseButton(2)&&Input.GetKey(KeyCode.Return))//�W�����v
        {
            transform.position += speed * transform.up;
        }
    }
}
