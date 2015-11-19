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
    public partial class CreateObject : Form
    {
        int indexPic;
        PictureBox colonist;
        List<PictureBox> pic;
        public Resources Res { get; set; }
        public CreateObject(string name, int food, int titan, int irid, int gold)
        {
            InitializeComponent();
            NamePlanet.Text = name;
            FoodLabel.Text = "Еда + " + food;
            TitaniumLabel.Text = "Титан + " + titan;
            IridiumLabel.Text = "Иридий + " + irid;
            GoldLabel.Text = "Золото + " + gold;
            Status.Text = "";
            pic = new List<PictureBox> { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
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
                if (Res.Food >= 15 && Res.Titanium >= 2 && Res.Gold >= 250)
                {
                    pic[indexPic].Image = ColonistBox.Image;
                    indexPic++;
                    Res.Food -= 15;
                    Res.Titanium -= 2;
                    Res.Gold -= 250;
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
                    pic[indexPic].Image = DestroyerBox.Image;
                    indexPic++;
                    Res.Iridium -= 17;
                    Res.Titanium -= 8;
                    Res.Gold -= 450;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
                MovePictures(0);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
                MovePictures(1);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != null)
                MovePictures(2);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
                MovePictures(3);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != null)
                MovePictures(4);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image != null)
                MovePictures(5);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image != null)
                pictureBox8.Image = null;
        }
        void MovePictures(int x)
        {
            bool ok = false;
            for (int i = x; x < pic.Count - 1; i++)
            {
                if (i != 6 && pic[i+1].Image != null)
                pic[i].Image = pic[i + 1].Image;
                else
                {
                    pic[i].Image = null;
                    ok = true;
                    break;
                }
            }
            if (ok)
            {
                indexPic--;
            }
        }
    }
}
