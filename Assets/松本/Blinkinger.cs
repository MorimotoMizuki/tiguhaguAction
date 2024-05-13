using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinkinger : MonoBehaviour
{
    // “_–Å‚³‚¹‚é‘ÎÛ
    [SerializeField] private Renderer _target;
    // “_–ÅŽüŠú[s]
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
            // “à•”Žž‚ðŒo‰ß‚³‚¹‚é
            _time += Time.deltaTime;

            // ŽüŠúcycle‚ÅŒJ‚è•Ô‚·’l‚ÌŽæ“¾
            // 0`cycle‚Ì”ÍˆÍ‚Ì’l‚ª“¾‚ç‚ê‚é
            var repeatValue = Mathf.Repeat((float)_time, _cycle);

            // “à•”Žžtime‚É‚¨‚¯‚é–¾–Åó‘Ô‚ð”½‰f
            _target.enabled = repeatValue >= _cycle * 0.2f;
            
        }
        if(_time>1f)
        {
            playerCollision.isBlink = false;
            _target.enabled = true;
        }
    }
}
