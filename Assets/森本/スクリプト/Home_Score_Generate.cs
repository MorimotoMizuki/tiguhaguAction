using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Score_Generate : MonoBehaviour
{
    //���_���̃I�u�W�F�N�g�ϐ�
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //�X�R�A���Ăяo��
    ScoreManager scoreManager;
    private int MyScore; //�Ăяo�����ϐ����i�[����ϐ�

    //�e�X�e�[�W��MAXScore���i�[����ϐ�
    private int Stage1_MAX = 11500;
    private int Stage2_MAX = 10000;
    private int Stage3_MAX = 10000;

    //�e�X�e�[�W���p�[�t�F�N�g�ŃN���A���������肷��t���O
    private bool Stage1_Perfect_flag = false;
    private bool Stage2_Perfect_flag = false;
    private bool Stage3_Perfect_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        MyScore = scoreManager.score_num;//�Ăяo����score_num���i�[

        //�X�e�[�W�P���p�[�t�F�N�g
        if (Stage1_Perfect_flag)
        {
            Instantiate(Perfect, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - 3000)//��
        {
            Instantiate(Gold, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if(MyScore <= Stage1_MAX - 3000 && MyScore >= Stage1_MAX - 8000)//��
        {
            Instantiate(Silver, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if(MyScore <= Stage1_MAX - 8000 && MyScore >= 0)//��
        {
            Instantiate(Bronze, new Vector3(0, 0, 0), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
