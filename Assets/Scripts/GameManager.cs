using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int stage_num;
    public static bool stage1_P;
    public static bool stage2_P;
    public static bool stage3_P;

    // Start is called before the first frame update
    void Start()
    {
        stage_num = 0;
        stage1_P = false;
        stage2_P = false;
        stage3_P = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
