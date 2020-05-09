using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanel : MonoBehaviour
{
    private Animator animator;
    private Animator animator2;
    public GameObject panel;
    public GameObject panel2;
    public bool check;
    public bool check2;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public static int sideArrow;

    // Start is called before the first frame update
    void Start()
    {
        animator = panel.GetComponent<Animator>();
        animator2 = panel2.GetComponent<Animator>();
    }

    public void UpPanel()
    {
        if(!check2)
        {
            animator2.Play("DownObservation");
            check2 = true;
            button3.SetActive(false);
            button4.SetActive(true);
        }else if(check2)
        {
            animator2.Play("UpObservation");
            check2 = false;
            button3.SetActive(true);
            button4.SetActive(false);
        }
    }

    public void SidePanel()
    {
        sideArrow = 1;
        if(!check)
        {
            animator.Play("MoveIn");
            check = true;
            button1.SetActive(false);
            button2.SetActive(true);
        }else if(check)
        {
            animator.Play("MoveOut");
            check = false;
            button1.SetActive(true);
            button2.SetActive(false);
        }
        
    }
}
