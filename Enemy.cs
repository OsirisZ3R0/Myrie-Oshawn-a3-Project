using Game10003;
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

        public bool is_alive = true;
        public int health = 100;
        public float speed = 2f;
        public int damage = 5;
        public int size = 5;
        public int killvalue = 5;

        public Enemy(Vector2[] path, Vector2 startingPosition) 
        {
            Draw.Circle (50, 50,0);
            Draw.FillColor = Color.Red;
            Draw.LineSize = 1;
               
            chosenPath = path;
            position = startingPosition;
        }

        public void Die() 
        {
            is_alive = false;
        }
        public void UpdateEnemy()
        {
            // draw your tower here
            Draw.LineSize = 2;
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.Black;
            Draw.Circle(position, size);
        }
     
    }   
}
