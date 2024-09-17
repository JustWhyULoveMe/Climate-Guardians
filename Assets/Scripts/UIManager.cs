using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject BuyUI;

    public void ShowUI()
    {
        BuyUI.SetActive(true);
    }
    public void HideUI()
    {
        BuyUI.SetActive(false);
    }
}
