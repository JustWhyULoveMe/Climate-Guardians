// CityEconomyManager.cs
using UnityEngine;

public class CityEconomyManager : Singleton<CityEconomyManager>
{
    private int money;

    public void AddMoney(int amount)
    {
        money += amount;
        // Update city economy, etc.
    }
}