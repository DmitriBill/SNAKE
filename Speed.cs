using System;
using System.Drawing;
using System.Threading;

namespace Snake
{
    public class Speed 
    {
        public Speed(int score) 
        {
            if (score <= 1)
            {
                Thread.Sleep(8); 
            }
            else if (score >= 2 && score <= 4)
            {
                Thread.Sleep(50); 
            }
            else if (score >= 5 && score <= 6)
            {
                Thread.Sleep(40); 
            }
            else if (score >= 7 && score <= 8)
            {
                Thread.Sleep(20); 
            }
        }
    }
}
