using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrfsReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick()
    {
        PlayerPrefs.SetInt("STAGE1SCORE",-1);
        PlayerPrefs.SetInt("STAGE2SCORE",-1);
        PlayerPrefs.SetInt("STAGE3SCORE",-1);

        GameObject[] objects = GameObject.FindGameObjectsWithTag("HomeCoin");
        foreach (GameObject ball in objects)
        {
            Destroy(ball);
        }

        //GameManager.stage1_clear = true;
        //GameManager.stage2_clear = true;
        //GameManager.stage3_clear = true;
        //GameManager.stage1_P = true;
        //GameManager.stage2_P = true;
        //GameManager.stage3_P = true;
    }
}
