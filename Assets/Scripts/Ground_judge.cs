using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_judge : MonoBehaviour
{
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Ground")
        {
            playerController.isGround = true;
        }
    }
}
