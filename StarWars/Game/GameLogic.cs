using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    class GameLogic
    {
        public Civilization You { get; set; }
        Civilization enemy;
        Dictionary<Point, Planet> planets;
        public GameLogic(mapObject[,] map)
        {
            You = new Civilization();
            enemy = new Civilization();
            planets = new Dictionary<Point, Planet>();
            InitPlanets(map);
        }
        void InitPlanets(mapObject[,] map)
        {
            List<string> temp = new List<string> { "Ферос", "Иден Прайм", "Мавигон", "Тучанка","Палавен","Сур'Кеш","Сильва","Солярис","Сион","Велес","Элата"};
            int indexName = 0;
            Random r = new Random();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i,j] == mapObject.Planet)
                        planets.Add(new Point(i, j), new Planet(new Point(i, j), temp[indexName++], r.Next(2, 7), r.Next(3, 6), r.Next(6,12), r.Next(50, 400)));
                }
            }
        }
        public void ChangeCivOnPlanet(Point loc, nameCiv civ)
        {
            if (civ == nameCiv.You)
            {
                planets[loc].ChangeCiv(You);
                You.planets.Add(planets[loc]);
            }
            else
            {
                planets[loc].ChangeCiv(enemy);
                enemy.planets.Add(planets[loc]);
            }
        }
        public void ShowBuildForm(Point loc)
        {
            if (planets.ContainsKey(loc))
            {
                planets[loc].BuildObj();
            }
        }
        public void EndTurn(mapObject[,] map)
        {
            You.BuildShip(map); // строим корабли
            You.CollectResources(); // сбор ресурсов
        }
    }
}
