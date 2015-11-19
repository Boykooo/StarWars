using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class Planet : Resources
    {
        string name;
        Point location;
        Civilization civ;
        CreateObject createObj;
        public Planet (Point location, string name, int food, int titanium, int iridium, int gold)
        {
            Food = food;
            Titanium = titanium;
            Iridium = iridium;
            Gold = gold;
            this.name = name;
            this.location = location;
        }
        public void ChangeCiv(Civilization civ)
        {
            this.civ = civ;
            createObj = new CreateObject(name, Food, Titanium, Iridium, Gold);
        }
        public void BuildObj()
        {
            createObj.Res = civ;
            createObj.ShowDialog();
            civ.Food = createObj.Res.Food;
            civ.Titanium = createObj.Res.Titanium;
            civ.Iridium = createObj.Res.Iridium;
            civ.Gold = createObj.Res.Gold;
        }
    }
}
