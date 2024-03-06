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

        public void Voorbeeldje()
        {
            //voorbeeld 
            Point x = new Point(0, 0); Tile f1 = new Tile() { tileType = 2 };
            Point x2 = new Point(1, 0); Tile f2 = new Tile() { tileType = 3 };
            dict.Add(x, f1);
            dict.Add(x2, f2);
        
        }
    }
}

