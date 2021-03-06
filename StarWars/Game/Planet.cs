﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StarWars.Game
{
    public class Planet : Resources
    {
        public Point Location { get; set; }
        public Civilization civ { get; set; }
        private string name;
        public CreateObject createObj { get; set; }
        public Planet (Point location, string name, int food, int titanium, int iridium, int gold)
        {
            Food = food;
            Titanium = titanium;
            Iridium = iridium;
            Gold = gold;
            this.name = name;
            this.Location = location;
        }
        public void ChangeCiv(Civilization civ, IActForm act)
        {
            this.civ = civ;
            createObj = new CreateObject(name, Food, Titanium, Iridium, Gold, act);
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
        public void ChangeCiv(Civilization civ)
        {
            this.civ = civ;
            createObj = new CreateObject(name, Food, Titanium, Iridium, Gold);
        }
        public void BuildShip()
        {

        }
    }
}
