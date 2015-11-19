﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace StarWars.Game
{
    class ActGameForm : IActForm
    {
        bool selectCapital;
        IForm form;
        PaintGame draw;
        MapStruct map;
        GameLogic game;
        public ActGameForm(IForm formGame)
        {
            map = new MapStruct();
            map.InitMap();
            form = formGame;
            draw = new PaintGame(form.sizeForm.Width, form.sizeForm.Height);
            selectCapital = true;
            game = new GameLogic(map.MapObject);
        }
        public Bitmap GetDefaultMap()
        {
            return draw.GetMap(map.MapObject);
        }
        public void MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var location = new Point(e.X / MapStruct.BlockSize, (e.Y - MapStruct.Shift) / MapStruct.BlockSize);
            if (location.X < map.MapObject.GetLength(0) && location.Y < map.MapObject.GetLength(1))
            {
                if (selectCapital)
                {
                    SelectCapitalPlanet(location);
                }
                else
                {
                    if (map.MapObject[location.X, location.Y] == mapObject.Ship)
                    {

                    }
                }
            }
        }
        void SelectCapitalPlanet(Point location)
        {
            if (map.MapObject[location.X, location.Y] == mapObject.Planet)
            {
                game.ChangeCivOnPlanet(location, nameCiv.You);
                map.MapObject[location.X, location.Y] = mapObject.PlanetYou;
                selectCapital = false;
                form.Invalidate(draw.GetMap(map.MapObject));
            }
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        public void MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var location = new Point(e.X / MapStruct.BlockSize, (e.Y - MapStruct.Shift) / MapStruct.BlockSize);
            if (map.MapObject[location.X, location.Y] == mapObject.PlanetYou)
                game.ShowBuildForm(location);
        }
    }
}