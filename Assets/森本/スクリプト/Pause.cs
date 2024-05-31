using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //ポーズ中に出力する画面
    public GameObject PauseWindow;

    //ポーズかどうか判定するフラグ
    public bool Pauseflag = false;

    //一回だけ押したか判定するフラグ
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
            once = true;//一回目
            Pauseflag = true;//ポーズ中
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && Pauseflag && once)
        {
            ResumeGame();
            once = false;//二回目
            Pauseflag = false;//ポーズ解除中
        }
    }
    public void PauseGame()//ポーズ中
    {
        Debug.Log("ポーズ");
        Time.timeScale = 0;
        PauseWindow.SetActive(true);
    }

    public void ResumeGame()//再開　レジュメ
    {
        Debug.Log("ポーズ解除");
        Time.timeScale = 1;
        PauseWindow.SetActive(false);
    }
}
