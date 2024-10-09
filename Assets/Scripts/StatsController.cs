using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsController: MonoBehaviour
{
    private Image _image;
    [SerializeField] private Gradient barGradient; 
    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void UpdateBar(float maxBar, float currentBar)
    {
        _image.fillAmount = currentBar / maxBar;
    }

}
