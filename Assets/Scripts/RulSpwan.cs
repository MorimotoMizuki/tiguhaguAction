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
            Destroy(Rule_Panel);
        }
    }

    private void Rule()
    {
        //二つのテキストを表示
        Instantiate(Rule_Text       , new Vector3(OBJ_T.transform.position.x - 285, OBJ_T.transform.position.y, OBJ_T.transform.position.z), Quaternion.identity, Parent);
        Instantiate(Objective_Text  , new Vector3(OBJ_T.transform.position.x + 285, OBJ_T.transform.position.y, OBJ_T.transform.position.z), Quaternion.identity, Parent);

        once = true;
    }
}
