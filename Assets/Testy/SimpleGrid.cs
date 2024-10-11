/*using System;
using Gamelogic.Extensions;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace Gamelogic.Grids2.Examples
{
    public class PhysicalGrid<TPoint, TCell>
    {
        #region Private Fields

        private IGrid<TPoint, TCell> grid;
        private GridMap<TPoint> gridMap;
        private GameObject gameObject;

        #endregion

        #region Public Properties

        public IGrid<TPoint, TCell> Grid
        {
            get { return grid; }
        }

        public GridMap<TPoint> GridMap
        {
            get { return gridMap; }
        }

        public GameObject GameObject
        {
            get { return gameObject; }
        }

        #endregion

        #region Constructors

        public PhysicalGrid(
            IGrid<TPoint, TCell> grid,
            GridMap<TPoint> gridMap,
            GameObject gameObject)
        {
            this.grid = grid;
            this.gridMap = gridMap;
            this.gameObject = gameObject;
        }

        #endregion

        #region Public Methods

        public T GetComponent<T>()
            where T : GridBehaviour<TPoint, TCell>
        {
            return gameObject.GetComponent<T>();
        }

        public T AddComponent<T>()
            where T : GridBehaviour<TPoint, TCell>
        {
            var behavior = gameObject.AddComponent<T>();
            behavior.__InitPrivateFields(null, grid, gridMap);

            return behavior;
        }

        #endregion
    }

    public static class SimpleGrid
    {
        #region Public Static Methods

        public static IGrid<GridPoint2, T> Rect<T>(int width, int height)
        {
            var dimensions = new GridPoint2(width, height);

            var grid = ImplicitShape
                .Parallelogram(dimensions)
                .ToExplicit(new GridRect(GridPoint2.Zero, dimensions))
                .ToGrid<T>();

            return grid;
        }

        public static IGrid<GridPoint2, T> Rect<T>(int width, int height, T initialElement)
        {
            return Rect(width, height, () => initialElement);
        }

        public static IGrid<GridPoint2, T> Rect<T>(int width, int height, Func<T> createCell)
        {
            var grid = Rect<T>(width, height);

            grid.Fill(createCell);

            return grid;
        }

        /// <summary>
        /// Creates a Physical Grid.
        /// </summary>
        /// <param name="root">GameObject where all the cells are going to be stored.</param>
        /// <param name="width">Width of the grid.</param>
        /// <param name="height">Height of the grid.</param>
        /// <param name="prefab">Prefab to use for the cells on the grid.</param>
        /// <param name="cellDimensions">The cell's dimensions.</param>
        public static PhysicalGrid<GridPoint2, T> RectXY<T>(
            GameObject root,
            int width,
            int height,
            T prefab,
            Vector2 cellDimensions)
            where T : Component
        {
            var spaceMap = Map.Linear(Matrixf33.Scale(cellDimensions.To3DXY(1)));
            var center = new Vector2(width, height) / 2 - Vector2.one * 0.5f;
            spaceMap = spaceMap.PreTranslate(-center);

            var grid = Rect<T>(width, height);
            var roundMap = Map.RectRound();
            var map = new GridMap<GridPoint2>(spaceMap, roundMap);

            GridBuilderUtils.InitTileGrid(grid, map, prefab, root, (point, cell) => { });

            return new PhysicalGrid<GridPoint2, T>(grid, map, root);
        }

        #endregion
    }

    public class BuildingGrid : GridBehaviour<GridPoint2, SpriteCell>
    {
        public Color freeColor = Color.white;
        public Color buildingColor = Color.green;

        private IGrid<GridPoint2, bool> buildingGrid;

        public override void InitGrid()
        {
            buildingGrid = Grid.CloneStructure<GridPoint2, bool>(false);
            ResetGrid();
        }

        public void ResetGrid()
        {
            foreach (var point in Grid.Points)
            {
                buildingGrid[point] = false;
                var cell = Grid[point].GetComponent<SpriteCell>();
                cell.Color = freeColor;  // Инициализация всех клеток как свободных
            }
        }

        public void BuildAt(GridPoint2 point)
        {
            if (AllNeighborsAreFree(point))
            {
                buildingGrid[point] = true;  // Помечаем клетку как занятую
                var cell = Grid[point].GetComponent<SpriteCell>();
                cell.Color = buildingColor;  // Изменяем цвет клетки для отображения здания
            }
        }

        private bool AllNeighborsAreFree(GridPoint2 centerPoint)
        {
            foreach (var point in centerPoint.GetVectorNeighbors(PointyHexPoint.Directions).In(Grid))
            {
                if (buildingGrid[point])
                {
                    return false;  // Если хотя бы одна соседняя клетка занята, возвращаем false
                }
            }
            return true;  // Все клетки вокруг свободны
        }

        private void ToggleCellAt(GridPoint2 centerPoint)
        {
            foreach (var point in centerPoint.GetVectorNeighbors(PointyHexPoint.Directions).In(Grid))
            {
                var cell = Grid[point].GetComponent<SpriteCell>();

                buildingGrid[point] = !buildingGrid[point];
                cell.Color = buildingGrid[point] ? buildingColor : freeColor;
            }
        }
    }
}
*/