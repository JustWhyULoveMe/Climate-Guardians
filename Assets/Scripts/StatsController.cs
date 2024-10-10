/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsController: MonoBehaviour
{
    private Image _image;
    [SerializeField] private Gradient barGradient;

    public float maxTBar = 10f;
    public float trashAmount = 1f;

    private void Start()
    {
        _image = GetComponent<Image>();
        CheckBarGradient();

    }

    public void LowTrashLevel()
    {
        trashAmount = trashAmount + 0.1f;
        CheckBarGradient();
    }

    public void CheckBarGradient()
    {
        _image.color = barGradient.Evaluate(trashAmount);
        _image.fillAmount = trashAmount;
    }




    
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour
{
    public Image filledBar;

    public Gradient gradient;

    public float minTrash, maxTrash;

    private float currentTrash;

    private void Start()
    {

        currentTrash = maxTrash / 10;

        UpdateUI();
    }

    public void Clean(float points)
    {
        currentTrash = Mathf.Clamp(currentTrash - points, minTrash, maxTrash);
        UpdateUI();
    }

    public void Polute(float points)
    {
        currentTrash = Mathf.Clamp(currentTrash + points, minTrash, maxTrash);
        UpdateUI();
    }

    void UpdateUI()
    {
        filledBar.fillAmount = (float)currentTrash / maxTrash;

        filledBar.color = gradient.Evaluate(filledBar.fillAmount);
    }
}