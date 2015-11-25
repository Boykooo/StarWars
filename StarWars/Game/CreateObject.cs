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
    public enum TypeShip { None, Destroyer, Colonist}
    public partial class CreateObject : Form
    {
        private int indexPic;
        private PictureBox colonist;
        private IActForm act;
        public List<BuildBox> Pic {get;set;}
        public Resources Res { get; set; }
        public CreateObject(string name, int food, int titan, int irid, int gold, IActForm act)
        {
            InitializeComponent();
            NamePlanet.Text = name;
            FoodLabel.Text = "Еда + " + food;
            TitaniumLabel.Text = "Титан + " + titan;
            IridiumLabel.Text = "Иридий + " + irid;
            GoldLabel.Text = "Золото + " + gold;
            Status.Text = "";
            Pic = new List<BuildBox> { new BuildBox(pictureBox2), new BuildBox(pictureBox3), new BuildBox(pictureBox4), new BuildBox(pictureBox5), new BuildBox(pictureBox6), new BuildBox(pictureBox7), new BuildBox(pictureBox8) };
            indexPic = 0;
            ColonistBox.Image = Image.FromFile(@"Images/Colonist60.png");
            DestroyerBox.Image = Image.FromFile(@"Images/Destroyer60.png");
            colonist = new PictureBox();
            colonist.Image = ColonistBox.Image;
            colonist.Size = ColonistBox.Size;
            this.act = act;
        }
        public CreateObject(string name, int food, int titan, int irid, int gold)
        {
            InitializeComponent();
            NamePlanet.Text = name;
            FoodLabel.Text = "Еда + " + food;
            TitaniumLabel.Text = "Титан + " + titan;
            IridiumLabel.Text = "Иридий + " + irid;
            GoldLabel.Text = "Золото + " + gold;
            Status.Text = "";
            Pic = new List<BuildBox> { new BuildBox(pictureBox2), new BuildBox(pictureBox3), new BuildBox(pictureBox4), new BuildBox(pictureBox5), new BuildBox(pictureBox6), new BuildBox(pictureBox7), new BuildBox(pictureBox8) };
            indexPic = 0;
            ColonistBox.Image = Image.FromFile(@"Images/Colonist60.png");
            DestroyerBox.Image = Image.FromFile(@"Images/Destroyer60.png");
            colonist = new PictureBox();
            colonist.Image = ColonistBox.Image;
            colonist.Size = ColonistBox.Size;
        }
        private void ColonistBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (indexPic < 7)
            {
                if (Res.Food >= 80 && Res.Titanium >= 20 && Res.Gold >= 1250)
                {
                    Pic[indexPic].pic.Image = ColonistBox.Image;
                    Pic[indexPic].TypeShip = TypeShip.Colonist;
                    indexPic++;
                    Res.Food -= 80;
                    Res.Titanium -= 20;
                    Res.Gold -= 1250;
                    Status.Text = "";
                    act.ReResources(Res.Food, Res.Titanium, Res.Iridium, Res.Gold);
                }
                else
                    Status.Text = "Недостаточно ресурсов!";
            }
        }
        private void CreateObject_Load(object sender, EventArgs e)
        {

        }
        private void DestroyerBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (indexPic < 7)
            {
                if (Res.Iridium >= 17 && Res.Titanium >= 8 && Res.Gold >= 450)
                {
                    Pic[indexPic].pic.Image = DestroyerBox.Image;
                    Pic[indexPic].TypeShip = TypeShip.Destroyer;
                    indexPic++;
                    Res.Iridium -= 17;
                    Res.Titanium -= 8;
                    Res.Gold -= 450;
                    Status.Text = "";
                    act.ReResources(Res.Food, Res.Titanium, Res.Iridium, Res.Gold);
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
                MovePictures(0, true);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
                MovePictures(1, true);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != null)
                MovePictures(2, true);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
                MovePictures(3, true);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != null)
                MovePictures(4, true);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image != null)
                MovePictures(5, true);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image != null)
            {
                Pic[Pic.Count - 1].pic.Image = null;
                Pic[Pic.Count - 1].TypeShip = TypeShip.None;
            }
        }
        public void MovePictures(int x, bool returnMoney)
        {
            bool ok = false;
            for (int i = x; x < Pic.Count - 1; i++)
            {
                if (i == x && returnMoney)
                {
                    ReturnMoney(Pic[i].TypeShip);
                }
                if (i != 6 && Pic[i + 1].pic.Image != null)
                {
                    Pic[i].pic.Image = Pic[i + 1].pic.Image;
                    Pic[i].TypeShip = Pic[i + 1].TypeShip;

                }
                else
                {
                    Pic[i].pic.Image = null;
                    Pic[i].TypeShip = TypeShip.None;
                    ok = true;
                    break;
                }
            }
            if (ok)
            {
                indexPic--;
            }
            act.ReResources(Res.Food, Res.Titanium, Res.Iridium, Res.Gold);
        }
        void ReturnMoney(TypeShip ship)
        {
            switch(ship)
            {
                case TypeShip.Colonist:
                    Res.Food += 80;
                    Res.Titanium += 20;
                    Res.Gold += 1250;
                    break;
                case TypeShip.Destroyer:
                    Res.Titanium += 8;
                    Res.Iridium += 17;
                    Res.Gold += 450;
                    break;
            }
        }
    }
    public class BuildBox
    {
        public PictureBox pic { get; set; }
        public TypeShip TypeShip { get; set; }
        public BuildBox(PictureBox pictureBox)
        {
            pic = pictureBox;
            TypeShip = Game.TypeShip.None;
        }
    }
}
