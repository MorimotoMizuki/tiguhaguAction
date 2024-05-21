using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinkinger : MonoBehaviour
{
    // 点滅させる対象
    [SerializeField] private Renderer[] _target;
    // 点滅周期[s]
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
            // 内部時刻を経過させる
            _time += Time.deltaTime;

            // 周期cycleで繰り返す値の取得
            // 0〜cycleの範囲の値が得られる
            var repeatValue = Mathf.Repeat((float)_time, _cycle);

            for(int i=0;i<_target.Length;i++)
            {
                // 内部時刻timeにおける明滅状態を反映
                _target[i].enabled = repeatValue >= _cycle * 0.2f;
            }
            
            
        }
        if(_time>0.5f)
        {
            playerCollision.isBlink = false;
            for (int i = 0; i < _target.Length; i++)
            {
                // 内部時刻timeにおける明滅状態を反映
                _target[i].enabled = true;
            }
        }
    }
}
