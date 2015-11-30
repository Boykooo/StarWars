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
        public static Point SearchInArea(mapObject[,] map, Point planet, mapObject typeSearch)
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
                    if (map[p.X, p.Y] == typeSearch)
                        return p;
                }
                catch { }
            }
            return tmp[0];
        }
        public static Point[] GetFreeArea(mapObject[,] map, Point place)
        {
            List<Point> freeArea = new List<Point>();
            Point[] tmp = new Point[]
            {
                place,
                new Point(place.X, place.Y-1),
                new Point(place.X+1, place.Y),
                new Point(place.X+1, place.Y+1),
                new Point(place.X+1, place.Y-1),
                new Point(place.X-1, place.Y),
                new Point(place.X-1, place.Y+1),
                new Point(place.X-1, place.Y-1),
                new Point(place.X, place.Y+1),
            };
            foreach (var p in tmp)
            {
                try
                {
                    if (map[p.X, p.Y] == mapObject.None)
                        freeArea.Add(p);
                }
                catch { }
            }
            return freeArea.ToArray();
        }
    }
}
