using UnityEngine;

public class Highlight : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // reference to the sprite renderer

    void Start()
    {
        // initialize the sprite renderer
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}