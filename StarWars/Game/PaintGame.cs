using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class PaintGame
    {
        Pen penGreen;
        Pen penEnemy;
        Pen penYou;
        Bitmap MainBt;
        Bitmap tempBt;
        Image planetPicture;
        Image ChestPicture;
        Image AsteroidPicture;
        Image back;
        public PaintGame(int wh, int ht)
        {
            penGreen = new Pen(Color.Green, 1.5f);
            penEnemy = new Pen(Color.Red, 1.5f);
            penYou = new Pen(Color.Purple, 3f);
            MainBt = new Bitmap(wh, ht);
            tempBt = new Bitmap(wh, ht);
            InitPicture();
        }
        void InitPicture()
        {
            planetPicture = Image.FromFile(@"Images/PlanetIcon.png");
            ChestPicture = Image.FromFile(@"Images/Chest.png");
            AsteroidPicture = Image.FromFile(@"Images/Asteroid.png");
            back = Image.FromFile(@"Images/Back.jpeg");
        }
        void DrawGrid(Bitmap bt)
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
                g.DrawImage(back, new Point(0,0));
                //DrawGrid(MainBt);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        switch(map[i,j])
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
                g.DrawImage(MainBt, new Point(0,0));
                Point[] reg = new Point[]
                {
                    location,
                    new Point(location.X, location.Y-1),
                    new Point(location.X+1, location.Y),
                    new Point(location.X+1, location.Y+1),
                    new Point(location.X+1, location.Y-1),
                    new Point(location.X-1, location.Y),
                    new Point(location.X-1, location.Y+1),
                    new Point(location.X-1, location.Y-1),
                    new Point(location.X, location.Y+1),
                };
                for (int i = 0; i < reg.Length; i++)
                {
                    try
                    {
                        switch (map[reg[i].X, reg[i].Y])
                        {
                            case mapObject.Chest:
                                g.DrawRectangle(new Pen(Color.Yellow, 1.5f), reg[i].X * MapStruct.BlockSize, reg[i].Y * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                                break;
                            case mapObject.None:
                                g.DrawRectangle(penGreen, reg[i].X * MapStruct.BlockSize, reg[i].Y * MapStruct.BlockSize + MapStruct.Shift, MapStruct.BlockSize, MapStruct.BlockSize);
                                break;
                        }
                    }
                    catch { }
                }
                return tempBt;
            }
        }
    }
}
