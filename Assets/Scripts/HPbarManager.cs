using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbarManager : MonoBehaviour
{
    int maxHP;
    public Slider slider;

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        maxHP = playerController.playerHP;
        slider.value = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HPdamage()
    {
        slider.value = (float)playerController.playerHP / (float)maxHP;
    }
}
