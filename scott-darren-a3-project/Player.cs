using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Player
    {
        // Tank Variables
        public Vector2 playerPOS; //= Vector2.Zero; 
        public int playerSize = 25;
        public float playerSpeed = 3; 
        Color tankColor = new Color(75, 83, 32);

        //public Vector2 bulletPOS = new Vector2(playerPOS.X, playerPOS.Y);


        public void Render()
        {
            Draw.LineSize = playerSize / 10;
            Draw.LineColor = Color.Black;
            Draw.FillColor = tankColor;  
            Draw.Square(playerPOS, playerSize);
        }

        public void Movement()
        {
            // Window Collision Detection
            bool touchingLeftEdge = playerPOS.X <= Window.Width - Window.Width;
            bool touchingRightEdge = playerPOS.X >= Window.Width - playerSize;
            bool touchingTopEdge = playerPOS.Y <= Window.Height - Window.Height;
            bool touchingBottomEdge = playerPOS.Y >= Window.Height - playerSize;

            // Left Movement 
            if (Input.IsKeyboardKeyDown(KeyboardInput.A) && !touchingLeftEdge)
            {
                playerPOS.X -= playerSpeed;
            }
            
            // Right Movement 
            else if (Input.IsKeyboardKeyDown(KeyboardInput.D) && !touchingRightEdge)
            {
                playerPOS.X += playerSpeed;
            }

            // Up Movement
            else if (Input.IsKeyboardKeyDown(KeyboardInput.W) && !touchingTopEdge)
            {
                playerPOS.Y -= playerSpeed;
            }
            
            // Down Movement
            else if (Input.IsKeyboardKeyDown(KeyboardInput.S) && !touchingBottomEdge)
            {
                playerPOS.Y += playerSpeed;
            }
        }

        public Vector2 GetPlayerPOS()
        {
            return playerPOS;
        }
    }
}
