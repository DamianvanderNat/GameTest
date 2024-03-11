using GameTest;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace GameTest
{
    public class MapGeneration
    {
        public Dictionary<Point, Tile> dict = new Dictionary<Point, Tile>();

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
        public string GenerateTextFromMap()
        {
            string map = "";
            int currentRow = 0;
            foreach (var kvp in dict)
            {
                currentRow = 0;
                Point key = kvp.Key;
                Tile value = kvp.Value;
                if (key.Y == currentRow)
                {
                    map += value.tileType;

                }
                else
                {
                    map += "\n";
                    map += value.tileType;
                    currentRow++;
                }
            }

            return map;
        }

        public void GenerateImageFromMap(FlowLayoutPanel p)
        {
            string map = "";
            int currentRow = 0;
            PictureBox pb = null;
            List<PictureBox> row = new List<PictureBox>();
            foreach (var kvp in dict)
            {
                currentRow = 0;
                Point key = kvp.Key;
                Tile value = kvp.Value;
                if (key.Y == currentRow)
                {
                     pb = new PictureBox();
                    pb.Image = Image.FromFile("../../../Resources/tile" + value.tileType.ToString() + ".jpg");
                    map += value.tileType;
                    p.Controls.Add(pb);
                }
                else
                {
                    p.SetFlowBreak(pb, true);
                     pb = new PictureBox();
                    map += value.tileType;
                   pb.Image = Image.FromFile("../../../Resources/tile" + value.tileType.ToString() + ".jpg");
                    p.Controls.Add(pb);
                    currentRow++;
                }
            }
            return ;
        }
    }
}

