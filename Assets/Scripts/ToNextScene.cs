using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
    public int stagenum;
    public GameManager gameManager;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        Invoke("Late", 1.0f);
    }
    private void Late()
    {
        gameManager.stage_num = stagenum;
        SceneManager.LoadScene(sceneName);
        
    }
}
