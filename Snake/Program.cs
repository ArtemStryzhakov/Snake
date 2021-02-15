﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '-');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, 'I');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, 'I');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Отрислвка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
        }
    }
}
