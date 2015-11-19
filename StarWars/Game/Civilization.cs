using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class Civilization : Resources
    {
        List<Ship> ships;
        List<Planet> planets;
        public Civilization()
        {
            Food = 5;
            Titanium = 20;
            Iridium = 6;
            Gold = 410;
        }
    }
}
