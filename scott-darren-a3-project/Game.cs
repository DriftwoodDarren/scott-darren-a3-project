// Libraries 
using System;
using System.Numerics;

// Namespace 
namespace MohawkGame2D
{
    public class Game
    {
        // Variables
        Player player = new Player();
        
        public void Setup()
        {
            // Window Setup
            Window.SetTitle("The Tank Hunt");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;
            Window.ClearBackground(Color.OffWhite);

            
            //Initial Tank Render
            player.Render();  
        }

        public void Update()
        {
            player.Movement();
        }
    }

}
