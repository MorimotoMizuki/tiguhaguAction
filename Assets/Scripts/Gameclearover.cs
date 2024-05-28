using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclearover : MonoBehaviour
{
    public GameObject GameClearobj;
    public GameObject Gameoverobj;

    public AudioSource BGM;
    public AudioSource GameOverBGM;

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
            BGM.volume = 0;
            GameOverBGM.Play();
            Debug.Log(GameOverBGM.volume);
            Gameoverobj.SetActive(true);
            playerController.isOver = true;
        }
    }
}
