using UnityEngine;


public class Grid : MonoBehaviour

{

    public int gridSizeX = 10;

    public int gridSizeY = 10;

    public float cellSize = 0.16f;

    public GameObject cellPrefab;


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

                GameObject cellObject = Instantiate(cellPrefab, new Vector3(x * cellSize, y * cellSize, 0), Quaternion.identity);

                cellObject.transform.parent = transform;

                cells[x, y] = new Cell(x, y, cellSize, cellObject);

            }

        }

    }


    public Cell GetCell(int x, int y)

    {

        if (x >= 0 && x < gridSizeX && y >= 0 && y < gridSizeY)

        {

            return cells[x, y];

        }

        return null;

    }

}

[System.Serializable]
public class Cell
{
    public int x;
    public int y;
    public float size;
    public GameObject prefab; // Reference to the building prefab

    public Cell(int x, int y, float size, GameObject prefab)
    {
        this.x = x;
        this.y = y;
        this.size = size;
        this.prefab = prefab;
    }
}