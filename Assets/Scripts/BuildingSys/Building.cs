using UnityEngine;

public class Building : MonoBehaviour
{
    public int sizeX = 1; // Width of the building in grid cells
    public int sizeY = 1; // Height of the building in grid cells

    void Start()
    {
        // You can add any initialization logic here if needed
    }
}



/*public void PlaceBuilding(int x, int y)
    {
        if (CanPlaceBuilding(x, y))
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    GameObject buildingObject = Instantiate(prefab, new Vector3((x + i) * grid.cellSize, (y + j) * grid.cellSize, 0), Quaternion.identity);
                    buildingObject.transform.parent = transform;
                }
            }
        }
    }

    public bool CanPlaceBuilding(int x, int y)
    {
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                Cell cell = grid.GetCell(x + i, y + j);
                if (cell == null || cell.prefab != null) // Check if the cell is occupied
                {
                    return false;
                }
            }
        }
        return true;
    }*/