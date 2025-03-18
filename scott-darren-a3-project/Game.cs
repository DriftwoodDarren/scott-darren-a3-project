// Libraries 
using System;
using System.Numerics;

// Namespace 
namespace MohawkGame2D
{
    public class Game
    {
        // Variables
        // Tank Variables
        Player player = new Player();
        Targets[] targets = new Targets[5];
        Rounds[] rounds = new Rounds[100];

        // Bullet Variables
        //int roundCount;
        public void Setup()
        {
            // Window Setup
            Window.SetTitle("The Tank Hunt");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;

            // Initialize Targets Array 
            for (int index = 0; index < targets.Length; index++)
            {
                targets[index] = new Targets();
            }
           
            /*for (int index = 0; index < rounds.Length; index++)
            {
                targets[index] = new Targets();
            }*/
        }
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            RenderAll();
        }

        public void RenderAll()
        {
            player.Render();
            player.Movement();
            targets[0].Render();
            targets[1].Render();
            targets[2].Render();
            targets[3].Render();
            targets[4].Render();
           
            
            /*if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                for (roundCount = new Rounds();
                roundCount++;
                rounds[roundCount].isFiring = true;
                rounds[roundCount].Render(player.GetPlayerPOS());
            }*/
            
           
            
        }
    }

}
