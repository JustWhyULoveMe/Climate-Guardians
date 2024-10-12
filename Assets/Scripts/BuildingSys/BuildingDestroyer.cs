using UnityEngine;

public class BuildingDestroyer : MonoBehaviour

{

    public Building building;

    private Grid grid; // Add a Grid reference


    void Start()

    {

        grid = GameObject.FindObjectOfType<Grid>(); // Get the Grid instance

    }


    void Update()

    {

        if (Input.GetMouseButtonDown(1))

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