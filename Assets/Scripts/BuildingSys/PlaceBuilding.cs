/*using UnityEngine;

public class PlaceBuilding : MonoBehaviour
{
    private Grid grid;
    private Building building;

    void Start()
    {
        grid = FindObjectOfType<Grid>();
        building = GetComponent<Building>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left click
        {
            PlaceBuildingOnGrid();
        }
    }

    void PlaceBuildingOnGrid()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; // Adjust z-value to match your camera's z-position
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        int x = Mathf.RoundToInt(worldPosition.x / grid.cellSize);
        int y = Mathf.RoundToInt(worldPosition.y / grid.cellSize);

        Grid.Cell cell = grid.GetCell(x, y);
        if (cell != null && !cell.IsOccupied())
        {
            building.PlaceOnCell(cell);
        }
    }
}*/