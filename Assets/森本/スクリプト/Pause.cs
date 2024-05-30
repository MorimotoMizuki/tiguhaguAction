using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //�|�[�Y���ɏo�͂�����
    public GameObject PauseWindow;

    //�|�[�Y���ǂ������肷��t���O
    public bool Pauseflag = false;

    //��񂾂������������肷��t���O
    private bool once = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !Pauseflag && !once)
        {
            PauseGame();
            once = true;//����
            Pauseflag = true;//�|�[�Y��
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && Pauseflag && once)
        {
            ResumeGame();
            once = false;//����
            Pauseflag = false;//�|�[�Y������
        }
    }
    public void PauseGame()//�|�[�Y��
    {
        Debug.Log("�|�[�Y");
        Time.timeScale = 0;
        PauseWindow.SetActive(true);
    }

    public void ResumeGame()//�ĊJ�@���W����
    {
        Debug.Log("�|�[�Y����");
        Time.timeScale = 1;
        PauseWindow.SetActive(false);
    }
}
