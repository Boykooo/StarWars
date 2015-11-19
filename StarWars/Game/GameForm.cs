using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StarWars.Game
{
    public partial class GameForm : Form, IForm
    {
        IActForm act;
        Graphics g;
        public Size sizeForm { get; set; }
        public GameForm()
        {
            InitializeComponent();
        }
        private void NewGameForm_Load(object sender, EventArgs e)
        {
            sizeForm = new Size(ClientSize.Width, ClientSize.Height);
            g = CreateGraphics();
            act = new ActGameForm(this);
            BackgroundImage = act.GetDefaultMap();
            InitImage();
        }
        void InitImage()
        {
            IridiumBox.Image = Image.FromFile(@"Images/Iridium.png");
            TitaniumBox.Image = Image.FromFile(@"Images/Titanium.png");
            GoldBox.Image = Image.FromFile(@"Images/Gold.png");
            FoodBox.Image = Image.FromFile(@"Images/Food.png");
        }
        public void Invalidate(Bitmap bt)
        {
            g.DrawImage(bt, ClientRectangle);
        }
        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            act.MouseClick(sender, e);
        }
        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            act.MouseMove(sender, e);
        }
        private void EndTurn_Click(object sender, EventArgs e)
        {

        }
        private void GameForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            act.MouseDoubleClick(sender, e);
        }
        public void ChangeResources(int food, int titanium, int iridium, int gold)
        {
            FoodLabel.Text = food.ToString();
            TitaniumLabel.Text = titanium.ToString();
            IridiumLabel.Text = iridium.ToString();
            GoldLabel.Text = gold.ToString();
        }
    }
}
