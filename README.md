# Climate-Guardians
 Climate Guardians video game 

using UnityEngine;
using TMPro;

public class BuildingPlacement : MonoBehaviour
{
    public int money;
    public TMP_Text moneyDisplay;

    private Building buildingToPlace;
    public GameObject grid;

    public CustomCursor customCursor;

    public Tile[] tiles;

    private void Update()
    {
        moneyDisplay.text = money.ToString();

        if (Input.GetMouseButtonDown(0) && buildingToPlace != null)
        {
            Tile nearestTile = null;
            float shortestDistance = float.MaxValue;
            
            // Найти ближайшую клетку к позиции курсора
            foreach (Tile tile in tiles)
            {
                float dist = Vector2.Distance(tile.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
                if (dist < shortestDistance)
                {
                    shortestDistance = dist;
                    nearestTile = tile;
                }
            }

            if (nearestTile != null && CanPlaceBuilding(nearestTile, buildingToPlace.size))
            {
                // Установить здание на все клетки, которые оно занимает
                PlaceBuilding(nearestTile, buildingToPlace);
                
                buildingToPlace = null;
                grid.SetActive(false);
                customCursor.gameObject.SetActive(false);
                Cursor.visible = true;
            }
        }
    }

    private bool CanPlaceBuilding(Tile startTile, Vector2Int buildingSize)
    {
        // Проверяем, свободны ли все клетки для здания
        for (int x = 0; x < buildingSize.x; x++)
        {
            for (int y = 0; y < buildingSize.y; y++)
            {
                Vector3Int tilePosition = new Vector3Int(startTile.gridPosition.x + x, startTile.gridPosition.y + y, 0);
                Tile tile = GetTileAtPosition(tilePosition);  // Метод, который получает клетку по позиции
                if (tile == null || tile.isOcupied)
                {
                    return false; // Если клетка занята или её нет, здание нельзя разместить
                }
            }
        }
        return true;
    }

    private Tile GetTileAtPosition(Vector3Int position)
    {
        // Возвращает клетку по её позиции на сетке
        foreach (Tile tile in tiles)
        {
            if (tile.gridPosition == position)
            {
                return tile;
            }
        }
        return null;
    }

    private void PlaceBuilding(Tile startTile, Building building)
    {
        // Размещаем здание на все клетки
        for (int x = 0; x < building.size.x; x++)
        {
            for (int y = 0; y < building.size.y; y++)
            {
                Vector3Int tilePosition = new Vector3Int(startTile.gridPosition.x + x, startTile.gridPosition.y + y, 0);
                Tile tile = GetTileAtPosition(tilePosition);
                if (tile != null)
                {
                    tile.isOcupied = true;
                }
            }
        }
        
        Instantiate(building, startTile.transform.position, Quaternion.identity);
    }

    public void BuyBuilding(Building building)
    {
        if (money >= building.cost)
        {
            customCursor.gameObject.SetActive(true);
            customCursor.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
            Cursor.visible = false;  

            money -= building.cost;
            buildingToPlace = building;
            grid.SetActive(true);
        }
    }
}
