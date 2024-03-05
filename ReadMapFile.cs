using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;


namespace GameTest
{
    internal class ReadMapFile
    {
        public List<Tile> UseJArrayParseInNewtonsoftJson()
        {
            using StreamReader reader = new();
            var json = reader.ReadToEnd();
            var jarray = JArray.Parse(json);
            List<Tile> tiles = new();
            foreach (var item in jarray)
            {
                Tile tile = item.ToObject<Tile>();
                tiles.Add(tile);
            }
            return tiles;
        }
    }
}
