using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class SE : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    public AudioSource se;

    // Use this for initialization
    void Start()
    {
        if (DontDestroyEnabled)
        {
            // Scene��J�ڂ��Ă��I�u�W�F�N�g�������Ȃ��悤�ɂ���
            DontDestroyOnLoad(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SEPlay()
    {
        se.Play();
    }
}
