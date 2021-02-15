using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {

        public Snake(Point tail, int lenght, Direction direction)
        {
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
