// CityPollutionManager.cs
using UnityEngine;
using UnityEngine.UI;

public class CityPollutionManager : Singleton<CityPollutionManager>
{
    public Image filledBarT;
    

    public Gradient gradientT;
    

    public float minTrash, maxTrash;
    


    private float currentTrash;
    

    private void Start()
    {

        currentTrash = maxTrash / 10;

        UpdateTUI();
        
    }


    private float pollutionLevel;

    public void ReducePollution(float reduction)
    {
        currentTrash = Mathf.Clamp(currentTrash - reduction, minTrash, maxTrash);
        UpdateTUI();
        // Update city pollution level, etc.
    }
    public void IncreasePollution(float reduction)
    {
        currentTrash = Mathf.Clamp(currentTrash + reduction, minTrash, maxTrash);
        UpdateTUI();
    }

    void UpdateTUI()
    {
        filledBarT.fillAmount = (float)currentTrash / maxTrash;

        filledBarT.color = gradientT.Evaluate(filledBarT.fillAmount);
    }














    
}


/*  public void Clean(float points)
  {
      currentTrash = Mathf.Clamp(currentTrash - points, minTrash, maxTrash);
      UpdateUI();
  }
*/
/* public void Polute(float points)
 {
     currentTrash = Mathf.Clamp(currentTrash + points, minTrash, maxTrash);
     UpdateUI();
 }*/

