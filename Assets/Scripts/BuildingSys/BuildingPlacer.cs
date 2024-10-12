/*using UnityEngine;

public class BuildingMode : MonoBehaviour
{
    public GridSystem gridSystem; // reference to the GridSystem script
    public Building buildingPrefab; // reference to the Building prefab
    public Highlight highlightPrefab; // reference to the Highlight prefab

    private bool isBuildingMode = true; // initial mode
    private Building currentBuilding; // current building being placed
    private Highlight currentHighlight; // current highlight being shown

    void Start()
    {
        // initialize the building mode
        ToggleBuildingMode();
    }

    public void ToggleBuildingMode()
    {
        isBuildingMode = !isBuildingMode;

        if (isBuildingMode)
        {
            // enable building placement
            gridSystem.EnableBuildingPlacement();
        }
        else
        {
            // disable building placement
            gridSystem.DisableBuildingPlacement();
        }
    }

    void Update()
    {
        if (isBuildingMode)
        {
            // handle building placement
            HandleBuildingPlacement();
        }
    }

    void HandleBuildingPlacement()
    {
        // get the mouse position
        Vector2 mousePosition = Input.mousePosition;

        // convert mouse position to grid coordinates
        int x = (int)mousePosition.x / gridSystem.cellSize;
        int y = (int)mousePosition.y / gridSystem.cellSize;

        // check if the building can be placed at the current position
        if (gridSystem.CanPlaceBuilding(buildingPrefab, x, y))
        {
            // show highlight
            ShowHighlight(x, y, buildingPrefab.sizeX, buildingPrefab.sizeY);

            // handle building placement on click
            if (Input.GetMouseButtonDown(0))
            {
                // place the building
                PlaceBuilding(x, y);
            }
        }
        else
        {
            // hide highlight
            HideHighlight();

            // show red highlight to indicate invalid placement
            ShowInvalidHighlight(x, y, buildingPrefab.sizeX, buildingPrefab.sizeY);
        }
    }

    void ShowHighlight(int x, int y, int width, int height)
    {
        // create a new highlight instance
        currentHighlight = Instantiate(highlightPrefab, new Vector2(x, y), Quaternion.identity);

        // set the highlight size
        currentHighlight.transform.localScale = new Vector2(width, height);
        currentHighlight.GetComponent<SpriteRenderer>().color = Color.green;
    }

    void ShowInvalidHighlight(int x, int y, int width, int height)
    {
        // create a new highlight instance
        currentHighlight = Instantiate(highlightPrefab, new Vector2(x, y), Quaternion.identity);

        // set the highlight size
        currentHighlight.transform.localScale = new Vector2(width, height);
        currentHighlight.GetComponent<SpriteRenderer>().color = Color.red;
    }

    void HideHighlight()
    {
        // destroy the current highlight instance
        Destroy(currentHighlight.gameObject);
    }

    void PlaceBuilding(int x, int y)
    {
        // create a new building instance
        currentBuilding = Instantiate(buildingPrefab, new Vector2(x, y), Quaternion.identity);

        // set the building's grid position
        currentBuilding.gridX = x;
        currentBuilding.gridY = y;

        // update the grid system
        gridSystem.PlaceBuilding(currentBuilding);

        // hide highlight
        HideHighlight();
    }
}*/


using UnityEngine;

public class BuildingPlacer : MonoBehaviour

{

    public Building building;

    private Grid grid; // Add a Grid reference


    void Start()

    {

        grid = GameObject.FindObjectOfType<Grid>(); // Get the Grid instance

    }


    void Update()

    {

        if (Input.GetMouseButtonDown(0))

        {
            if (grid.cellSize > 0)
            {

                int x = (int)Input.mousePosition.x / (int)grid.cellSize; // Use the Grid instance

                int y = (int)Input.mousePosition.y / (int)grid.cellSize; // Use the Grid instance
                building.PlaceBuilding(x, y);
            }
            
            else
            {
                Debug.LogError("Grid cell size is zero!");
            }

            

        }

    }

}