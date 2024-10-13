using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject buildingPrefab; // Assign the building prefab in the inspector
    private Grid grid;

    void Start()
    {
        grid = FindObjectOfType<Grid>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left click to place a building
        {
            PlaceBuilding();
        }
        else if (Input.GetMouseButtonDown(1)) // Right click to remove a building
        {
            RemoveBuilding();
        }
    }

    void PlaceBuilding()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        int x = Mathf.FloorToInt(mousePos.x / grid.cellSize);
        int y = Mathf.FloorToInt(mousePos.y / grid.cellSize);

        Cell cell = grid.GetCell(x, y);
        if (cell != null && cell.prefab == null) // Check if the cell is empty
        {
            GameObject building = Instantiate(buildingPrefab, new Vector3(x * grid.cellSize, y * grid.cellSize, 0), Quaternion.identity);
            cell.prefab = building; // Assign the building to the cell
        }
    }

    void RemoveBuilding()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        int x = Mathf.FloorToInt(mousePos.x / grid.cellSize);
        int y = Mathf.FloorToInt(mousePos.y / grid.cellSize);

        Cell cell = grid.GetCell(x, y);
        if (cell != null && cell.prefab != null) // Check if there's a building to remove
        {
            Destroy(cell.prefab); // Destroy the building
            cell.prefab = null; // Clear the cell reference
        }
    }
}