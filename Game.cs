// Include code libraries you need below (use the namespace).
using interactive_game;
using System;
using System.Drawing;
using System.Net.Mail;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        private const int maxEnemies = 20;

        public bool isAltPath = false;
        public Vector2[] path1 = {
            new Vector2(0, 300),
            new Vector2(100, 300),
            new Vector2(100, 200),
            new Vector2(250, 200),
            new Vector2(250, 50),
            new Vector2(500, 50),
            new Vector2(600, 150),
            new Vector2(450, 250),
            new Vector2(450,450),
            new Vector2(800, 550),
        };


        public Enemy[] currentEnemies = new Enemy[maxEnemies];
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Enemy x = new Enemy(path1, Vector2.Zero);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            GenerateStructures();
        }

        public void GenerateStructures()
        {
            Draw.LineSize = 8;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.DarkGray;

            Draw.Rectangle(400, 500, 100, 100);

            Draw.Capsule(new Vector2(350, 150), new Vector2(400, 150), 50);

            Draw.Rectangle(new Vector2(500, 350), new Vector2(250,100));

            Draw.Quad(new Vector2(550,250),new Vector2(650,200),new Vector2(700,200),new Vector2(650,250));

            Draw.Rectangle(new Vector2(200, 250), new Vector2(100, 150));

            Draw.Triangle(new Vector2(50, 450), new Vector2(200, 600), new Vector2(50, 600));

            Draw.Rectangle(new Vector2(50, 50), new Vector2(150, 100));

            Draw.Rectangle(new Vector2(650,50), new Vector2(50, 100));

            Draw.Rectangle(new Vector2 (750,50),new Vector2(50,100));

            Draw.Rectangle(new Vector2(550, 550), new Vector2(200, 50));
    


        }
    }
}
