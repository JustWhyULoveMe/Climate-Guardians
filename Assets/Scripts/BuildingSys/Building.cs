using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int sizeX = 1;
    public int sizeY = 1;
    public GameObject prefab;

    private Grid grid;

    void Start()
    {
        grid = GameObject.FindObjectOfType<Grid>();
    }

    public void PlaceBuilding(int x, int y)
    {
        if (CanPlaceBuilding(x, y))
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    Cell cell = grid.GetCell(x + i, y + j);
                    if (cell != null)
                    {
                        GameObject buildingObject = Instantiate(prefab, new Vector3((x + i) * cell.size, (y + j) * cell.size, 0), Quaternion.identity);
                        buildingObject.transform.parent = transform;
                    }
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
                if (cell == null || cell.prefab != null)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public void DestroyBuilding(int x, int y)
    {
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                Cell cell = grid.GetCell(x + i, y + j);
                if (cell != null)
                {
                    GameObject buildingObject = cell.prefab;
                    if (buildingObject != null)
                    {
                        Destroy(buildingObject);
                    }
                }
            }
        }
    }
}