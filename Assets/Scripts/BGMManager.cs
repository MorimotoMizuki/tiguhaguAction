using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BGMManager : MonoBehaviour
{
    public StageSEManager semanager;

    AudioSource audioSource;
    public PlayerController playerController;
    bool isPlay = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.isClear&&!isPlay)
        {
            //audioSource.clip = audioClips[0];
            audioSource.Stop();
            isPlay = true;
        }
        if(playerController.isOver && !isPlay)
        {
            audioSource.Stop();
            isPlay = true;
            //ゲームオーバーのSEを再生
            semanager.OverSE(); 
        }

    }
}
