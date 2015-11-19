using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars.EditorLevel
{
    public partial class SaveMap : Form
    {
        mapObject[,] map;
        public SaveMap(mapObject[,] map)
        {
            InitializeComponent();
            this.map = map;
        }
        private void SafeButton_Click(object sender, EventArgs e)
        {
            RecordFile(InputBox.Text, map);
            this.Close();
        }
        void RecordFile(string name, mapObject[,] map)
        {
            FileStream file = null;
            BinaryFormatter b = null;
            try
            {
                file = File.Create("Maps/" + name + ".swdat");
                b = new BinaryFormatter();
                b.Serialize(file, map);
            }
            finally
            {
                file.Close();
            }

        }

        private void SaveMap_Load(object sender, EventArgs e)
        {

        }
    }
}
