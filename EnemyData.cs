using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public class EnemyData
    {
       public List<Enemy> Enemies = new List<Enemy>();
       

        public EnemyData()
        {
            Enemies.Add(new Enemy("Slime", 100, 10, 0));
            Enemies.Add(new Enemy("Mutated Flower" , 100, 10 , 0));
            Enemies.Add(new Enemy("Giant Worm" , 100, 10 , 0));
            Enemies.Add(new Enemy("King Slime" , 1000, 100 , 0)); //scripted event after certain amount of slime kills
            Enemies.Add(new Enemy("", 100, 10, 0)); //Unique event encounter
            Enemies.Add(new Enemy("", 100, 10, 0)); //Unique event encounter
            Enemies.Add(new Enemy("Goblin" , 100, 10 , 0));
            Enemies.Add(new Enemy("Ent" , 100, 10 , 0));
            Enemies.Add(new Enemy("Angry Monkey" , 100, 10 , 0));
            Enemies.Add(new Enemy("Giant Spider" , 100, 10 , 0));
            Enemies.Add(new Enemy("Orc" , 100, 10 , 0));
            Enemies.Add(new Enemy("Ancient Golem" , 1000, 100 , 0)); //Unique event encounter
            Enemies.Add(new Enemy("Ugly Goblin" , 10, 1 , 0)); //Unique event encounter
            Enemies.Add(new Enemy("Troll" , 100, 10 , 0)); //Unique event encounter
            Enemies.Add(new Enemy("Cactus" , 100, 10 , 0));
            Enemies.Add(new Enemy("Sandworm" , 100, 10 , 0));
            Enemies.Add(new Enemy("Snake" , 100, 10 , 0));
            Enemies.Add(new Enemy("Antlion" , 100, 10 , 0));
            Enemies.Add(new Enemy("Scorpion" , 100, 10 , 0));
            Enemies.Add(new Enemy("", 100, 10, 0)); //Unique event encounter
            Enemies.Add(new Enemy("", 100, 10, 0)); //Unique event encounter
            Enemies.Add(new Enemy("Mummy" , 100, 10 , 0)); //Unique event encounter
            Enemies.Add(new Enemy("Tortoise" , 100, 10 , 0));
            Enemies.Add(new Enemy("Musquito Swarm" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));
            Enemies.Add(new Enemy("" , 100, 10 , 0));


            foreach (Enemy enemy in Enemies)
            {
                
            }
        }


    }

}
