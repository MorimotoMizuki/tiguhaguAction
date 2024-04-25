using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float ZPower=0.1f;//‘OŒã•ûŒü‚ÉˆÚ“®‚·‚é‚½‚ß‚Ì—Í‚ð“ü‚ê‚é•Ï”
    public float XPower=0.1f;//‰¡•ûŒü‚ÉˆÚ“®‚·‚é‚½‚ß‚Ì—Í‚ð“ü‚ê‚é•Ï”

    public float RightLimit = 4.0f;//‰E•ûŒüŒÀŠE
    public float LeftLimit = -4.0f;//¶•ûŒüŒÀŠE

    public float ForwordLimit = 0.0f;//‘O•ûŒüŒÀŠE
    public float BackwordLimit = 0.0f;//Žè‘O•ûŒüŒÀŠE

    int direc = 1;//Œü‚«•ÏX—p•Ï”


    public bool isX_Axis=false;//XŽ²•ûŒü‚ÉˆÚ“®‚³‚¹‚½‚¢‚©‚Ç‚¤‚©
    public bool isZ_Axis=false;//ZŽ²•ûŒü‚ÉˆÚ“®‚³‚¹‚½‚¢‚©‚Ç‚¤‚©
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isX_Axis)
            X_Axis_Move();


    }

    void X_Axis_Move()
    {
        if (transform.position.x > RightLimit)
        {
            direc = -1;
        }
        if (transform.position.x < LeftLimit)
        {
            direc = 1;
        }

        transform.position += transform.right * XPower * direc;
    }

    public void Z_Axis_Move() 
    {
    
    }

}
