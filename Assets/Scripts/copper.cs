using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copper : MonoBehaviour
{
    public GameObject copper1;
    public GameObject copper2;
    public bool trigger;
    private GameObject otherGameObject;
    public string text;
    public GameObject lever;
    public GameObject lever2;
    public GameObject panel;
    public bool set;
    public GameObject tick;


    void OnTriggerEnter(Collider other) {
        trigger = true;
        otherGameObject = other.gameObject;
    }

    void OnTriggerExit(Collider other) {
        trigger = false;
        otherGameObject = null;
    }

    void Update() {
        if(Input.GetMouseButtonUp(0))
        {
            if(trigger && otherGameObject.tag == "copper" && !set)
            {
                copper1.SetActive(false);
                copper2.SetActive(true);
                lever.SetActive(false);
                lever2.SetActive(true);
                StartCoroutine(Display());
                set = true;
                tick.SetActive(true);
            }
        }
    }

    IEnumerator Display()
    {
        panel.SetActive(true);
        yield return new WaitForSeconds(3);
        panel.SetActive(false);
    }
}
