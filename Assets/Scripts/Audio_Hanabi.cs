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
        //var mixer = UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Audio.AudioMixer>("Assets/�X�{/���y/NewAudioMixer.mixer");
        //audioSource.outputAudioMixerGroup = mixer.FindMatchingGroups("�ԉΉ�")[0];
        audioSource.outputAudioMixerGroup = _AudioMixer;

        if (audioSource.clip != null)
        {
            //AudioSource.PlayClipAtPoint(audioSource.clip, position);

            PlayAt3D();
        }
    }

    private void PlayAt3D()
    {
        // �uGameObject�� �� "-Audio"�v �Ƃ������O�̃Q�[���I�u�W�F�N�g���쐬
        GameObject Model_tmp = new GameObject(Model.name + "-Audio");

        //GameObject��AudioSource���A�^�b�`
        AudioSource audio_tmp = new AudioSource();
        audio_tmp = Model_tmp.AddComponent<AudioSource>();

        //�I�[�f�B�I�\�[�X�̐ݒ�
        audio_tmp.clip = audioclip;
        audio_tmp.transform.position = Model.transform.position;
        audio_tmp.spatialBlend = 1;//3D�����ɂ���v���p�e�B(1����3D�A0����2D)
        audio_tmp.loop = false;//���[�v�I�t
        audio_tmp.outputAudioMixerGroup = _AudioMixer;

        //�Đ�
        audio_tmp.Play();
        //�N���b�v��+0.1�b�ŃI�u�W�F�N�g��j��
        Destroy(Model_tmp, audioclip.length + 0.1f);
    }
}

