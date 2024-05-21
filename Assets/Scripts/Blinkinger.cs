using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinkinger : MonoBehaviour
{
    // �_�ł�����Ώ�
    [SerializeField] private Renderer[] _target;
    // �_�Ŏ���[s]
    [SerializeField] private float _cycle = 0.5f;

    public double _time;

    public PlayerController playerController;
    public PlayerCollision playerCollision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Blink();
    }

    public void Blink()
    {
        if(playerCollision.isBlink)
        {
            // �����������o�߂�����
            _time += Time.deltaTime;

            // ����cycle�ŌJ��Ԃ��l�̎擾
            // 0�`cycle�͈̔͂̒l��������
            var repeatValue = Mathf.Repeat((float)_time, _cycle);

            for(int i=0;i<_target.Length;i++)
            {
                // ��������time�ɂ����閾�ŏ�Ԃ𔽉f
                _target[i].enabled = repeatValue >= _cycle * 0.2f;
            }
            
            
        }
        if(_time>0.5f)
        {
            playerCollision.isBlink = false;
            for (int i = 0; i < _target.Length; i++)
            {
                // ��������time�ɂ����閾�ŏ�Ԃ𔽉f
                _target[i].enabled = true;
            }
        }
    }
}
