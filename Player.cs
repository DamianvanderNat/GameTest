using GameTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameTest
{
    public class Player
    {
        public string name;
        public int health;
        public int damage;
        public int Exp;

        public Player Player_1(object sender, EventArgs e)
        {
            Player player = new Player();
            player.name = "Unnamed";
            player.health = 100;
            player.damage = 10;
            

            return player;
        }

    }
}
