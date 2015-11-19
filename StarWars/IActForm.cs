using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace StarWars
{
    interface IActForm
    {
        void MouseClick(object sender, MouseEventArgs e);
        void MouseMove(object sender, MouseEventArgs e);
        void MouseDoubleClick(object sender, MouseEventArgs e);
        Bitmap GetDefaultMap();
        
    }
}
