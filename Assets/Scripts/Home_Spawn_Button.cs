using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Spawn_Button : MonoBehaviour
{
    //�e�X�e�[�W���N���A���������肷��t���O
    private bool Stageclear_1 = false;
    private bool Stageclear_2 = false;
    //private bool Stageclear_3 = false;

    public GameObject Button_1;
    public GameObject Button_2;
    public GameObject Button_3;

    // Start is called before the first frame update
    void Start()
    {
        if (Stageclear_1)//�X�e�[�W1���N���A
        {
            Button_2.SetActive(true);//�X�e�[�W2�̃{�^����\��
        }
        else
        {
            Button_2.SetActive(false);//�X�e�[�W2�̃{�^�����\��
        }
        if (Stageclear_2)//�X�e�[�W2���N���A
        {
            Button_3.SetActive(true);//�X�e�[�W3�̃{�^����\��
        }
        else
        {
            Button_3.SetActive(false);//�X�e�[�W3�̃{�^�����\��
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
