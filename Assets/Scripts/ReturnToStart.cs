using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToStart : MonoBehaviour
{
    public void ReturnToPanelLab()
    {
        SceneManager.LoadScene(0);
    }
}
