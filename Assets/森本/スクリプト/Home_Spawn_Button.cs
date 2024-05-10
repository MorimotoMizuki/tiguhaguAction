using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Spawn_Button : MonoBehaviour
{
    //各ステージをクリアしたか判定するフラグ
    private bool Stageclear_1 = false;
    private bool Stageclear_2 = false;
    //private bool Stageclear_3 = false;

    public GameObject Button_1;
    public GameObject Button_2;
    public GameObject Button_3;

    // Start is called before the first frame update
    void Start()
    {
        if (Stageclear_1)//ステージ1をクリア
        {
            Button_2.SetActive(true);//ステージ2のボタンを表示
        }
        else
        {
            Button_2.SetActive(false);//ステージ2のボタンを非表示
        }
        if (Stageclear_2)//ステージ2をクリア
        {
            Button_3.SetActive(true);//ステージ3のボタンを表示
        }
        else
        {
            Button_3.SetActive(false);//ステージ3のボタンを非表示
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
