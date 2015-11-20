using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class Civilization : Resources
    {
        public List<Planet> planets { get; set; }
        public Civilization()
        {
            Food = 15;
            Titanium = 20;
            Iridium = 20;
            Gold = 500;
            planets = new List<Planet>();
        }
        public void CollectResources()
        {
            foreach(var p in planets)
            {
                Food += p.Food;
                Titanium += p.Titanium;
                Iridium += p.Iridium;
                Gold += p.Gold;
            }
        }
        public void BuildShip(mapObject[,] map)
        {
            foreach(var p in planets)
            {
                if (p.createObj.Pic[0].TypeShip != TypeShip.None)
                {
                    Ship.NewShip(map, p);
                    p.createObj.MovePictures(0);
                }
            }
        }
    }
}
