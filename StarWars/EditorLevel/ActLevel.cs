using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.EditorLevel
{
    public class ActLevel : IPaintForm
    {
        PaintEditor draw;
        MapStruct map;
        IForm mainForm;
        public ActLevel(int wh, int ht, Editor form)
        {
            draw = new PaintEditor(wh, ht);
            map = new MapStruct();
            mainForm = form;
        }
        public Bitmap GetGrid()
        {
            return draw.DrawGrid();
        }
        public Bitmap GetPicture(bool grid)
        {
            if (!grid)
            {
                return draw.MainBT;
            }
            else
            {
                return draw.GetMainBT(grid);
            }
        }
        public Bitmap AddObject(mapObject obj, Point location, bool grid)
        {
            if (map.MapObject[location.X, location.Y] == mapObject.None)
            {
                return draw.DrawObject(obj, location, map.MapObject, grid);
            }
            else
            {
                return draw.GetMainBT(grid);
            }
        }
        public void SaveTheMap()
        {
            SaveMap sm = new SaveMap(map.MapObject);
            sm.ShowDialog();
        }
        public void MouseClick(object sender, System.Windows.Forms.MouseEventArgs e, mapObject obj, bool grid)
        {
            var location = new Point(e.Location.X / MapStruct.BlockSize, e.Location.Y / MapStruct.BlockSize);
            if (location.X < 21 && location.Y < 14)
            {
                mainForm.Invalidate(AddObject(obj, location, grid));
            }
        }
        public void MouseMove(object sender, System.Windows.Forms.MouseEventArgs e, mapObject obj, bool grid)
        {
            //var location = new Point(e.Location.X / MapStruct.BlockSize, e.Location.Y / MapStruct.BlockSize);
            //if (location.X < 21 && location.Y < 14)
            //{
            //    mainForm.Invalidate(draw.TempObj2(obj, location, map.MapObject, grid));
            //}
        }
    }
}