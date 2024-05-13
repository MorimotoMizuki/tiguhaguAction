using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject score_obj;
    public int score_num=0;
    // Start is called before the first frame update
    void Start()
    {
        score_num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_obj.GetComponent<Text>();

        score_text.text = "スコア："+score_num;

        //score_num++;
    }
}
