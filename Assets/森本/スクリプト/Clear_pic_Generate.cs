using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear_pic_Generate : MonoBehaviour
{
    //各ステージがパーフェクトであるかを判定する変数を呼び出すための宣言
    public GameManager gameManager;
    public PlayerController playerController;

    //メダルのプレハブオブジェクトを入れるための変数
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //ゲーミング誉め言葉のプレハブオブジェクトを入れるための変数
    public GameObject Congratulations;
    public GameObject Excellent;
    public GameObject Great;
    public GameObject Good;

    //親を指定
    public Transform Parent;

    //呼び出したスコアを格納する変数
    private int MyScore;

    //各ステージのMAXScore設定
    private int Stage1_MAX = 5500;
    private int Stage2_MAX = 10000;
    private int Stage3_MAX = 10000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ゲームクリアしたら
        if(playerController.isClear == true)
        {
            Debug.Log(gameManager.stage_num);
            //ステージ１
            //マイスコアにスコアを格納
            if (gameManager.stage_num == 1)//ステージ１だったら
            {
                MyScore = PlayerPrefs.GetInt("STAGE1SCORE", -1);

                if (gameManager.stage1_P)//ステージ１がパーフェクト
                {
                    Instantiate(Perfect, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);//メダル
                    Instantiate(Congratulations, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                    Debug.Log("Stage1");
                }
                else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - 3000)//金
                {
                    Instantiate(Gold, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                    Debug.Log("Stage1");
                }
                else if (MyScore <= Stage1_MAX - 3000 && MyScore >= Stage1_MAX - 8000)//銀
                {
                    Instantiate(Silver, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                    Debug.Log("Stage1");
                }
                else if (MyScore <= Stage1_MAX - 8000 && MyScore >= 0)//銅
                {
                    Instantiate(Bronze, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                    Debug.Log("Stage1");
                }
            }
            //ステージ２
            //マイスコアにスコアを格納
            else if (gameManager.stage_num == 2)//ステージ２だったら
            {
                MyScore = PlayerPrefs.GetInt("STAGE2SCORE", -1);

                if (gameManager.stage2_P)//ステージ２がパーフェクト
                {
                    Instantiate(Perfect, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Congratulations, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                }
                else if (MyScore <= Stage2_MAX && MyScore >= Stage2_MAX - 3000)//金
                {
                    Instantiate(Gold, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                }
                else if (MyScore <= Stage2_MAX - 3000 && MyScore >= Stage2_MAX - 8000)//銀
                {
                    Instantiate(Silver, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                }
                else if (MyScore <= Stage2_MAX - 8000 && MyScore >= 0)//銅
                {
                    Instantiate(Bronze, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                }
            }
            //ステージ３
            //マイスコアにスコアを格納
            else if (gameManager.stage_num == 3)//ステージ３だったら
            {
                MyScore = PlayerPrefs.GetInt("STAGE3SCORE", -1);

                if (gameManager.stage3_P)//ステージ３がパーフェクト
                {
                    Instantiate(Perfect, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Congratulations, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                }
                else if (MyScore <= Stage3_MAX && MyScore >= Stage3_MAX - 3000)//金
                {
                    Instantiate(Gold, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                }
                else if (MyScore <= Stage3_MAX - 3000 && MyScore >= Stage3_MAX - 8000)//銀
                {
                    Instantiate(Silver, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                }
                else if (MyScore <= Stage3_MAX - 8000 && MyScore >= 0)//銅
                {
                    Instantiate(Bronze, new Vector3(470f, 160f, 0f), Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(470f, 400f, 0f), Quaternion.identity, Parent);//ゲーミング誉め言葉
                }
            }
        }
    }
}