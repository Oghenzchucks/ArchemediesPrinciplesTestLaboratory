using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDisable : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    
    public void EnablePanelLab()
    {
        panel.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(true);
        panel4.SetActive(true);
    }

    public void ExitPanel()
    {
        Application.Quit();
    }
}
