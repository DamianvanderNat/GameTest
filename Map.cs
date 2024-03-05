using GameTest;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public class MapGeneration
    {
        public Dictionary<Point, Tile > dict = new Dictionary<Point, Tile>();
    
        public MapGeneration()
            {

            }
        public void CreateMap()
        {
            String jsonString = new StreamReader("map.json").ReadToEnd();
            var jsonFile = map.FromJson(jsonString);

            string FileName = jsonFile.File;
            long Lvl = jsonFile.Level;
            bool isTrue = jsonFile.CSharp;
        }
    }
}

