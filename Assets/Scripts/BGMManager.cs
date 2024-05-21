using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BGMManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] audioClips;
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
        
    }
}
