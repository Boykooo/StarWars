using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StarWars.EditorLevel
{
    interface IPaintForm
    {
        void MouseClick(object sender, MouseEventArgs e, mapObject obj, bool grid);
        void MouseMove(object sender, MouseEventArgs e, mapObject obj, bool grid);
        Bitmap GetGrid();
        Bitmap GetPicture(bool grid);
        void SaveTheMap();
    }
}
