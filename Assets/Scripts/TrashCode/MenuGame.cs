using UnityEngine;
using UnityEngine.UI;

public class MenuGame : MonoBehaviour
{
    // Reference to the buttons and the text panel
    public Button button1;
    public Button button2;
    public Button button3;
    public Text panelText; // The text that will be updated next to the buttons

    // Define colors for selected and unselected states
    public Color selectedColor = Color.green;
    public Color defaultColor = Color.white;

    // Texts that will appear on the panel when each button is clicked
    public string button1Text = "This is Button 1 Text";
    public string button2Text = "This is Button 2 Text";
    public string button3Text = "This is Button 3 Text";

    private Button activeButton = null;

    void Start()
    {
        // Add listeners for button clicks
        button1.onClick.AddListener(() => OnButtonClick(button1, button1Text));
        button2.onClick.AddListener(() => OnButtonClick(button2, button2Text));
        button3.onClick.AddListener(() => OnButtonClick(button3, button3Text));

        // Initialize the panel text and button colors
        panelText.text = "";
        ResetButtonColors();
    }

    // Method to handle button clicks
    void OnButtonClick(Button clickedButton, string textToDisplay)
    {
        // Update the panel text
        panelText.text = textToDisplay;

        // Change the color of the clicked button and reset others
        ChangeButtonColor(clickedButton);

        // Set this button as the active button
        activeButton = clickedButton;
    }

    // Method to reset button colors
    void ResetButtonColors()
    {
        SetButtonColor(button1, defaultColor);
        SetButtonColor(button2, defaultColor);
        SetButtonColor(button3, defaultColor);
    }

    // Method to change the color of a button and reset the others
    void ChangeButtonColor(Button clickedButton)
    {
        // Reset all button colors to default
        ResetButtonColors();

        // Change the clicked button to the selected color
        SetButtonColor(clickedButton, selectedColor);
    }

    // Helper method to set button color
    void SetButtonColor(Button button, Color color)
    {
        ColorBlock cb = button.colors;
        cb.normalColor = color;
        button.colors = cb;
    }
}
