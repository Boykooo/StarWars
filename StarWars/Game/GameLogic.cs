using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class GameLogic
    {
        public Civilization You { get; set; }
        private Civilization enemy;
        private Dictionary<Point, Planet> planets;
        private Enemy turnEnemy;
        public GameLogic(mapObject[,] map)
        {
            You = new Civilization();
            enemy = new Civilization();
            planets = new Dictionary<Point, Planet>();
            turnEnemy = new Enemy();
            InitPlanets(map);
        }
        private void InitPlanets(mapObject[,] map)
        {
            List<string> temp = new List<string> { "Ферос", "Иден Прайм", "Мавигон", "Тучанка", "Палавен", "Сур'Кеш", "Сильва", "Солярис", "Сион", "Велес", "Элата" };
            int indexName = 0;
            Random r = new Random();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == mapObject.Planet)
                        planets.Add(new Point(i, j), new Planet(new Point(i, j), temp[indexName++], r.Next(2, 7), r.Next(2, 4), r.Next(1, 5), r.Next(50, 100)));
                }
            }
        }
        public void ChangeCivOnPlanet(Point locPlanet, nameCiv civ, IActForm act, mapObject[,] map, Point ship)
        {
            if (civ == nameCiv.You)
            {
                planets[locPlanet].ChangeCiv(You, act);
                You.AddPlanet(planets[locPlanet]);
                map[locPlanet.X, locPlanet.Y] = mapObject.PlanetYou;
                if (ship.X != -1)
                {
                    You.DeleteShip(ship);
                    map[ship.X, ship.Y] = mapObject.None;
                }
            }
            else
            {
                planets[locPlanet].ChangeCiv(enemy);
                enemy.AddPlanet(planets[locPlanet]);
                map[locPlanet.X, locPlanet.Y] = mapObject.PlanetEnemy;
                if (ship.X != -1)
                {
                    enemy.DeleteShip(ship);
                    map[ship.X, ship.Y] = mapObject.None;
                }
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
            turnEnemy.Kill(enemy, map, You.Ships);
            turnEnemy.Turn(enemy, map);
            You.EndTurn(map);
        }
        public void MoveShip(Point old, Point now)
        {
            You.MoveShip(old, now);
        }
        public void SelectEnemyCapital(Point locPlanet, nameCiv civ, IActForm act, mapObject[,] map, Point ship)
        {
            foreach (var p in planets.Keys)
            {
                if (planets[p].civ == null)
                {
                    planets[p].ChangeCiv(enemy);
                    enemy.AddPlanet(planets[p]);
                    ChangeCivOnPlanet(new Point(p.X, p.Y), nameCiv.Enemy, act, map, ship);
                    break;
                }
            }
        }
        public void KillEnemyShip(Point ship)
        {
            if (enemy.Ships.ContainsKey(ship))
            {
                enemy.Ships.Remove(ship);
            }
        }
    }
}
