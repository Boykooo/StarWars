using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class PaintGame
    {
        public Bitmap MainBt { get; set; }
        public bool MovingShip { get; set; }
        private Pen penGreen;
        private Pen penEnemy;
        private Pen penYou;
        private Pen penChest;
        private Bitmap tempBt;
        private Image planetPicture;
        private Image ChestPicture;
        private Image AsteroidPicture;
        private Image DestroyerPicture;
        private Image ColonistPicture;
        private Image back;
        private List<Point> availableArea;
        public PaintGame(int wh, int ht)
        {
            penGreen = new Pen(Color.Green, 1.5f);
            penEnemy = new Pen(Color.Red, 1.5f);
            penYou = new Pen(Color.Purple, 3f);
            penChest = new Pen(Color.Yellow, 1.5f);
            MainBt = new Bitmap(wh, ht);
            tempBt = new Bitmap(wh, ht);
            InitPicture();
        }
        private void InitPicture()
        {
            planetPicture = Image.FromFile(@"Images/PlanetIcon.png");
            ChestPicture = Image.FromFile(@"Images/Chest.png");
            AsteroidPicture = Image.FromFile(@"Images/Asteroid.png");
            back = Image.FromFile(@"Images/Back.jpeg");
            DestroyerPicture = Image.FromFile(@"Images/Destroyer.png");
            ColonistPicture = Image.FromFile(@"Images/Colonist.png");
        }
        private void DrawGrid(Bitmap bt)
        {
            using (Graphics gr = Graphics.FromImage(bt))
            {
                for (int i = 0; i < 840; i += 40)
                {
                    for (int j = 0; j < 560; j += 40)
                    {
                        gr.DrawRectangle(Pens.Black, i, j + MapStruct.Shift, 40, 40);
                    }
                }
            }
        }
        public Bitmap GetMap(mapObject[,] map)
        {
            using (Graphics g = Graphics.FromImage(MainBt))
            {
                g.Clear(Color.Black);
                g.DrawImage(back, new Point(0, 0));
                //DrawGrid(MainBt);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        switch (map[i, j])
                        {
                            case mapObject.Asteroid:
                                g.DrawImage(AsteroidPicture, new Point(i * MapStruct.BlockSize + 5, j * MapStruct.BlockSize + MapStruct.Shift + 5));
                                break;
                            case mapObject.Planet:
                                g.DrawImage(planetPicture, new Point(i * MapStruct.BlockSize + 2, j * MapStruct.BlockSize + MapStruct.Shift + 2));
                                break;
                            case mapObject.Chest:
                                g.DrawImage(ChestPicture, new Point(i * MapStruct.BlockSize + 2, j * MapStruct.BlockSize + MapStruct.Shift + 2));
                                break;
                            case mapObject.PlanetYou:
                                g.DrawRectangle(penYou, i * MapStruct.BlockSize, j * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                                g.DrawImage(planetPicture, new Point(i * MapStruct.BlockSize + 2, j * MapStruct.BlockSize + MapStruct.Shift + 2));
                                break;
                            case mapObject.PlanetEnemy:
                                g.DrawRectangle(penEnemy, i * MapStruct.BlockSize, j * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                                g.DrawImage(planetPicture, new Point(i * MapStruct.BlockSize + 2, j * MapStruct.BlockSize + MapStruct.Shift + 2));
                                break;
                            case mapObject.DestroyerYou:
                                g.DrawRectangle(new Pen(Color.Purple, 1.5f), i * MapStruct.BlockSize, j * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                                g.DrawImage(DestroyerPicture, new Point(i * MapStruct.BlockSize + 4, j * MapStruct.BlockSize + MapStruct.Shift + 4));
                                break;
                            case mapObject.ColonistYou:
                                g.DrawRectangle(new Pen(Color.Purple, 1.5f), i * MapStruct.BlockSize, j * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                                g.DrawImage(ColonistPicture, new Point(i * MapStruct.BlockSize + 4, j * MapStruct.BlockSize + MapStruct.Shift + 4));
                                break;
                            default:
                                break;
                        }
                    }
                }
                return MainBt;
            }
        }
        public Bitmap GetShipRegion(mapObject[,] map, Point location)
        {
            using (Graphics g = Graphics.FromImage(tempBt))
            {
                g.Clear(Color.White);
                g.DrawImage(MainBt, new Point(0, 0));

                List<Point> temp = GetAvailableArea(map, location);

                // Пусто
                foreach (var p in temp)
                {
                    if (map[p.X, p.Y] == mapObject.None)
                        g.DrawRectangle(penGreen, p.X * MapStruct.BlockSize, p.Y * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                }
                // Враг
                foreach (var p in temp)
                {
                    if (map[p.X, p.Y] == mapObject.DestroyerEnemy)
                        g.DrawRectangle(penEnemy, p.X * MapStruct.BlockSize, p.Y * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                    if (map[p.X, p.Y] == mapObject.ColonistEnemy)
                        g.DrawRectangle(penEnemy, p.X * MapStruct.BlockSize, p.Y * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                }
                // область самого корабля
                g.DrawRectangle(new Pen(Color.Purple, 1.0f), location.X * MapStruct.BlockSize, location.Y * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                // Сундук
                foreach (var p in temp)
                {
                    if (map[p.X, p.Y] == mapObject.Chest)
                        g.DrawRectangle(new Pen(Color.Yellow, 1.8f), p.X * MapStruct.BlockSize, p.Y * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                }
                return tempBt;
            }
        }
        private List<Point> GetAvailableArea(mapObject[,] map, Point location)
        {
            Point[] reg = new Point[]
                {
                    new Point(location.X, location.Y-1),
                    new Point(location.X+1, location.Y),
                    new Point(location.X+1, location.Y+1),
                    new Point(location.X+1, location.Y-1),
                    new Point(location.X-1, location.Y),
                    new Point(location.X-1, location.Y+1),
                    new Point(location.X-1, location.Y-1),
                    new Point(location.X, location.Y+1),
                };
            availableArea = new List<Point>();
            foreach (var i in reg)
            {
                try
                {
                    if (map[i.X, i.Y] != mapObject.Asteroid)
                        availableArea.Add(i);
                }
                catch { }
            }
            return availableArea;
        }
        void DrawRegionObj(Graphics g, Pen pen, Point[] reg, mapObject Obj, mapObject[,] map)
        {
            // Пусто
            foreach (var p in reg)
            {
                try
                {
                    if (map[p.X, p.Y] == Obj)
                        g.DrawRectangle(pen, p.X * MapStruct.BlockSize, p.Y * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                }
                catch { }
            }
        }
        public Bitmap MoveShip(mapObject[,] map, Point start, Point end)
        {
            if (availableArea.Contains(end))
            {
                map[end.X, end.Y] = map[start.X, start.Y];
                map[start.X, start.Y] = mapObject.None;
                MovingShip = true;
                return GetMap(map);
            }
            else
            {
                MovingShip = false;
                return MainBt;
            }
        }
    }
}
