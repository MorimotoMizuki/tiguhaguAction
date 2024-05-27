using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonSC : MonoBehaviour
{
    public PlayerController playerController;
    public static bool isStart=false;
    // Start is called before the first frame update
    void Start()
    {
        isStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        isStart = true;
        Destroy(this.gameObject);
    }
}
