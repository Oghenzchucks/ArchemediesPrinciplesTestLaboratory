using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDrop : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;
    public bool check;

    void Drops()
    {
        Rigidbody projectileInstance;
        projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation);
    }
    
    void OnTriggerEnter()
    {
        check = true;
        InvokeRepeating("Drops", 0.5f, 0.3f);
    }

    void OnTriggerExit()
    {
        CancelInvoke();
    }

}
