using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Score_Generate : MonoBehaviour
{
    public GameManager gameManager;

    //���_���̃I�u�W�F�N�g�ϐ�
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //�e���w��
    public Transform Parent;

    //�Ăяo�����X�R�A���i�[����ϐ�
    private int MyScore;

    //�e�X�e�[�W��MAXScore���i�[����ϐ�
    public int Stage1_MAX = 11500;
    public int Stage2_MAX = 10000;
    public int Stage3_MAX = 10000;

    //�e�X�e�[�W���p�[�t�F�N�g�ŃN���A���������肷��t���O
    //private bool Stage1_Perfect_flag = false;
    //private bool Stage2_Perfect_flag = false;
    //private bool Stage3_Perfect_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        //�X�e�[�W�P
        //�}�C�X�R�A�ɃX�R�A���i�[
        MyScore = PlayerPrefs.GetInt("STAGE1SCORE", -1);

        if (gameManager.stage1_P)//�X�e�[�W�P���p�[�t�F�N�g
        {
            Instantiate(Perfect, new Vector3(230f, 410f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - 3000)//��
        {
            Instantiate(Gold, new Vector3(230f, 410f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX - 3000 && MyScore >= Stage1_MAX - 8000)//��
        {
            Instantiate(Silver, new Vector3(230f, 410f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX - 8000 && MyScore >= 0)//��
        {
            Instantiate(Bronze, new Vector3(230f, 410f, 0f), Quaternion.identity, Parent);
        }

        //�X�e�[�W�Q
        //�}�C�X�R�A�ɃX�R�A���i�[
        MyScore = PlayerPrefs.GetInt("STAGE2SCORE", -1);

        if (gameManager.stage2_P)//�X�e�[�W�Q���p�[�t�F�N�g
        {
            Instantiate(Perfect, new Vector3(400f, 260f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX && MyScore >= Stage2_MAX - 3000)//��
        {
            Instantiate(Gold, new Vector3(400f, 260f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX - 3000 && MyScore >= Stage2_MAX - 8000)//��
        {
            Instantiate(Silver, new Vector3(400f, 260f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX - 8000 && MyScore >= 0)//��
        {
            Instantiate(Bronze, new Vector3(400f, 260f, 0f), Quaternion.identity, Parent);
        }

        //�X�e�[�W�R
        //�}�C�X�R�A�ɃX�R�A���i�[
        MyScore = PlayerPrefs.GetInt("STAGE3SCORE", -1);

        if (gameManager.stage3_P)//�X�e�[�W�R���p�[�t�F�N�g
        {
            Instantiate(Perfect, new Vector3(580f, 115f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX && MyScore >= Stage3_MAX - 3000)//��
        {
            Instantiate(Gold, new Vector3(580f, 115f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX - 3000 && MyScore >= Stage3_MAX - 8000)//��
        {
            Instantiate(Silver, new Vector3(580f, 115f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX - 8000 && MyScore >= 0)//��
        {
            Instantiate(Bronze, new Vector3(580f, 115f, 0f), Quaternion.identity, Parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
