using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForBeakerandPipette : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float a;
    public float b;
    public float c;
    public float speed;
    public GameObject increaseCylinder;
    public GameObject reduceCylinder;
    public bool start;
    public Transform endMarker;
    public Transform endMarker2;
    public Rigidbody projectile;
    public Transform barrelEnd;

    private GameObject otherGameObject;
    void Start()
    {
        x = 0;
        y = 0.1f;
        z = 0;
        a = 0;
        b = 0.02f;
        c = 0;
    }

    void startPouring()
    {
        increaseCylinder.transform.localScale += new Vector3(x, y, z) * Time.deltaTime;
    }

    void startCollecting()
    {
        reduceCylinder.transform.localScale -= new Vector3(a, b, c) * Time.deltaTime;
    }

    void Drops()
    {
        Rigidbody projectileInstance;
        projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation);
    }

    void MoveCameraTo()
    {
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, endMarker.position, speed * 5.2f);
    }

    void MoveCameraOut()
    {
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, endMarker2.position, speed * 5.2f);
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     start = true;
    //     otherGameObject = other.gameObject;
    //     MoveCameraTo();
    // }

    // void OnTriggerExit(Collider other)
    // {
    //     start = false;
    //     otherGameObject = null;
    //     MoveCameraOut();
    // }

    void Update()
    {
        if (increaseCylinder.transform.localScale.y < 1){
            startPouring();
        }
    }
}
