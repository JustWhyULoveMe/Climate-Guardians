using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject BuyUI;
    public GameObject MenuUI;
    public GameObject MainMenul;
    public void ShowUI()
    {
        BuyUI.SetActive(true);
    }
    public void HideUI()
    {
        BuyUI.SetActive(false);
    }

    public void ShowMenu()
    {
        MenuUI.SetActive(true);
        MainMenul.SetActive(false);

    }
    public void HideMenu()
    {
        MenuUI.SetActive(false);
        MainMenul.SetActive(true);
    }
}
