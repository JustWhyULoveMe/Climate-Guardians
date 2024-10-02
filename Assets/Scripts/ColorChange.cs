using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRendererToChangeColor;
    public Color colorYouWant;

    private void Awake()
    {
        spriteRendererToChangeColor = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        ChangeColor(colorYouWant);
    }

    public void ChangeColor(Color color)
    {
        spriteRendererToChangeColor.material.color = color;
    }

















    /*void Start()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
    }

    public void ClickMenuBtn()
    {
        // Change the 'color' property of the 'Sprite Renderer'
        sprite.color = new Color(0f, 0f, 0f, 1f); // Set to opaque black
    }

    public void BtnColorBack()
    {
        sprite.color = new Color(250, 208, 116);
    }*/
}
