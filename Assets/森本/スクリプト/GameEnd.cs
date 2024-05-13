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

    //ゲーム終了
    private void EndGame()
    {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
        Application.Quit();//ゲームプレイ終了
#endif

    }
}
