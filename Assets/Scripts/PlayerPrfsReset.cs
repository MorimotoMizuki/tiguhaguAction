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
        PlayerPrefs.SetInt("STAGE1SCORE", -1);
        PlayerPrefs.SetInt("STAGE2SCORE", -1);
        PlayerPrefs.SetInt("STAGE3SCORE", -1);

        GameObject[] objects = GameObject.FindGameObjectsWithTag("HomeCoin");
        foreach (GameObject ball in objects)
        {
            Destroy(ball);
        }
        
    }
}
