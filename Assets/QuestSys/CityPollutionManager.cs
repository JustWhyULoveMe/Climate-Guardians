// CityPollutionManager.cs
using UnityEngine;
using UnityEngine.UI;

public class CityPollutionManager : Singleton<CityPollutionManager>
{
    public Image filledBarT;
    public Image filledBarR;

    public Gradient gradientT;
    public Gradient gradientR;

    public float minTrash, maxTrash;
    public float minRep, maxRep;


    private float currentTrash;
    private float currentRep;

    private void Start()
    {

        currentTrash = maxTrash / 10;

        UpdateTUI();
        UpdateRUI();
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














    public void ReduceReputation(float reduction)
    {
        currentRep = Mathf.Clamp(currentRep - reduction, minRep, maxRep);
        UpdateRUI();
        // Update city pollution level, etc.
    }
    public void IncreaseReputation(float reduction)
    {
        currentRep = Mathf.Clamp(currentRep + reduction, minRep, maxRep);
        UpdateRUI();
    }





    void UpdateRUI()
    {
        filledBarR.fillAmount = (float)currentRep / maxRep;

        filledBarR.color = gradientR.Evaluate(filledBarR.fillAmount);
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

