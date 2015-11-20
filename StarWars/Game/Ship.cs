using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    class Ship 
    {
        public static Point SearchFreePlace(mapObject[,] map, Point planet)
        {
            Point[] tmp = new Point[]
            {
                planet,
                new Point(planet.X, planet.Y-1),
                new Point(planet.X+1, planet.Y),
                new Point(planet.X+1, planet.Y+1),
                new Point(planet.X+1, planet.Y-1),
                new Point(planet.X-1, planet.Y),
                new Point(planet.X-1, planet.Y+1),
                new Point(planet.X-1, planet.Y-1),
                new Point(planet.X, planet.Y+1),
            };
            foreach (var p in tmp)
            {
                try
                {
                    if (map[p.X, p.Y] == mapObject.None)
                        return p;
                }
                catch { }
            }
            return tmp[0];
        }
        public static void NewShip(mapObject[,] map, Planet p)
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
        }
    }
}
