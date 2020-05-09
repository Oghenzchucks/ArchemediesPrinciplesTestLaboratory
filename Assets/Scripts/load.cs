using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    public int x;

    void Start()
    {
        x = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if(x == 1){
            StartCoroutine(SetStage2());
        }
        
    }

    IEnumerator SetStage2()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(1);
        x = 2;
    }
}
