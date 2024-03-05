using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void lblStart_Click(object sender, EventArgs e)
        {
            MapGeneration x = new MapGeneration();
            x.CreateMap();
            //Tile y = x.dict[new Point(8,7)];
        }
    }
}
