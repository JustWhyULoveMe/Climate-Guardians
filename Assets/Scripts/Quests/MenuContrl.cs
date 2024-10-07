using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuContrl : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public Color selectedColor = Color.green;
    public Color defaultColor = Color.white;


    public void OnButtonClick(Button clickedButton, string textToDisplay)
    {
        SetButtonColor(clickedButton, selectedColor);
    }

    void SetButtonColor(Button button, Color color)
    {
        ColorBlock cb = button.colors;
        cb.normalColor = color;
        button.colors = cb;
    }
}
