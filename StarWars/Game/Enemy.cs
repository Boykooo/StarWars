using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class Enemy
    {
        private Dictionary<Point, Ship> temp;
        private Random r;
        public Enemy()
        {
            r = new Random();
            temp = new Dictionary<Point, Ship>();
        }
        public void Turn(Civilization civ, mapObject[,] map)
        {
            civ.ClearTurnShips();
            civ.CollectResources();
            TurnShip(civ, map);
            Build(civ, map);
        }
        public void Kill(Civilization enemy, mapObject[,] map, Dictionary<Point, Ship> you)
        {
            foreach (var pointShip in enemy.Ships.Keys)
            {
                Point pointKill = Ship.SearchInArea(map, pointShip, mapObject.DestroyerYou);
                if (pointKill != pointShip)
                {
                    if (you.ContainsKey(pointKill))
                    {
                        you.Remove(pointKill);
                        map[pointKill.X, pointKill.Y] = mapObject.None;
                        enemy.Ships[pointShip].Turn = true;
                    }
                }
            }
        }
        private void Build(Civilization civ, mapObject[,] map)
        {
            while (civ.Titanium >= 8 && civ.Iridium >= 17 && civ.Gold >= 450)
            {
                Point planet = civ.Planets[r.Next(0, civ.Planets.Count - 1)].Location; // строим новый корабль на рандомной планете противники
                Point loc = Ship.SearchInArea(map, planet, mapObject.None);
                if (map[loc.X, loc.Y] == mapObject.None)
                {
                    civ.Ships.Add(loc, new Ship());
                    map[loc.X, loc.Y] = mapObject.DestroyerEnemy;
                    civ.Titanium -= 8;
                    civ.Iridium -= 17;
                    civ.Gold -= 450;
                }
                else
                    break;
            }
        }
        private void TurnShip(Civilization civ, mapObject[,] map)
        {
            temp.Clear();
            foreach (var shipCrd in civ.Ships.Keys)
            {
                Point[] freeArea = Ship.GetFreeArea(map, shipCrd);
                if (freeArea.Length != 0 && !civ.Ships[shipCrd].Turn)
                {
                    Point move = freeArea[r.Next(0, freeArea.Length - 1)];
                    map[shipCrd.X, shipCrd.Y] = mapObject.None;
                    map[move.X, move.Y] = mapObject.DestroyerEnemy;
                    temp.Add(move, civ.Ships[shipCrd]);
                    temp[move].Turn = true;

                }
            }
            civ.Ships = new Dictionary<Point, Ship>(temp);
        }
    }
}
