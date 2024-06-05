using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeButtonManager : MonoBehaviour
{
    public Button Button1;
    public Button Button3;
    public Button Button2;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.stage1_clear)
            Button2.interactable = true;
        if(GameManager.stage2_clear)
            Button3.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
