/*using UnityEngine;
using static Grid;

public class RemoveBuilding : MonoBehaviour
{
    private Grid _grid;

    void Start()
    {
        _grid = FindObjectOfType<Grid>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Right click
        {
            RemoveBuildingFromGrid();
        }
    }

    void RemoveBuildingFromGrid()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; // Adjust z-value to match your camera's z-position
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        int x = Mathf.RoundToInt(worldPosition.x / _grid.cellSize);
        int y = Mathf.RoundToInt(worldPosition.y / _grid.cellSize);

        Cell cell = _grid.GetCell(x, y);
        if (cell != null && cell.IsOccupied())
        {
            cell.RemoveBuilding();
        }
    }
}*/