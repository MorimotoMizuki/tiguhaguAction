using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Score_Generate : MonoBehaviour
{
    //メダルのオブジェクト変数
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //スコアを呼び出す
    ScoreManager scoreManager;
    private int MyScore; //呼び出した変数を格納する変数

    //各ステージのMAXScoreを格納する変数
    private int Stage1_MAX = 11500;
    private int Stage2_MAX = 10000;
    private int Stage3_MAX = 10000;

    //各ステージがパーフェクトでクリアしたか判定するフラグ
    private bool Stage1_Perfect_flag = false;
    private bool Stage2_Perfect_flag = false;
    private bool Stage3_Perfect_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        MyScore = scoreManager.score_num;//呼び出したscore_numを格納

        //ステージ１がパーフェクト
        if (Stage1_Perfect_flag)
        {
            Instantiate(Perfect, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - 3000)//金
        {
            Instantiate(Gold, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if(MyScore <= Stage1_MAX - 3000 && MyScore >= Stage1_MAX - 8000)//銀
        {
            Instantiate(Silver, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if(MyScore <= Stage1_MAX - 8000 && MyScore >= 0)//銅
        {
            Instantiate(Bronze, new Vector3(0, 0, 0), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
