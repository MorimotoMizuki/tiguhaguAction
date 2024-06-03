using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
    public int stagenum;
    //public GameManager gameManager;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LoadScene(int stagenum)
    {
        GameManager.stage_num = stagenum;
        Invoke("Late", 1.0f);
    }
    private void Late()
    {    
        SceneManager.LoadScene(sceneName);
    }
    public void Stage_LoadScene(int stagenum)//’x‰„‚È‚µ‚ÅƒV[ƒ“ˆÚ“®
    {
        GameManager.stage_num = stagenum;
        Time.timeScale = 1;
        Late();
    }
}
