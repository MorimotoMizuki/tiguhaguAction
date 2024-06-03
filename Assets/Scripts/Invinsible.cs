using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invinsible : MonoBehaviour
{
    public GameObject playerObj;//プレイヤーオブジェクトを取ってくる
    Collider playerCol;//プレイヤーのコライダー格納用変数
    public SkinnedMeshRenderer playerMat;
    public float invisi_time;//無敵時間用変数
    bool isInvisi = false;//無敵かどうか
    public Material invisible;
    public Material nomal;


    // Start is called before the first frame update
    void Start()
    {
        playerCol = playerObj.GetComponent<CapsuleCollider>();
        //playerMat = playerObj.GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isInvisi)
        {
            invisi_time += 1f;
            playerMat.material = invisible;
            if(invisi_time>150)
            {
                isInvisi = false;
                playerCol.enabled = true;
                playerMat.material = nomal;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isInvisi = true;
        playerCol.enabled = false;

    }
}
