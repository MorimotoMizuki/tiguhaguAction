using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    void Start()
    {
    }

    public void PushButton()
    {
        Invoke("EndGame", 1.0f);
    }

    //�Q�[���I��
    private void EndGame()
    {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
        Application.Quit();//�Q�[���v���C�I��
#endif

    }
}
