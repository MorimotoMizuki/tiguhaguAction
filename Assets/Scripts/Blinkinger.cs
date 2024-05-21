using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinkinger : MonoBehaviour
{
    // “_–Å‚³‚¹‚é‘ÎÛ
    [SerializeField] private Renderer[] _target;
    // “_–ÅüŠú[s]
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
            // “à•”‚ğŒo‰ß‚³‚¹‚é
            _time += Time.deltaTime;

            // üŠúcycle‚ÅŒJ‚è•Ô‚·’l‚Ìæ“¾
            // 0`cycle‚Ì”ÍˆÍ‚Ì’l‚ª“¾‚ç‚ê‚é
            var repeatValue = Mathf.Repeat((float)_time, _cycle);

            for(int i=0;i<_target.Length;i++)
            {
                // “à•”time‚É‚¨‚¯‚é–¾–Åó‘Ô‚ğ”½‰f
                _target[i].enabled = repeatValue >= _cycle * 0.2f;
            }
            
            
        }
        if(_time>0.5f)
        {
            playerCollision.isBlink = false;
            for (int i = 0; i < _target.Length; i++)
            {
                // “à•”time‚É‚¨‚¯‚é–¾–Åó‘Ô‚ğ”½‰f
                _target[i].enabled = true;
            }
        }
    }
}
