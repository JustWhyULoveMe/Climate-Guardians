// CityReputationManager.cs
using UnityEngine;
using UnityEngine.UI;

public class CityReputationManager : Singleton<CityReputationManager>
{
    private int reputationPoints;

    public Gradient gradientR;

    public float minRep, maxRep;

    public Image filledBarR;

    private float currentRep;

    private void Start()
    {

        currentRep  = maxRep / 10;

        
        UpdateRUI();
    }
    


    public void ReduceReputation(float points)
    {
        currentRep = Mathf.Clamp(currentRep - points, minRep, maxRep);
        UpdateRUI();
        // Update city pollution level, etc.
    }
    public void IncreaseReputation(float points)
    {
        currentRep = Mathf.Clamp(currentRep + points, minRep, maxRep);
        UpdateRUI();
    }





    void UpdateRUI()
    {
        filledBarR.fillAmount = (float)currentRep / maxRep;

        filledBarR.color = gradientR.Evaluate(filledBarR.fillAmount);
    }

    /*public Gradient gradientR;

    public Image filledBarR;

    public float minRep, maxRep;

    private float currentRep;

    private void Start()
    {

        currentRep = maxRep / 10;

        UpdateRUI();
    }


    public void ReduceReputation(reputationPoints)
    {
        currentRep = Mathf.Clamp(currentRep - reputationPoints, minRep, maxRep);
        UpdateRUI();
        // Update city pollution level, etc.
    }
    public void AddReputation(reputationPoints)
    {
        currentRep = Mathf.Clamp(currentRep + reputationPoints, minRep, maxRep);
        UpdateRUI();
    }


    void UpdateRUI()
    {
        filledBarR.fillAmount = (float)currentRep / maxRep;

        filledBarR.color = gradientR.Evaluate(filledBarR.fillAmount);
    }*/
}