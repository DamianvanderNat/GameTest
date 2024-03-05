using GameTest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;


namespace GameTest
{
    public class MapGeneration
    {
        public Dictionary<Point, Tile > dict = new Dictionary<Point, Tile>();
    
        public MapGeneration()
            {

            }
        private string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string dirNamespace = "GameTest";
        public Map CreateMap()
        {
            if (!Directory.Exists(Path.Combine(directory, dirNamespace))) Directory.CreateDirectory(Path.Combine(directory, dirNamespace));
            String jsonString = new StreamReader(Path.Combine(directory, dirNamespace, "map.json")).ReadToEnd();
            var jsonFile = Map.FromJson(jsonString);

            return jsonFile;
        }
    }
}

