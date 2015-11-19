using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StarWars.EditorLevel;
using StarWars.Game;

namespace StarWars
{
    public partial class StartForm : Form
    {
        Editor editorLevel;
        public StartForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true); // без мерцаний
            BackgroundImage = Image.FromFile(@"Images\Background.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            game.ShowDialog();
        }
        private void EditorLevelButton_Click(object sender, EventArgs e)
        {
            editorLevel = new Editor();
            editorLevel.ShowDialog();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
