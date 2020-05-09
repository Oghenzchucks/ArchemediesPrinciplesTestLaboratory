using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSystem : MonoBehaviour
{
    public static int state;
    public int value;
    public GameObject can;
    public float x;
    public float y;
    public float z;

    void OnMouseDrag()
    {
        state = 1;
    }

    void OnMouseUp()
    {
        state = 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        value = state;
        if(state == 2)
        {
            can.transform.position = new Vector3(x, y, z);
        }
    }
}
