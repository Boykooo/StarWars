using System;
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
        private Random r;
        public ActGameForm(IForm formGame)
        {
            map = new MapStruct();
            map.InitMap();
            form = formGame;
            draw = new PaintGame(form.sizeForm.Width, form.sizeForm.Height);
            selectCapital = firstShip = true;
            game = new GameLogic(map.MapObject);
            r = new Random();
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
                        MoveShip(pointShip, location);
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
            form.Status("");
            game.EndTurn(map.MapObject);
            form.Invalidate(draw.GetMap(map.MapObject));
            form.ChangeResources(game.You.Food, game.You.Titanium, game.You.Iridium, game.You.Gold);
        }
        public void ReResources(int food, int titanium, int iridium, int gold)
        {
            form.ChangeResources(food, titanium, iridium, gold);
        }
        public void MoveShip(Point start, Point end)
        {
            switch (map.MapObject[end.X, end.Y])
            {
                case mapObject.None:
                    form.Invalidate(draw.MoveShip(map.MapObject, start, end));
                    break;
                case mapObject.Chest:
                    form.Invalidate(draw.MoveShip(map.MapObject, start, end));
                    form.Status(RandomChest());
                    form.ChangeResources(game.You.Food, game.You.Titanium, game.You.Iridium, game.You.Gold);
                    break;
                case mapObject.Asteroid:
                    draw.MovingShip = false;
                    break;
                case mapObject.DestroyerEnemy:
                    if (map.MapObject[start.X, start.Y] == mapObject.DestroyerYou)
                    {
                        map.MapObject[end.X, end.Y] = mapObject.None;
                        game.KillEnemyShip(end);
                        form.Invalidate(draw.GetMap(map.MapObject));
                        draw.MovingShip = false;
                    }
                    break;
                case mapObject.ColonistEnemy:
                    break;
                case mapObject.PlanetYou:
                    draw.MovingShip = false;
                    break;
                case mapObject.PlanetEnemy:
                    draw.MovingShip = false;
                    break;
                case mapObject.Planet:
                    if (map.MapObject[start.X, start.Y] == mapObject.ColonistYou)
                    {
                        game.ChangeCivOnPlanet(end, nameCiv.You, this, map.MapObject, start);
                        form.Invalidate(draw.GetMap(map.MapObject));
                    }
                    break;
                default:
                    break;
            }
        }
        private string RandomChest()
        {
            int x = r.Next(1, 5);
            int bonus = r.Next(5, 16);
            string b = "";
            switch (x)
            {
                case 1:
                    b += "Еда + " + bonus;
                    game.You.Food += bonus;
                    break;
                case 2:
                    b += "Титан + " + bonus;
                    game.You.Titanium += bonus;
                    break;
                case 3:
                    b += "Иридий + " + bonus;
                    game.You.Iridium += bonus;
                    break;
                case 4:
                    bonus = r.Next(100, 300);
                    b += "Золото + " + bonus;
                    game.You.Gold += bonus;
                    break;
            }
            return b;
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
