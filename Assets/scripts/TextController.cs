using UnityEngine;
using UnityEngine.UI;
public class TextController : MonoBehaviour
{
    
    private Text text;

    //public GameObject canvasGO;
    public Canvas canvas;
    public GameObject textGO;

    void Awake()
    {
       
        //canvas.renderMode = RenderMode.ScreenSpaceOverlay;


        textGO.AddComponent<Text>();

        text = textGO.GetComponent<Text>();
        
        text.text = "Press space key";
        text.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        text.fontSize = 48;
        text.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 0);
        rectTransform.sizeDelta = new Vector2(600, 200);
    }
    public void setText(string newText)
    {
        text.text =  newText;
    }
}