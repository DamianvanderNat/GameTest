using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameTest
{

    public partial class GameForm : Form
    {

        public Player player;
        public Enemy Enemy1;
        public Enemy Enemy2;

        public GameForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //var obj = new ClassName();
            List<Enemy> Enemies = new List<Enemy>();

        }


        /* this.Enemy1 = new Enemy("Slime", 100, 10, 0);
         this.Enemy2 = new Enemy("goblin", 100, 10, 0);*/


        //this.TopMost = true;
        //this.FormBorderStyle = FormBorderStyle.None;
        //this.WindowState = FormWindowState.Maximized;


        private void lblQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            //hier komt de settings scherm achter
        }


        private string ReadJsonMapFromFile(string filename)
        {

            string path = Directory.GetCurrentDirectory() + "\\" + filename;
            string json = "";
            // This text is added only once to the file.
            if (File.Exists(path))
            {
                // Create a file to write to.
                json = File.ReadAllText(path);
            }
            return json;
        }
        private void lblStart_Click(object sender, EventArgs e)
        {
            this.player = new Player();

            string json = ReadJsonMapFromFile("mapvb.json");
            MapGeneration y = JsonConvert.
                DeserializeObject<MapGeneration>(json);

            //label1.Text = y.GenerateTextFromMap();
            //flowLayoutPanel1.Controls.AddRange(y.GenerateImageFromMap().ToArray());
            y.GenerateImageFromMap(flowLayoutPanel1);
            tabControl1.SelectedTab = Game1;
        }


        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public void InputBoxMap1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string action = "";
            if (sender == InputBoxMap1)
            {
                action = InputBoxMap1.Text.ToLower();
            }
            else
            {
                action = InputBox1.Text.ToLower();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                switch (action)
                {
                    case "map":
                        tabControl1.SelectedTab = Map1;
                        InputBox1.Text = "";
                        InputBoxMap1.Text = "";
                        break;
                    case "quit":
                        Application.Exit();
                        InputBox1.Text = "";
                        InputBoxMap1.Text = "";
                        break;
                    case "return":
                        tabControl1.SelectedTab = Game1;
                        InputBox1.Text = "";
                        InputBoxMap1.Text = "";
                        break;
                    case "north":
                        player.Location.Y = player.Location.Y++;
                        playerLocation.Text = player.Location.ToString();
                        InputBox1.Text = "";
                        break;
                    case "east":
                        player.Location.X = player.Location.X++;
                        playerLocation.Text = player.Location.ToString();
                        InputBox1.Text = "";

                        break;
                    case "south":
                        player.Location.Y = player.Location.Y--;
                        playerLocation.Text = player.Location.ToString();
                        InputBox1.Text = "";
                        break;
                    case "west":
                        player.Location.X = player.Location.X--;
                        playerLocation.Text = player.Location.ToString();
                        InputBox1.Text = "";
                        break;
                    case "attack":
                        if (tabControl1.SelectedTab == Game1)
                        {
                            InputBox1.Text = "";
                            break;
                        }
                        break;
                    case "run":
                        if (tabControl1.SelectedTab == Game1)
                        {
                            InputBox1.Text = "";
                            break;
                        }
                        break;
                }
            }
        }
    }
}