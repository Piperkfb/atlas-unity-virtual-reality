using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorChanger : MonoBehaviour
{
    public Graphic MenuBG;
    public Graphic TextColor;
    public Graphic OtherColor;
    public Graphic ButtonColor;
    public Graphic HighlightedColor;
    private Color32 LightGrey = new Color32(204, 204, 204, 255);
    private Color32 DarkGrey = new Color32(85, 85, 85, 255);
    private Color32 BrightBlue = new Color32(0, 0, 255, 255);
    private Color32 DarkBlue = new Color32(0, 0, 51, 255);
    private Color32 Yellow = new Color32(255, 255, 0, 255);
    private Color32 LightBlue = new Color32(102, 153, 255, 255);
    private Color32 Grey = new Color32(128, 128, 128, 255);
    private Color32 Orange = new Color32(255, 165, 0, 255);
    private Color32 DarkishGrey = new Color32(51, 51, 51, 255); 
    private Color32 OliveGreen = new Color32(128, 128, 0, 255);
    private Color32 SkyBlue = new Color32(135, 206, 235, 255);
    public Button ConB, RGB, BLB;

    void Start()
    {
        ConB.onClick.AddListener(Contrast);
        RGB.onClick.AddListener(RedGreen);
        BLB.onClick.AddListener(BlueYellow);
    }
    void Contrast()
    {
        MenuBG.color = Color.black;
        TextColor.color = Color.white;
        OtherColor.color = LightGrey;
        ButtonColor.color = DarkGrey;
        HighlightedColor.color = BrightBlue;
    }
    void RedGreen()
    {
        MenuBG.color = DarkBlue;
        TextColor.color = Yellow;
        OtherColor.color = LightBlue;
        ButtonColor.color = Grey;
        HighlightedColor.color = Orange;
    }
    void BlueYellow()
    {
        MenuBG.color = DarkishGrey;
        TextColor.color = Color.white;
        OtherColor.color = LightGrey;
        ButtonColor.color = OliveGreen;
        HighlightedColor.color = SkyBlue;
    }
}
