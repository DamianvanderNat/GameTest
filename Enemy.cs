using GameTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GameTest
{
    public class Enemy
    {
        public string name;
        public int health;
        public int damage;
        public int givenExp;

        public Enemy (string name , int health , int damage , int givenExp)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.givenExp = givenExp;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int GivenExp
        {
            get { return givenExp; }
            set { givenExp = value; }
        }
    }

}

