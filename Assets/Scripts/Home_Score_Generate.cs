using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Score_Generate : MonoBehaviour
{
    //各ステージがパーフェクトであるかを判定する変数を呼び出すための宣言
    public GameManager gameManager;

    //メダルのプレハブオブジェクトを入れるための変数
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //親を指定
    public Transform Parent;

    //呼び出したスコアを格納する変数
    private int MyScore;

    //各ステージのMAXScore設定
    private int Stage1_MAX = 11500;
    private int Stage2_MAX = 10000;
    private int Stage3_MAX = 10000;

    // Start is called before the first frame update
    void Start()
    {
        //ステージ１
        //マイスコアにスコアを格納
        MyScore = PlayerPrefs.GetInt("STAGE1SCORE", -1);

        if (gameManager.stage1_P)//ステージ１がパーフェクト
        {
            Instantiate(Perfect, new Vector3(255f, 426f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - 3000)//金
        {
            Instantiate(Gold, new Vector3(230f, 410f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX - 3000 && MyScore >= Stage1_MAX - 8000)//銀
        {
            Instantiate(Silver, new Vector3(230f, 410f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX - 8000 && MyScore >= 0)//銅
        {
            Instantiate(Bronze, new Vector3(230f, 410f, 0f), Quaternion.identity, Parent);
        }

        //ステージ２
        //マイスコアにスコアを格納
        MyScore = PlayerPrefs.GetInt("STAGE2SCORE", -1);

        if (gameManager.stage2_P)//ステージ２がパーフェクト
        {
            Instantiate(Perfect, new Vector3(420f, 286f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX && MyScore >= Stage2_MAX - 3000)//金
        {
            Instantiate(Gold, new Vector3(400f, 265f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX - 3000 && MyScore >= Stage2_MAX - 8000)//銀
        {
            Instantiate(Silver, new Vector3(400f, 265f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX - 8000 && MyScore >= 0)//銅
        {
            Instantiate(Bronze, new Vector3(400f, 265f, 0f), Quaternion.identity, Parent);
        }

        //ステージ３
        //マイスコアにスコアを格納
        MyScore = PlayerPrefs.GetInt("STAGE3SCORE", -1);

        if (gameManager.stage3_P)//ステージ３がパーフェクト
        {
            Instantiate(Perfect, new Vector3(595f, 137f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX && MyScore >= Stage3_MAX - 3000)//金
        {
            Instantiate(Gold, new Vector3(580f, 116f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX - 3000 && MyScore >= Stage3_MAX - 8000)//銀
        {
            Instantiate(Silver, new Vector3(580f, 116f, 0f), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX - 8000 && MyScore >= 0)//銅
        {
            Instantiate(Bronze, new Vector3(580f, 116f, 0f), Quaternion.identity, Parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
