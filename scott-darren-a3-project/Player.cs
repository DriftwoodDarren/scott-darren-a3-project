using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Player
    {
        // Variables
        public float playerPosX = Window.Width / 2;
        public float playerPosY = Window.Height / 2;
        public int playerSize = 25;
        Color tankColor = new Color(75, 83, 32);

        public void Render()
        {
            Draw.LineSize = playerSize / 10;
            Draw.LineColor = Color.Black;
            Draw.FillColor = tankColor;  
            Draw.Square(playerPosX, playerPosY, playerSize);
        }

        public void Movement()
        {
            // Window Collision Detection
            bool touchingLeftEdge = playerPosX <= Window.Width - Window.Width;
            bool touchingRightEdge = playerPosX >= Window.Width - playerSize;
            bool touchingTopEdge = playerPosY <= Window.Height - Window.Height;
            bool touchingBottomEdge = playerPosY >= Window.Height - playerSize;

            // Left Movement 
            if (Input.IsKeyboardKeyDown(KeyboardInput.A) && !touchingLeftEdge)
            {
                Window.ClearBackground(Color.OffWhite);
                playerPosX -= 3;
                Render();
            }
            
            // Right Movement 
            if (Input.IsKeyboardKeyDown(KeyboardInput.D) && !touchingRightEdge)
            {
                Window.ClearBackground(Color.OffWhite);
                playerPosX += 3;
                Render();
            }

            // Up Movement
            if (Input.IsKeyboardKeyDown(KeyboardInput.W) && !touchingTopEdge)
            {
                Window.ClearBackground(Color.OffWhite);
                playerPosY -= 3;
                Render();
            }
            
            // Down Movement
            if (Input.IsKeyboardKeyDown(KeyboardInput.S) && !touchingBottomEdge)
            {
                Window.ClearBackground(Color.OffWhite);
                playerPosY += 3;
                Render();
            }

        }
        
    }
}
