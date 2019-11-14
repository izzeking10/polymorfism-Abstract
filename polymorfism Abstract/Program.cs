using System;
using System.Collections.Generic;
using System.Text;

namespace polymorfism_Abstract
{
    class Player
    {
        public void Attack()
        {
            Console.WriteLine("A Player attacks!");
        }
    }
    class Mage : Player
    {
        public void Attack()
        {
            Console.WriteLine("A Mage attacks with a fireball!");
        }
    }
    class Warrior : Player
    {
        public void Attack()
        {
            Console.WriteLine("A Warrior attacks with a sword!");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player());
            players.Add(new Mage());
            players.Add(new Warrior());

            foreach (Player p in players)
            {
                p.Attack();
            }
        }
    }
}