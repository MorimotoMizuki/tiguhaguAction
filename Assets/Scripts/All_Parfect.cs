using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_Parfect : MonoBehaviour
{
    public SkinnedMeshRenderer[] tiguhakun;
    public Material Nizimatbody;
    public Material Nizimathead;

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.stage1_P&&GameManager.stage2_P&&GameManager.stage3_P)
        {
            tiguhakun[0].material = Nizimatbody;
            tiguhakun[1].material = Nizimathead;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
