using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController characterController;//CharacterController変数
    private Animator animator;                      //Animator変数
    private Vector3 vector;                         //キャラクターコントローラーを動かすためのVector3変数
    private int jumpCount = 0;                      //ジャンプカウント
    //private float rayLength = 1.0f;               // Raycastの長さ

    public float moveSpeed;//移動速度
    public float jumpPower;//ジャンプ力

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;

        var origin = new Vector3(1, 2, 3);
        var direction = new Vector3(4, 5, 6);

        var ray = new Ray(this.transform.position, new Vector3(1, 2, 3));

        //Physics.Raycast(Vector3 origin(rayの開始地点), Vector3 direction(rayの向き), RaycastHit hitInfo(当たったオブジェクトの情報を格納), float distance(rayの発射距離), int layerMask(レイヤマスクの設定));

        Transform transform = this.transform;           //transformを取得
        Vector3 localAngle = transform.localEulerAngles;//ローカル座標を基準に、回転を取得
        localAngle.y = 0.0f;                            //ローカル座標を基準に、y軸を軸にした回転を0度に変更
        transform.localEulerAngles = localAngle;        //回転角度を設定
        
        characterController.Move(this.gameObject.transform.forward * moveSpeed * Time.deltaTime);
        animator.SetBool("Run", true);//アニメーターパラメーターRunをtrueにする

        //Aキーがおされたら
        if (Input.GetKey(KeyCode.A))
        {
            characterController.Move(this.gameObject.transform.right * -1 * moveSpeed * Time.deltaTime);
        }
        //Dキーがおされたら
        if (Input.GetKey(KeyCode.D))
        {
            characterController.Move(this.gameObject.transform.right * moveSpeed * Time.deltaTime);
        }

        // ジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount == 0)
        {
            vector.y = jumpPower;
            jumpCount++;
            animator.SetBool("Jump", true);
            Debug.Log("ジャンプ");
        }
        //空中にいる時
        else
        {
            //重力をかける
            vector.y += Physics.gravity.y * Time.deltaTime;
        }

        //キャラクターを動かす
        characterController.Move(vector * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        //地面判定
        if (collider.gameObject.tag == "Ground")
        {
            jumpCount = 0;
            animator.SetBool("Jump", false);
            Debug.Log("地面");
        }
    }
}
