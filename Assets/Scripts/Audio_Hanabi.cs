using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio_Hanabi : MonoBehaviour
{

    AudioSource audioSource;
    public AudioMixerGroup _AudioMixer;
    public GameObject Model;
    public AudioClip audioclip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAt(Vector3 position)
    {
        //var mixer = UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Audio.AudioMixer>("Assets/森本/音楽/NewAudioMixer.mixer");
        //audioSource.outputAudioMixerGroup = mixer.FindMatchingGroups("花火音")[0];
        audioSource.outputAudioMixerGroup = _AudioMixer;

        if (audioSource.clip != null)
        {
            //AudioSource.PlayClipAtPoint(audioSource.clip, position);

            PlayAt3D();
        }
    }

    private void PlayAt3D()
    {
        // 「GameObject名 ＆ "-Audio"」 という名前のゲームオブジェクトを作成
        GameObject Model_tmp = new GameObject(Model.name + "-Audio");

        //GameObjectにAudioSourceをアタッチ
        AudioSource audio_tmp = new AudioSource();
        audio_tmp = Model_tmp.AddComponent<AudioSource>();

        //オーディオソースの設定
        audio_tmp.clip = audioclip;
        audio_tmp.transform.position = Model.transform.position;
        audio_tmp.spatialBlend = 1;//3D音響にするプロパティ(1だと3D、0だと2D)
        audio_tmp.loop = false;//ループオフ
        audio_tmp.outputAudioMixerGroup = _AudioMixer;

        //再生
        audio_tmp.Play();
        //クリップ長+0.1秒でオブジェクトを破棄
        Destroy(Model_tmp, audioclip.length + 0.1f);
    }
}

