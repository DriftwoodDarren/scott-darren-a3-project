using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Rounds
    {
        public bool isFiring; 
        public void Render(Vector2 bulletPOS)
        {
            while (isFiring)
            {
            Draw.Circle(bulletPOS, 2.5f);
            }
            
        }
    }
}
