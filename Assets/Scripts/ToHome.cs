using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHome : MonoBehaviour
{
    private Animator Rogo_animator;
    private Animator Tiguha_animator;
    public GameObject Rogo;
    public GameObject Tiguhakun;

    // Start is called before the first frame update
    void Start()
    {
        Rogo_animator = Rogo.GetComponent<Animator>();
        Tiguha_animator = Tiguhakun.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PushButton()
    {
        Invoke("LoadScene", 1.0f);

        Rogo_animator.Play("Rogo_Title");
        Tiguha_animator.Play("Title_dash_tiguhakun");

    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Homescene");
    }

}
