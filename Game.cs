// Include code libraries you need below (use the namespace).
using interactive_game;
using System;
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
        
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize (800, 600);
            Enemy x = new Enemy(path1, Vector2.Zero);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

        }
    }
}
