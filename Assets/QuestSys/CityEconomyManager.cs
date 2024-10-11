// CityEconomyManager.cs
using UnityEngine;
using UnityEngine.UI;
public class CityEconomyManager : Singleton<CityEconomyManager>
{
    private int money;

    public Text moneyDisplay;

    public void AddMoney(int amount)
    {
        money += amount;
        moneyDisplay.text = money.ToString();
        // Update city economy, etc.
    }




}