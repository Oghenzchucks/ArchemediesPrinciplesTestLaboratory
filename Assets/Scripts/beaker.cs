using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beaker : MonoBehaviour
{
    public GameObject beaker1;
    public GameObject beaker2;
    public bool trigger;
    private GameObject otherGameObject;
    public GameObject scaleGameObject;
    private Text ScaleNumber;
    public GameObject tick;

    void Start()
    {
        ScaleNumber = scaleGameObject.GetComponent<Text>();
    }


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
            if(trigger && otherGameObject.tag == "beaker")
            {
                beaker1.SetActive(false);
                beaker2.SetActive(true);
                ScaleNumber.text = "100.00g";
                tick.SetActive(true);
            }
        }
    }
}
