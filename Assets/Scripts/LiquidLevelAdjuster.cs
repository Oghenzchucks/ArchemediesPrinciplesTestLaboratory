using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiquidLevelAdjuster : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public GameObject increaseCylinder;
    public int incrementalReading;
    public GameObject scaleGameObject;
    private Text ScaleNumber;

    void Start()
    {
        x = 0;
        y = 0.1f;
        z = 0;
        incrementalReading = 100;
        ScaleNumber = scaleGameObject.GetComponent<Text>();
    }

    void startPouring()
    {
        increaseCylinder.transform.localScale += new Vector3(x, y, z) * Time.deltaTime;
        
        ScaleNumber.text = incrementalReading + ".00g";
        if(incrementalReading < 300)
        {
            incrementalReading += 5;
        }
    }

    void OnTriggerEnter()
    {
        startPouring();
    }
}
