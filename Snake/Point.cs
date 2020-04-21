using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sum;

      
        public Point(int _x, int _y, char _sum)
        {
            x = _x;
            y = _y;
            sum = _sum;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum); 
        }
    }
}
