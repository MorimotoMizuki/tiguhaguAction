using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    float speed = 0.1f;//横移動の幅
    float jumpforce = 1.0f;//ジャンプ時の力加減
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.forward * 2.0f;//前方向に２Nの力で移動する

        if(Input.GetKeyDown(KeyCode.Space))//左方向に移動
        {
            transform.position -= speed * transform.right;
        }
        if(Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1))//右方向に移動
        {
            transform.position += speed * transform.right;
        }

        if(Input.GetMouseButton(2)&&Input.GetKey(KeyCode.Return))//ジャンプ
        {
            transform.position += speed * transform.up;
        }
    }
}
