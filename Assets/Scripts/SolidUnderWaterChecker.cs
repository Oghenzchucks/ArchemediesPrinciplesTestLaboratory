using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolidUnderWaterChecker : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public GameObject increaseCylinder;
    private GameObject otherGameObject;
    public bool check;
    public GameObject indicator;
    public GameObject indicator2;
    public GameObject panel;
    public GameObject tick;

    void Start()
    {
        x = 0;
        y = 0.1f;
        z = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        otherGameObject = other.gameObject;
        check = true;
    }

    void OnTriggerExit(Collider other)
    {
        otherGameObject = null;
        check = false;
    }

    void startPouring()
    {
        increaseCylinder.transform.localScale += new Vector3(x, y, z) * Time.deltaTime;
    }

    void Update()
    {
        if(check && otherGameObject.tag == "copper")
        {
            if (increaseCylinder.transform.localScale.y < 1)
            {
                startPouring();
                StartCoroutine(Delay());
                tick.SetActive(true);
            }
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2.0f);
        indicator.SetActive(false);
        indicator2.SetActive(true);
        panel.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        panel.SetActive(false);
    }
}
