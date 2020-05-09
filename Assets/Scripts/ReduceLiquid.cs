using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReduceLiquid : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public bool live;
    public GameObject reduceCylinder;
    public GameObject ImmerseSolidChecker;
    public SolidUnderWaterChecker trigger;
    private GameObject otherGameObject;
    public GameObject scaleGameObject;
    private Text ScaleNumber;

    void Start()
    {
        trigger = ImmerseSolidChecker.GetComponent<SolidUnderWaterChecker>();
        ScaleNumber = scaleGameObject.GetComponent<Text>();
    }

    void startCollecting()
    {
        reduceCylinder.transform.localScale -= new Vector3(a, b, c) * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        otherGameObject = other.gameObject;
        live = true;   
    }

    void Update()
    {
        if(live && otherGameObject.tag == "liquid")
        {
           if(reduceCylinder.transform.localScale.y >= 1)
            {
                trigger.enabled = false;
            }

            if(reduceCylinder.transform.localScale.y > 0.82)
            {
                startCollecting();
            }
        }
    }
}
