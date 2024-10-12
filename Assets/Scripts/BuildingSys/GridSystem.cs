/*using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public int gridSizeX = 10; // grid size in x direction
    public int gridSizeY = 10; // grid size in y direction
    public float cellSize = 1.0f; // size of each cell

    private bool[,] grid; // 2D array to represent the grid
    private Building[,] buildings; // 2D array to store the buildings

    void Start()
    {
        // initialize the grid
        grid = new bool[gridSizeX, gridSizeY];
        buildings = new Building[gridSizeX, gridSizeY];

        // initialize all cells to be empty
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                grid[x, y] = true;
                buildings[x, y] = null;
            }
        }
    }

    public bool CanPlaceBuilding(Building building, int x, int y)
    {
        // check if the building can be placed at the given position
        for (int i = 0; i < building.sizeX; i++)
        {
            for (int j = 0; j < building.sizeY; j++)
            {
                if (x + i < 0 || x + i >= gridSizeX || y + j < 0 || y + j >= gridSizeY)
                {
                    return false;
                }

                if (!grid[x + i, y + j])
                {
                    return false;
                }
            }
        }

        return true;
    }

    public void PlaceBuilding(Building building)
    {
        // update the grid to mark the cells as occupied
        for (int i = 0; i < building.sizeX; i++)
        {
            for (int j = 0; j < building.sizeY; j++)
            {
                grid[building.gridX + i, building.gridY + j] = false;
                buildings[building.gridX + i, building.gridY + j] = building;
            }
        }
    }

    public void EnableBuildingPlacement()
    {
        // enable building placement
    }

    public void DisableBuildingPlacement()
    {
        // disable building placement
    }
}*/