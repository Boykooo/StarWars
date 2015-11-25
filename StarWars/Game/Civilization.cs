using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class Civilization : Resources
    {
        public List<Planet> Planets { get; set; }
        public Dictionary<Point, Ship> Ships { get; set; }
        public Civilization()
        {
            Food = 15;
            Titanium = 20;
            Iridium = 20;
            Gold = 500;
            Planets = new List<Planet>();
            Ships = new Dictionary<Point, Ship>();
        }
        public void CollectResources()
        {
            foreach(var p in Planets)
            {
                Food += p.Food;
                Titanium += p.Titanium;
                Iridium += p.Iridium;
                Gold += p.Gold;
            }
        }
        public void BuildShip(mapObject[,] map)
        {
            foreach(var p in Planets)
            {
                if (p.createObj.Pic[0].TypeShip != TypeShip.None)
                {
                    NewShip(map, p);
                    p.createObj.MovePictures(0, false); // сдвиг очереди постройки
                }
            }
        }
        public void NewShip(mapObject[,] map, Planet p)
        {
            Point newShip = Ship.SearchFreePlace(map, p.Location);
            switch (p.createObj.Pic[0].TypeShip)
            {
                case TypeShip.Colonist:
                    map[newShip.X, newShip.Y] = mapObject.ColonistYou;
                    break;
                case TypeShip.Destroyer:
                    map[newShip.X, newShip.Y] = mapObject.DestroyerYou;
                    break;
            }
            Ships.Add(newShip, new Ship());
        }
        public void ClearTurnShips()
        {
            foreach (var item in Ships.Values)
            {
                item.Turn = false;
            }
        }
        public void MoveShip(Point old, Point now)
        {
            Ships.Add(now, Ships[old]);
            Ships.Remove(old);
        }
        public void AddPlanet(Planet planet)
        {
            Planets.Add(planet);
        }
        public void DeleteShip(Point loc)
        {
            if (Ships.Keys.Contains(loc))
                Ships.Remove(loc);
        }
        public void EndTurn(mapObject[,] map)
        {
            BuildShip(map); // строим корабли
            ClearTurnShips(); // Даем корабликам ходить снова
            CollectResources(); // сбор ресурсов
        }
    }
}
