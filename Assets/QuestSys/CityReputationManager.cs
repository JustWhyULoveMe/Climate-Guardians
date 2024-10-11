// CityReputationManager.cs
using UnityEngine;

public class CityReputationManager : Singleton<CityReputationManager>
{
    private int reputationPoints;

    public void AddReputationPoints(int points)
    {
        reputationPoints += points;
        // Update city reputation level, etc.
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