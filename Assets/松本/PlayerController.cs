using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    float forwordpower = 0.01f;//前方向の強制移動の力
    float widthpower = 0.1f;//横移動の幅
    float jumpforce = 0.2f;//ジャンプ時の力加減
    bool isGround = false;//地面についているかどうか
    public int playerHP=10;//プレイヤーのHP

    float times=1.00001f;//徐々に加速するための

    public PlayerCollision playerCollision;
    public Blinkinger blinkinger;

    //public bool isBlink = false;//点滅しているかどうか
    public bool isClear = false;//クリアしているかどうか
    public bool isOver = false;//ゲームオーバーしているかどうか



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)&&-5.0f<transform.position.x&&!isClear)//左方向に移動
        {
            transform.position -= widthpower * transform.right;
        }
        if((Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1))&&transform.position.x<5.0f&&!isClear)//右方向に移動
        {
            transform.position += widthpower * transform.right;
        }

        if(Input.GetMouseButton(2)&&Input.GetKey(KeyCode.Return)&isGround&&!isClear)//ジャンプ
        {
            transform.position += jumpforce * transform.up;
        }

        forwordpower *= times;

        if(isClear||isOver)
        {
            forwordpower = 0.0f;
        }

        transform.position += forwordpower * transform.forward;
        //rb.velocity = Vector3.forward * 2.0f;//前方向に２Nの力で移動する
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")//地面と接触してるかどうか
        {
            isGround = true;
        }

        
    }
    private void OnCollisionExit(Collision collision)//コリジョンから離れている＝地面と接触していない
    {
        isGround = false;
    }

    private void OnTriggerEnter(Collider other)//Triggerに接触したとき
    {
        playerCollision.PCollision(other);
        //isBlink = true;
        blinkinger._time = 0.0f;
        
        
    }
}
