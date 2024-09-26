# Climate-Guardians
 Climate Guardians video game 

private void Update()
{
    moneyDisplay.text = money.ToString();

    if (Input.GetMouseButtonDown(0) && buildingToPlace != null)
    {
        Tile nearestTile = null;
        float shortestDistance = float.MaxValue;

        // Поиск ближайшей клетки
        foreach (Tile tile in tiles)
        {
            float dist = Vector2.Distance(tile.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (dist < shortestDistance)
            {
                shortestDistance = dist;
                nearestTile = tile;
            }
        }

        if (nearestTile != null && !nearestTile.isOccupied)
        {
            // Определяем вторую клетку, которую будет занимать здание
            Vector2 offset = new Vector2(buildingToPlace.width - 1, 0);  // Смещение для здания 2x1
            Vector2 secondTilePos = nearestTile.transform.position + (Vector3)offset;

            Tile secondTile = null;
            foreach (Tile tile in tiles)
            {
                if (Vector2.Distance(tile.transform.position, secondTilePos) < 0.1f)
                {
                    secondTile = tile;
                    break;
                }
            }

            // Проверка, что обе клетки не заняты
            if (secondTile != null && !secondTile.isOccupied)
            {
                // Размещаем здание
                Vector2 buildingPosition = (nearestTile.transform.position + secondTile.transform.position) / 2;
                Instantiate(buildingToPlace, buildingPosition, Quaternion.identity);

                // Отмечаем клетки как занятые
                nearestTile.isOccupied = true;
                secondTile.isOccupied = true;

                buildingToPlace = null;
                grid.SetActive(false);
                customCursor.gameObject.SetActive(false);
                Cursor.visible = true;
            }
        }
    }
}