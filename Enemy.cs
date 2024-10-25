using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace interactive_game
{
    public class Enemy
    {
        public Vector2[] chosenPath;
        public Vector2 position;

        public int health = 100;
        public float speed = 2f;
        public int damage = 5;
        public 

        public Enemy(Vector2[] path, Vector2 startingPosition) 
        {
            Console.WriteLine("Hello World");

            chosenPath = path;
            position = startingPosition;
        }
    }
}
