// CityPollutionManager.cs
using UnityEngine;

public class CityPollutionManager : Singleton<CityPollutionManager>
{
    private float pollutionLevel;

    public void ReducePollution(float reduction)
    {
        pollutionLevel -= reduction;
        // Update city pollution level, etc.
    }
}