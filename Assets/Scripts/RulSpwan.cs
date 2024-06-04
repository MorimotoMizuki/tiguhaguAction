using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulSpwan : MonoBehaviour
{
    //�\������e�L�X�g
    public GameObject Rule_Text;
    public GameObject Objective_Text;
    public GameObject Rule_Panel;

    //�\������e�L�X�g�ʒu
    public Transform OBJ_T;

    //�e���w��
    public Transform Parent;

    static private bool once = false;

    // Start is called before the first frame update
    void Start()
    {
        //���ڂ̃X�e�[�W�P�ɂ������������Ăяo��
        if(GameManager.stage_num == 1 && !once)
        {
            Rule();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[�����n�܂���������ĂȂ��Ȃ�
        if(StartButtonSC.isStart)
        {
            //�p�l��������
            Destroy(Rule_Panel);
        }
    }

    private void Rule()
    {
        //��̃e�L�X�g��\��
        Instantiate(Rule_Text       , new Vector3(OBJ_T.transform.position.x - 285, OBJ_T.transform.position.y, OBJ_T.transform.position.z), Quaternion.identity, Parent);
        Instantiate(Objective_Text  , new Vector3(OBJ_T.transform.position.x + 285, OBJ_T.transform.position.y, OBJ_T.transform.position.z), Quaternion.identity, Parent);

        once = true;
    }
}
