using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool isOcupied;

    public Color greenColor;
    public Color redColor;

    private SpriteRenderer rend;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isOcupied == true)
        {
            rend.color = redColor;

        }
        else
        {
            rend.color = greenColor;
        }
    }
}
