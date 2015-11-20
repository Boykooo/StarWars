using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace StarWars
{
    public interface IActForm
    {
        void MouseClick(object sender, MouseEventArgs e);
        void MouseMove(object sender, MouseEventArgs e);
        void MouseDoubleClick(object sender, MouseEventArgs e);
        Bitmap GetDefaultMap();
        void EndTurn();
        void ReResources(int food, int titanium, int iridium, int gold);
    }
}
