using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class StageSEManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CoinSE()
    {
        //audioSource.clip = audioClip[0];
        audioSource.PlayOneShot(audioClip[0]);
    }
    public void DamageSE()
    {
        audioSource.PlayOneShot(audioClip[1]);
    }
    public void ClearSE()
    {
        audioSource.PlayOneShot(audioClip[2]);
    }
    public void HeelSE()
    {
        audioSource.PlayOneShot(audioClip[3]);
    }
}
