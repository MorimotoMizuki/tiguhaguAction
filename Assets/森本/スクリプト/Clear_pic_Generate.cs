using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear_pic_Generate : MonoBehaviour
{
    //�e�X�e�[�W���p�[�t�F�N�g�ł��邩�𔻒肷��ϐ����Ăяo�����߂̐錾
    public GameManager gameManager;
    public PlayerController playerController;

    //���_���̃v���n�u�I�u�W�F�N�g�����邽�߂̕ϐ�
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //�Q�[�~���O�_�ߌ��t�̃v���n�u�I�u�W�F�N�g�����邽�߂̕ϐ�
    public GameObject Congratulations;
    public GameObject Excellent;
    public GameObject Great;
    public GameObject Good;

    //�e���w��
    public Transform Parent;

    //�Ăяo�����X�R�A���i�[����ϐ�
    private int MyScore;

    //�e�X�e�[�W��MAXScore�ݒ�
    private int Stage1_MAX = 5500;
    private int Stage2_MAX = 10000;
    private int Stage3_MAX = 10000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[���N���A������
        if(playerController.isClear == true)
        {
            Debug.Log(gameManager.stage_num);
            //�X�e�[�W�P
            //�}�C�X�R�A�ɃX�R�A���i�[
            if (gameManager.stage_num == 1)//�X�e�[�W�P��������
            {
                MyScore = PlayerPrefs.GetInt("STAGE1SCORE", -1);

                if (gameManager.stage1_P)//�X�e�[�W�P���p�[�t�F�N�g
                {
                    Instantiate(Perfect, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);//���_��
                    Instantiate(Congratulations, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                    Debug.Log("Stage1");
                }
                else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - 3000)//��
                {
                    Instantiate(Gold, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                    Debug.Log("Stage1");
                }
                else if (MyScore <= Stage1_MAX - 3000 && MyScore >= Stage1_MAX - 8000)//��
                {
                    Instantiate(Silver, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                    Debug.Log("Stage1");
                }
                else if (MyScore <= Stage1_MAX - 8000 && MyScore >= 0)//��
                {
                    Instantiate(Bronze, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                    Debug.Log("Stage1");
                }
            }
            //�X�e�[�W�Q
            //�}�C�X�R�A�ɃX�R�A���i�[
            else if (gameManager.stage_num == 2)//�X�e�[�W�Q��������
            {
                MyScore = PlayerPrefs.GetInt("STAGE2SCORE", -1);

                if (gameManager.stage2_P)//�X�e�[�W�Q���p�[�t�F�N�g
                {
                    Instantiate(Perfect, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Congratulations, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                }
                else if (MyScore <= Stage2_MAX && MyScore >= Stage2_MAX - 3000)//��
                {
                    Instantiate(Gold, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                }
                else if (MyScore <= Stage2_MAX - 3000 && MyScore >= Stage2_MAX - 8000)//��
                {
                    Instantiate(Silver, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                }
                else if (MyScore <= Stage2_MAX - 8000 && MyScore >= 0)//��
                {
                    Instantiate(Bronze, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                }
            }
            //�X�e�[�W�R
            //�}�C�X�R�A�ɃX�R�A���i�[
            else if (gameManager.stage_num == 3)//�X�e�[�W�R��������
            {
                MyScore = PlayerPrefs.GetInt("STAGE3SCORE", -1);

                if (gameManager.stage3_P)//�X�e�[�W�R���p�[�t�F�N�g
                {
                    Instantiate(Perfect, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Congratulations, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                }
                else if (MyScore <= Stage3_MAX && MyScore >= Stage3_MAX - 3000)//��
                {
                    Instantiate(Gold, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                }
                else if (MyScore <= Stage3_MAX - 3000 && MyScore >= Stage3_MAX - 8000)//��
                {
                    Instantiate(Silver, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                }
                else if (MyScore <= Stage3_MAX - 8000 && MyScore >= 0)//��
                {
                    Instantiate(Bronze, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t
                }
            }
        }
    }
}