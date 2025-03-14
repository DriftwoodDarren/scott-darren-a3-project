using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Targets
    {
        Vector2 targetPOS = Random.Vector2(0, Window.Width - 50, 50, Window.Height - 50);
        public void Render()
        {
           
            // Box 
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Square(targetPOS, 50);

            // Outer Ring
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.Red;
            Draw.Circle(targetPOS.X + 25, targetPOS.Y + 25, 25);

            // White Ring
            Draw.LineColor = Color.White;
            Draw.FillColor = Color.White;
            Draw.Circle(targetPOS.X + 25, targetPOS.Y + 25, 15);

            // Center
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.Red;
            Draw.Circle(targetPOS.X + 25, targetPOS.Y + 25,5);
        }
    }
}
