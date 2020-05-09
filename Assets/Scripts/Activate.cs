using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject Liquid;
    public GameObject Activator;
    public bool On;

    void OnTriggerEnter()
    {
        On = true;
        Liquid.SetActive(true);
        Activator.SetActive(false);
    }
}
