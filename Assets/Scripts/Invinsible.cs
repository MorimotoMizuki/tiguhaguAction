using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invinsible : MonoBehaviour
{
    public GameObject playerObj;//�v���C���[�I�u�W�F�N�g������Ă���
    Collider playerCol;//�v���C���[�̃R���C�_�[�i�[�p�ϐ�
    public SkinnedMeshRenderer playerMat;
    public float invisi_time;//���G���ԗp�ϐ�
    bool isInvisi = false;//���G���ǂ���
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
