using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Score_Generate : MonoBehaviour
{
    //各ステージがパーフェクトであるかを判定する変数を呼び出すための宣言
    //public GameManager gameManager;

    //メダルのプレハブオブジェクトを入れるための変数
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //親を指定
    public Transform Parent;

    //メダルの位置調整用
    public Transform Button1;
    public Transform Button2;
    public Transform Button3;

    //呼び出したスコアを格納する変数
    private int MyScore;

    //各ステージのMAXScore設定
    private int Stage1_MAX = 11500;
    private int Stage2_MAX = 20000;
    private int Stage3_MAX = 30000;

    //引く点数用
    private int minus_G = 3000;
    private int minus_S = 8000;

    // Start is called before the first frame update
    void Start()
    {
        //ステージ１
        //マイスコアにスコアを格納
        MyScore = PlayerPrefs.GetInt("STAGE1SCORE", -1);

        if (GameManager.stage1_P)//ステージ１がパーフェクト
        {
            Instantiate(Perfect, new Vector3(Button1.transform.position.x + 35.0f, Button1.transform.position.y + 2.0f, Button1.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - minus_G)//金
        {
            Instantiate(Gold, new Vector3(Button1.transform.position.x + 35.0f, Button1.transform.position.y + 2.0f, Button1.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX - minus_G && MyScore >= Stage1_MAX - minus_S)//銀
        {
            Instantiate(Silver, new Vector3(Button1.transform.position.x + 35.0f, Button1.transform.position.y + 2.0f, Button1.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage1_MAX - minus_S && MyScore >= 0)//銅
        {
            Instantiate(Bronze, new Vector3(Button1.transform.position.x + 35.0f, Button1.transform.position.y + 2.0f, Button1.transform.position.z), Quaternion.identity, Parent);
        }

        //ステージ２
        //マイスコアにスコアを格納
        MyScore = PlayerPrefs.GetInt("STAGE2SCORE", -1);

        if (GameManager.stage2_P)//ステージ２がパーフェクト
        {
            Instantiate(Perfect, new Vector3(Button2.transform.position.x + 35.0f, Button2.transform.position.y + 2.0f, Button2.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX && MyScore >= Stage2_MAX - minus_G)//金
        {
            Instantiate(Gold, new Vector3(Button2.transform.position.x + 35.0f, Button2.transform.position.y + 2.0f, Button2.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX - minus_G && MyScore >= Stage2_MAX - minus_S)//銀
        {
            Instantiate(Silver, new Vector3(Button2.transform.position.x + 35.0f, Button2.transform.position.y + 2.0f, Button2.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage2_MAX - minus_S && MyScore >= 0)//銅
        {
            Instantiate(Bronze, new Vector3(Button2.transform.position.x + 35.0f, Button2.transform.position.y + 2.0f, Button2.transform.position.z), Quaternion.identity, Parent);
        }

        //ステージ３
        //マイスコアにスコアを格納
        MyScore = PlayerPrefs.GetInt("STAGE3SCORE", -1);

        if (GameManager.stage3_P)//ステージ３がパーフェクト
        {
            Instantiate(Perfect, new Vector3(Button3.transform.position.x + 35.0f, Button3.transform.position.y + 2.0f, Button3.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX && MyScore >= Stage3_MAX - minus_G)//金
        {
            Instantiate(Gold, new Vector3(Button3.transform.position.x + 35.0f, Button3.transform.position.y + 2.0f, Button3.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX - minus_G && MyScore >= Stage3_MAX - minus_S)//銀
        {
            Instantiate(Silver, new Vector3(Button3.transform.position.x + 35.0f, Button3.transform.position.y + 2.0f, Button3.transform.position.z), Quaternion.identity, Parent);
        }
        else if (MyScore <= Stage3_MAX - minus_S && MyScore >= 0)//銅
        {
            Instantiate(Bronze, new Vector3(Button3.transform.position.x + 35.0f, Button3.transform.position.y + 2.0f, Button3.transform.position.z), Quaternion.identity, Parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
