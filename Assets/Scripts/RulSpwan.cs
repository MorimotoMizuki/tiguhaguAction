using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulSpwan : MonoBehaviour
{
    //表示するテキスト
    public GameObject Rule_Text;
    public GameObject Objective_Text;
    public GameObject Rule_Panel;

    //表示するテキスト位置
    public Transform OBJ_T;

    //親を指定
    public Transform Parent;

    static private bool once = false;

    // Start is called before the first frame update
    void Start()
    {
        //一回目のステージ１にいった時だけ呼び出す
        if(GameManager.stage_num == 1 && !once)
        {
            Rule();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームが始まったら消えてなくなる
        if(StartButtonSC.isStart)
        {
            //パネルを消す
            Rule_Text.SetActive(false);
            Objective_Text.SetActive(false);
        }
    }

    private void Rule()
    {
        //二つのテキストを表示
        Rule_Text.SetActive(true);
        Objective_Text.SetActive(true);
        Debug.Log("aaa");

        once = true;
    }
}
