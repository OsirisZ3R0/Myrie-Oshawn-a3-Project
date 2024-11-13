using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace interactive_game
{
    public class DefenceTower
    {
        public int health = 100;
        public int damage = 20;
        public float bulletSpeed = 10;
        public int size = 20;
        public int timesUpgrade = 0;
        private int maxUpgrade = 10;
        public int maxRadius = 100;
        public Vector2 position;

        public DefenceTower(Vector2 pos) 
        {
            position = pos;
        }

        public void UpdateTower()
        {
            // draw your tower here
            Draw.LineSize = 5;
            Draw.LineColor = Color.Green;
            Draw.FillColor = Color.Blue;

            Draw.Circle(position, 25);
        }

        public void Shoot()
        {

        }

    }
}
