using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuContrl : MonoBehaviour
{

    public GameObject buildingsPanel;
    public GameObject questsPanel;
    public GameObject statsPanel;
    public GameObject MainMenu;

    // Start method to make sure only the active panel shows up initially
    void Start()
    {
        /*buildingsPanel.SetActive(false);
        questsPanel.SetActive(true);
        statsPanel.SetActive(false);*/
    }

    // Method to switch to the Buildings Tab
    /*public void OpenBuildingsPanel()
    {
        buildingsPanel.SetActive(true);
        questsPanel.SetActive(false);
        statsPanel.SetActive(false);
    }

    // Method to switch to the Quests Tab
    public void OpenQuestsPanel()
    {
        buildingsPanel.SetActive(false);
        questsPanel.SetActive(true);
        statsPanel.SetActive(false);
    }

    // Method to switch to the Stats Tab
    public void OpenStatsPanel()
    {
        buildingsPanel.SetActive(false);
        questsPanel.SetActive(false);
        statsPanel.SetActive(true);
    }

*/




















    /*public GameObject BuyUI;

    public void ShowUI()
    {
        BuyUI.SetActive(false);
    }
*/




    /*public GameObject object1; // Drag Object1 here in the inspector
    public GameObject object2; // Drag Object2 here in the inspector

    public Button button1; // Assign Button1 in the inspector
    public Button button2; // Assign Button2 in the inspector

    public void Button1Click()
    {
        ShowObject1();
    }
    public void Button2Click()
    {
        ShowObject2();
    }

    // Function to show Object1 and hide Object2
    void ShowObject1()
    {
        object1.SetActive(true);
        object2.SetActive(false);
    }

    // Function to show Object2 and hide Object1
    void ShowObject2()
    {
        object1.SetActive(false);
        object2.SetActive(true);
    }
*/










    /*public GameObject _z;
    public GameObject _s;
    public GameObject _m;


    public void ButtonClicked()
    {
        gameObject.SetActive(false);
    }*/



    /*public GameObject[] GameObjects;



    public void ButtonClicked()
    {
        GameObjects.SetActive(false);

        foreach (GameObject obj in GameObjects)
        {
            obj.SetActive(true);
        }
    }*/











    /*public Button button1;
    public Button button2;
    public Button button3;

    public Color selectedColor = Color.green;
    public Color defaultColor = Color.white;


    public void OnButtonClick(Button clickedButton, string textToDisplay)
    {
        SetButtonColor(clickedButton, selectedColor);
    }

    void SetButtonColor(Button button, Color color)
    {
        ColorBlock cb = button.colors;
        cb.normalColor = color;
        button.colors = cb;
    }*/
}
