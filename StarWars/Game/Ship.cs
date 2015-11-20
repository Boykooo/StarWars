using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class Ship 
    {
        public bool Turn { get; set; }
        public Ship()
        {
            Turn = false;
        }
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
        
    }
}
