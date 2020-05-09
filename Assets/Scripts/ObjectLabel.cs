using UnityEngine;
using UnityEngine.UI;


public class ObjectLabel : MonoBehaviour {

    public string myString;
    public Text text;
    public Image image;
    public float fadeTime;
    public bool displayInfo;

    void Start() {
        text.color = Color.clear;
        image.color = Color.clear;

    }

    void Update() {
        FadeText();
    }

    void OnMouseOver() {
        displayInfo = true;
    }

    void OnMouseExit() {
        displayInfo = false;
    }

    void FadeText() {
        if (displayInfo) {
            text.text = myString;
            text.color = Color.Lerp(text.color, Color.white, fadeTime * Time.deltaTime);
            image.color = Color.Lerp(image.color, Color.white, fadeTime * Time.deltaTime);
        }
        else {
            text.color = Color.Lerp(text.color, Color.clear, fadeTime * Time.deltaTime);
            image.color = Color.Lerp(image.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}