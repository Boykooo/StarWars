using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
                
    [Serializable]
    public class MapStruct
    {
        public static int BlockSize { get; set; }
        public mapObject[,] MapObject { get; set; }
        public static int Shift { get; set; }
        public MapStruct()
        {
            MapObject = new mapObject[21, 14];
            BlockSize = 40;
            Shift = 30;
        }
        public void InitMap()
        {
            FileStream file = null;
            BinaryFormatter dr = null;
            try
            {
                file = new FileStream(@"Maps\test.swdat", FileMode.Open);
                dr = new BinaryFormatter();
                MapObject = dr.Deserialize(file) as mapObject[,];
            }
            finally
            {
                file.Close();
            }
        }
    }
}
