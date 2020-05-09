using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public GameObject Box1;
    public int massbeakerwater;
    public string MBW;
    public Text MassOfBeakerWater;
    public int massbeaker;
    public string MB;
    public Text MassOfBeaker;
    public double total;
    public int sub;

    public GameObject Box2;
    public int massblockwater;
    public string MBLW;
    public Text MassOfBlockWater;
    public int massblock;
    public string MBL;
    public Text MassOfBlock;
    public double total2;
    public int sub2;

    public GameObject Box3;
    public double total3;

    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Collect()
    {
        MBW = MassOfBeakerWater.text.ToString();
        massbeakerwater = int.Parse(MBW);
        MB = MassOfBeaker.text.ToString();
        massbeaker = int.Parse(MB);
        sub = massbeakerwater - massbeaker;
        total = sub * 9.8;
        Box1.GetComponent<Text>().text = "(" + MBW + " - " + MB + ") " + " * 9.8" + " = " + total + "N";

        MBLW = MassOfBlockWater.text.ToString();
        massblockwater = int.Parse(MBLW);
        MBL = MassOfBlock.text.ToString();
        massblock = int.Parse(MBL);
        sub2 = massblock - massblockwater;
        total2 = sub2 * 9.8;
        Box2.GetComponent<Text>().text = "(" + MBL + " - " + MBLW + ") " + " * 9.8" + " = " + total2 + "N";

        total3 = sub2 * 9.8 * 1;
        Box3.GetComponent<Text>().text = sub2 + " * 1 * 9.8" + " = " + total3 + "N";

        panel.GetComponent<Animator>().Play("UpObservation");
        StartCoroutine(SetStage());
        // if(MBW.Length > 0 && MB.Length > 0)
        // {
            
        // }else
        // {
        //     Box1.GetComponent<Text>().text = "Input your values";
        // }

        // if(MBLW.Length > 0 && MBL.Length > 0)
        // {
            
        // }else
        // {
        //     Box2.GetComponent<Text>().text = "Input your values";
        // }
        
    }

    IEnumerator SetStage()
    {
        yield return new WaitForSeconds(0.5f);
        panel.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
    }
}
