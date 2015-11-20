using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StarWars.Game;

namespace StarWars
{
    public enum mapObject { None, Planet, Chest, Asteroid, PlanetYou, PlanetEnemy, ColonistYou, ColonistEnemy, DestroyerYou, DestroyerEnemy }
    public enum nameCiv { You, Enemy }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
