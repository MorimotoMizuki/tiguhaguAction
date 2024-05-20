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
            // Sceneを遷移してもオブジェクトが消えないようにする
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
