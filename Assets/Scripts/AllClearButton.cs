using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllClearButton : MonoBehaviour
{
    public GameObject TitleButton;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnButton", 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnButton()
    {
        TitleButton.SetActive(true);
    }
}
