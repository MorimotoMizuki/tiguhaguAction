using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int stage_num;//現在のステージ確認用変数
    public static bool stage1_P;
    public static bool stage2_P;
    public static bool stage3_P;

    public static bool stage1_clear;
    public static bool stage2_clear;
    public static bool stage3_clear;

    public GameObject allclearButtom;
    GameObject parentcanvas;
    bool isOnce = false;//一回だけ行うための

    // Start is called before the first frame update
    void Start()
    {
        stage_num = 0;
        stage1_P = false;
        stage2_P = false;
        stage3_P = false;

        stage1_clear = false;
        stage2_clear = false;
        stage3_clear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(stage1_clear&& stage2_clear&& stage3_clear&&!isOnce)
        {
            //parentcanvas = GameObject.Find("Canvas");
            //Instantiate(allclearButtom, new Vector3(0, -100, 0), Quaternion.identity, parentcanvas.transform);
            isOnce = true;
            Invoke("Next", 4.0f);
        }
    }

    void Next()
    {
        SceneManager.LoadScene("AllClearScene");
    }
}
