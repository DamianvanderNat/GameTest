using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameTest
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
            string json = ReadJsonMapFromFile("mapvb.json");
            MapGeneration y = JsonConvert.
                DeserializeObject<MapGeneration>(json);
            StartPanel.Visible = false;
        }
        private void StartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GameForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                StartPanel.Visible = true;
            }
        }
    }
}