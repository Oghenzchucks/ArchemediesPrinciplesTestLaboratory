using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overFlowCan : MonoBehaviour
{
    public GameObject can1;
    public GameObject can2;
    public bool trigger;
    private GameObject otherGameObject;
    public string text;
    public GameObject tick;

    public int state;

    void Start()
    {
        
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
            if(trigger && otherGameObject.tag == "can")
            {
                // StateSystem.state = 3;
                can1.SetActive(false);
                can2.SetActive(true);
                tick.SetActive(true);
                
            }
        }
    }
}
