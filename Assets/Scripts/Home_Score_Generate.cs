using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Score_Generate : MonoBehaviour
{
    //�e�X�e�[�W���p�[�t�F�N�g�ł��邩�𔻒肷��ϐ����Ăяo�����߂̐錾
    //public GameManager gameManager;

    //���_���̃v���n�u�I�u�W�F�N�g�����邽�߂̕ϐ�
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //�e���w��
    public Transform Parent;

    //���_���̈ʒu�����p
    public Transform Button1;
    public Transform Button2;
    public Transform Button3;

    //�Ăяo�����X�R�A���i�[����ϐ�
    private int MyScore;

    //�e�X�e�[�W��MAXScore�ݒ�
    private int Stage1_MAX = 11500;
    private int Stage2_MAX = 20000;
    private int Stage3_MAX = 30000;

    //�����_���p
    private int minus_G = 3000;
    private int minus_S = 8000;

    // Start is called before the first frame update
    void Start()
    {
        //�X�e�[�W�P
        //�}�C�X�R�A�ɃX�R�A���i�[
        MyScore = PlayerPrefs.GetInt("STAGE1SCORE", -1);

        if (GameManager.stage1_P)//�X�e�[�W�P���p�[�t�F�N�g
        {
            Instantiate(Perfect, new Vector3(Button1.transform.position.x + 35.0f, Button1.transform.position.y + 2.0f, Button1.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - minus_G)//��
        {
            Instantiate(Gold, new Vector3(Button1.transform.position.x + 35.0f, Button1.transform.position.y + 2.0f, Button1.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX - minus_G && MyScore >= Stage1_MAX - minus_S)//��
        {
            Instantiate(Silver, new Vector3(Button1.transform.position.x + 35.0f, Button1.transform.position.y + 2.0f, Button1.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX - minus_S && MyScore >= 0)//��
        {
            Instantiate(Bronze, new Vector3(Button1.transform.position.x + 35.0f, Button1.transform.position.y + 2.0f, Button1.transform.position.z), Quaternion.identity, Parent);
        }

        //�X�e�[�W�Q
        //�}�C�X�R�A�ɃX�R�A���i�[
        MyScore = PlayerPrefs.GetInt("STAGE2SCORE", -1);

        if (GameManager.stage2_P)//�X�e�[�W�Q���p�[�t�F�N�g
        {
            Instantiate(Perfect, new Vector3(Button2.transform.position.x + 35.0f, Button2.transform.position.y + 2.0f, Button2.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX && MyScore >= Stage2_MAX - minus_G)//��
        {
            Instantiate(Gold, new Vector3(Button2.transform.position.x + 35.0f, Button2.transform.position.y + 2.0f, Button2.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX - minus_G && MyScore >= Stage2_MAX - minus_S)//��
        {
            Instantiate(Silver, new Vector3(Button2.transform.position.x + 35.0f, Button2.transform.position.y + 2.0f, Button2.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX - minus_S && MyScore >= 0)//��
        {
            Instantiate(Bronze, new Vector3(Button2.transform.position.x + 35.0f, Button2.transform.position.y + 2.0f, Button2.transform.position.z), Quaternion.identity, Parent);
        }

        //�X�e�[�W�R
        //�}�C�X�R�A�ɃX�R�A���i�[
        MyScore = PlayerPrefs.GetInt("STAGE3SCORE", -1);

        if (GameManager.stage3_P)//�X�e�[�W�R���p�[�t�F�N�g
        {
            Instantiate(Perfect, new Vector3(Button3.transform.position.x + 35.0f, Button3.transform.position.y + 2.0f, Button3.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX && MyScore >= Stage3_MAX - minus_G)//��
        {
            Instantiate(Gold, new Vector3(Button3.transform.position.x + 35.0f, Button3.transform.position.y + 2.0f, Button3.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX - minus_G && MyScore >= Stage3_MAX - minus_S)//��
        {
            Instantiate(Silver, new Vector3(Button3.transform.position.x + 35.0f, Button3.transform.position.y + 2.0f, Button3.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX - minus_S && MyScore >= 0)//��
        {
            Instantiate(Bronze, new Vector3(Button3.transform.position.x + 35.0f, Button3.transform.position.y + 2.0f, Button3.transform.position.z), Quaternion.identity, Parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
