using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars.EditorLevel
{
    public partial class Editor : Form, IForm
    {
        Graphics g;
        IPaintForm act;
        public Editor()
        {
            InitializeComponent();
            act = new ActLevel(pictureBox1.Width, pictureBox1.Height, this);
            PlanetRadioButton.Image = PaintEditor.planetPicture;
            RubishRadioButton.Image = PaintEditor.ChestPicture;
            AsteroidRadioButton.Image = PaintEditor.AsteroidPicture;
            pictureBox1.Image = act.GetGrid();
        }
        private void EditorLevelForm_Load(object sender, EventArgs e)
        {
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (PlanetRadioButton.Checked)
                {
                    act.MouseClick(sender, e, mapObject.Planet, GridCheck.Checked);
                }
                if (RubishRadioButton.Checked)
                {
                    act.MouseClick(sender, e, mapObject.Chest, GridCheck.Checked);
                }
                if (AsteroidRadioButton.Checked)
                {
                    act.MouseClick(sender, e, mapObject.Asteroid, GridCheck.Checked);
                }
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }
        private void сохранитьКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            act.SaveTheMap();
            this.Close();
        }
        public void Invalidate(Bitmap bt)
        {
            pictureBox1.Image = bt;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
                //if (PlanetRadioButton.Checked)
                //{
                //    act.MouseMove(sender, e, mapObject.Planet, GridCheck.Checked);
                //}
                //if (RubishRadioButton.Checked)
                //{
                //    act.MouseMove(sender, e, mapObject.Rubbish, GridCheck.Checked);
                //}
                //if (AsteroidRadioButton.Checked)
                //{
                //    act.MouseMove(sender, e, mapObject.Asteroid, GridCheck.Checked);
                //}
        }

        private void GridCheck_CheckStateChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = act.GetPicture(GridCheck.Checked);
        }

        public Size sizeForm { get; set; }


        public void ChangeResources(int food, int titanium, int iridium, int gold)
        {
            throw new NotImplementedException();
        }
    }
}
