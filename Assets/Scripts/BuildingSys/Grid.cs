using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int gridSizeX = 10;
    public int gridSizeY = 10;
    public float cellSize = 1f;
    public GameObject cellPrefab; // Add this field

    private Cell[,] cells;

    void Start()
    {
        CreateGrid();
    }

    void CreateGrid()
    {
        cells = new Cell[gridSizeX, gridSizeY];

        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                Cell cell = new Cell(x, y, cellSize, cellPrefab); // Pass the cellPrefab to the Cell constructor
                cells[x, y] = cell;
                GameObject cellObject = Instantiate(cellPrefab, new Vector3(x * cellSize, y * cellSize, 0), Quaternion.identity); // Use the cellPrefab here
                cellObject.transform.parent = transform;
            }
        }
    }

    public Cell GetCell(int x, int y)
    {
        if (x >= 0 && x < gridSizeX && y >= 0 && y < gridSizeY)
        {
            return cells[x, y];
        }
        else
        {
            return null;
        }
    }


}

[System.Serializable]
public class Cell
{
    public int x;
    public int y;
    public float size;
    public GameObject prefab;

    public Cell(int x, int y, float size, GameObject prefab) // Add the prefab parameter to the constructor
    {
        this.x = x;
        this.y = y;
        this.size = size;
        this.prefab = prefab;


    }

}

