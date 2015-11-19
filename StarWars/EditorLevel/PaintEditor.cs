using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.EditorLevel;

namespace StarWars.EditorLevel
{
    public class PaintEditor
    {
        public static Image planetPicture { get; set; }
        public static Image ChestPicture { get; set; }
        public static Image AsteroidPicture { get; set; }

        public Bitmap MainBT { get; set; }
        public Bitmap TempBT { get; set; }
        private Bitmap gridBT;

        Graphics g;
        int wh, ht;
        public PaintEditor(int wh, int ht)
        {
            this.wh = wh;
            this.ht = ht;
            LoadImage();
            gridBT = new Bitmap(wh,ht);
            using (Graphics gr = Graphics.FromImage(gridBT))
            {
                for (int i = 0; i < 840; i += 40)
                {
                    for (int j = 0; j < 560; j += 40)
                    {
                        gr.DrawRectangle(Pens.Black, i, j, 40, 40);
                    }
                }
            }
            TempBT = new Bitmap(wh, ht);
            MainBT = new Bitmap(wh, ht);
        }
        public static void LoadImage()
        {
            planetPicture = Image.FromFile(@"Images/PlanetIcon.png");
            ChestPicture = Image.FromFile(@"Images/Chest.png");
            AsteroidPicture = Image.FromFile(@"Images/Asteroid.png");
        }
        public Bitmap DrawGrid()
        {
            return gridBT;
        }
        public Bitmap GetMainBT(bool grid)
        {
            if (!grid)
                return MainBT;
            else
            {
                using (g = Graphics.FromImage(TempBT))
                {
                    g.Clear(Color.White);
                    g.DrawImage(MainBT, new Point(0, 0));
                    g.DrawImage(gridBT, new Point(0, 0));
                }
                return TempBT;
            }
        }
        public Bitmap TempObj2(mapObject obj, Point location, mapObject[,] Map, bool grid)
        {
            using (g = Graphics.FromImage(TempBT))
            {
                g.Clear(Color.White);
                g.DrawImage(MainBT, new Point(0,0));
                if (grid)
                    g.DrawImage(gridBT, new Point(0, 0));

                switch (obj)
                {
                    case mapObject.Planet:
                        if (Check.CheckLocation(location, Map))
                        {
                            g.DrawImage(planetPicture, new Point(location.X * MapStruct.BlockSize + 2, location.Y * MapStruct.BlockSize + 2));
                        }
                        break;
                    case mapObject.Chest:
                        g.DrawImage(ChestPicture, new Point(location.X * MapStruct.BlockSize + 2, location.Y * MapStruct.BlockSize + 2));
                        break;
                    case mapObject.Asteroid:
                        g.DrawImage(AsteroidPicture, new Point(location.X * MapStruct.BlockSize + 5, location.Y * MapStruct.BlockSize + 5));
                        break;
                }
            }
            return TempBT;
        }
        public Bitmap DrawObject(mapObject obj, Point location, mapObject[,] Map, bool grid)
        {
            using (g = Graphics.FromImage(TempBT))
            {
                g.Clear(Color.White);
                g.DrawImage(MainBT, new Point(0, 0));
                switch (obj)
                {
                    case mapObject.Planet:
                        if (Check.CheckLocation(location, Map))
                        {
                            g.DrawImage(planetPicture, new Point(location.X * MapStruct.BlockSize + 2, location.Y * MapStruct.BlockSize + 2));
                            Map[location.X, location.Y] = obj;
                        }
                        break;
                    case mapObject.Chest:
                        g.DrawImage(ChestPicture, new Point(location.X * MapStruct.BlockSize + 2, location.Y * MapStruct.BlockSize + 2));
                        Map[location.X, location.Y] = obj;
                        break;
                    case mapObject.Asteroid:
                        g.DrawImage(AsteroidPicture, new Point(location.X * MapStruct.BlockSize + 5, location.Y * MapStruct.BlockSize + 5));
                        Map[location.X, location.Y] = obj;
                        break;
                }
                MainBT.Dispose();
                MainBT = new Bitmap(TempBT);
                if (grid)
                    g.DrawImage(gridBT, new Point(0, 0));
            }
            return TempBT;
        }
    }
}
