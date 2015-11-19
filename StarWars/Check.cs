using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using StarWars.EditorLevel;

namespace StarWars
{
    class Check
    {
        //public static bool CheckLocation(Point location, int[,] Map)
        //{
        //    bool before = ((location.Y == 0 || location.X == 0) || location.Y - 1 >= 0 && location.X - 1 >= 0 && Map[location.X - 1, location.Y - 1] == 0) 
        //        && (location.X == 0 || location.X - 1 >= 0 && Map[location.X - 1, location.Y] == 0)
        //        && ((location.X == 0 || location.Y == Map.GetLength(1) || location.Y + 1 < Map.GetLength(1))  && location.X - 1 >= 0 && Map[location.X - 1, location.Y + 1] == 0);
        //    bool middle = (location.Y == 0 || location.Y - 1 >= 0 && Map[location.X, location.Y - 1] == 0)
        //        && (location.Y == 9 || location.Y + 1 < Map.GetLength(1) && Map[location.X, location.Y + 1] == 0);
        //    bool after = ((location.Y == 0 || location.X == Map.GetLength(0) - 1) || location.Y - 1 >= 0 && location.X + 1 < Map.GetLength(0) && Map[location.X + 1, location.Y - 1] == 0)
        //        && (location.X == Map.GetLength(0) - 1 || location.X + 1 < Map.GetLength(0) && Map[location.X + 1, location.Y] == 0)
        //        && ((location.X == Map.GetLength(0) - 1 || location.Y == Map.GetLength(1) - 1) || location.Y + 1 < Map.GetLength(1) && location.X + 1 < Map.GetLength(0) && Map[location.X + 1, location.Y + 1] == 0);
        //    return before && middle && after;
        //}

        public static bool CheckLocation(Point location, mapObject[,] MapObj)
        {
            Point[] tmp = new Point[]
            {
                location,
                new Point(location.X, location.Y-1),
                new Point(location.X+1, location.Y),
                new Point(location.X+1, location.Y+1),
                new Point(location.X+1, location.Y-1),
                new Point(location.X-1, location.Y),
                new Point(location.X-1, location.Y+1),
                new Point(location.X-1, location.Y-1),
                new Point(location.X, location.Y + 1),
            };
            bool res = true;
            foreach (var p in tmp)
            {
                try
                {
                    res = res && (MapObj[p.X, p.Y] == mapObject.None);
                }
                catch
                {

                }
            }
            return res;
        }
    }
}
