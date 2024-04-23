using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclearover : MonoBehaviour
{
    public GameObject GameClearobj;
    public GameObject Gameoverobj;

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        GameClearobj.SetActive(false);
        Gameoverobj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.playerHP==0)
        {
            Gameoverobj.SetActive(true);
        }
    }
}
