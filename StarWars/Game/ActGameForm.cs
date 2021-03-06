﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace StarWars.Game
{
    public class ActGameForm : IActForm
    {
        private bool selectCapital, firstShip;
        private IForm form;
        private PaintGame draw;
        private MapStruct map;
        private GameLogic game;
        private Point pointShip;
        public ActGameForm(IForm formGame)
        {
            map = new MapStruct();
            map.InitMap();
            form = formGame;
            draw = new PaintGame(form.sizeForm.Width, form.sizeForm.Height);
            selectCapital = firstShip = true;
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
                if (e.Button == MouseButtons.Left)
                {
                    if (selectCapital)
                    {
                        SelectCapitalPlanet(location);
                        form.Status("Постройте первый корабль!");
                        game.SelectEnemyCapital(location, nameCiv.You, this, map.MapObject, new Point(-1, -1));
                    }
                    else
                    {
                        if ((map.MapObject[location.X, location.Y] == mapObject.DestroyerYou || map.MapObject[location.X, location.Y] == mapObject.ColonistYou) && game.You.Ships.ContainsKey(location) && !game.You.Ships[location].Turn)
                        {
                            form.Invalidate(draw.GetShipRegion(map.MapObject, location, map.MapObject[location.X, location.Y] == mapObject.ColonistYou));
                            pointShip = location;
                        }
                        else
                        {
                            form.Invalidate(draw.MainBt);
                        }
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (game.You.Ships.ContainsKey(pointShip) && !game.You.Ships[pointShip].Turn)
                    {
                        game.MoveShip(pointShip, location, map.MapObject, form, draw, this);
                        if (game.You.Ships.Keys.Contains(pointShip))
                        {
                            game.You.Ships[pointShip].Turn = draw.MovingShip;
                            if (draw.MovingShip)
                            {
                                game.MoveShip(pointShip, location);
                            }
                        }
                    }
                }
            }
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {

        }
        public void MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var location = new Point(e.X / MapStruct.BlockSize, (e.Y - MapStruct.Shift) / MapStruct.BlockSize);
            if (map.MapObject[location.X, location.Y] == mapObject.PlanetYou)
            {
                game.ShowBuildForm(location);
                if (firstShip)
                    form.Status("Завоюйте галактику!");
            }
        }
        public void EndTurn()
        {
            if (game.CheckDefeat())
            {
                form.Status("Вы проиграли!");
            }
            else if (game.CheckWin())
            {
                form.Status("Вы победили!");
            }
            else
            {
                game.EndTurn(map.MapObject);
                form.Invalidate(draw.GetMap(map.MapObject));
                form.ChangeResources(game.You.Food, game.You.Titanium, game.You.Iridium, game.You.Gold);
            }
        }
        public void ReResources(int food, int titanium, int iridium, int gold)
        {
            form.ChangeResources(food, titanium, iridium, gold);
        }
        private void SelectCapitalPlanet(Point location)
        {
            if (map.MapObject[location.X, location.Y] == mapObject.Planet)
            {
                game.ChangeCivOnPlanet(location, nameCiv.You, this, map.MapObject, new Point(-1,-1));
                map.MapObject[location.X, location.Y] = mapObject.PlanetYou;
                selectCapital = false;
                form.Invalidate(draw.GetMap(map.MapObject));
            }
        }
        private void SelectEnemyPlanet(Point location)
        {
            game.ChangeCivOnPlanet(location, nameCiv.Enemy, this, map.MapObject, new Point(-1, -1));
            map.MapObject[location.X, location.Y] = mapObject.PlanetEnemy;
            form.Invalidate(draw.GetMap(map.MapObject));
        }
    }
}
