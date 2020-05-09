using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialUI : MonoBehaviour
{
    public GameObject tutUI;
    public GameObject instructUI;
    public GameObject instructUI2;
    public GameObject instructUI3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Text1());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator Text1()
    {
        yield return new WaitForSeconds(2.5f);
        instructUI.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        instructUI2.SetActive(true);
        instructUI.SetActive(false);
        instructUI3.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        instructUI2.SetActive(false);
        instructUI.SetActive(false);
        instructUI3.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        instructUI3.SetActive(true);
        instructUI.SetActive(false);
        instructUI2.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        instructUI3.SetActive(false);
        instructUI2.SetActive(false);
        instructUI.SetActive(false);
        tutUI.SetActive(false);
    }


}
