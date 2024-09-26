# Climate-Guardians
 Climate Guardians video game 

Чтобы реализовать возможность размещения зданий размером 2x1 клетки, нужно изменить несколько вещей в текущем коде. В частности, нужно:

	1.	Изменить логику проверки на размещение зданий, чтобы учитывать размер здания (2x1 клетки).
	2.	Подкорректировать выбор ближайших клеток и проверку их занятости.
	3.	Убедиться, что обе клетки, которые будет занимать здание, свободны перед размещением.

Вот как можно это сделать:

Изменения в классе Tile

Для начала нужно изменить класс Tile, чтобы он мог работать с большими зданиями:

public class Tile : MonoBehaviour
{
    public bool isOccupied = false;  // Я бы исправил с "isOcupied" на "isOccupied"

    // Опционально: добавить ссылку на здание, которое занимает эту клетку
    public Building occupiedBuilding;
}

Изменения в классе Building

Теперь нужно добавить в класс Building параметр, указывающий его размеры:

public class Building : MonoBehaviour
{
    public int width = 2;  // Ширина здания в клетках
    public int height = 1;  // Высота здания в клетках
    public int cost;  // Стоимость здания
}

Изменения в методе Update

В методе Update нужно учесть, что здание может занимать 2 клетки, поэтому при размещении необходимо проверять доступность обеих клеток. Вот обновленный код:

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