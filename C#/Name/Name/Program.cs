using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Name
{
    class Program
    {
        static void WriteS(int size)
        {
            Turtle.Angle = 270;
            Turtle.Move(size / 1.5);
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 90;
            Turtle.Move(size / 1.5);
        }
        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size / 3);
            Turtle.Angle = 90;
            Turtle.Move(size / 1.5);
        }
        static void WriteA(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 90;
            Turtle.Move(size / 2);
            Turtle.Angle = 180;
            Turtle.Move(size / 2);
            Turtle.Angle = 270;
            Turtle.Move(size / 2);
            Turtle.Angle = 90;
            Turtle.Move(size / 2);
            Turtle.Angle = 180;
            Turtle.Move(size / 2);
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 8;
            Turtle.X = 200;
            Turtle.Y = 200;

            WriteS(90);

            Turtle.X = 240;
            Turtle.Y = 200;

            WriteT(60);

            Turtle.X = 280;
            Turtle.Y = 200;

            WriteA(60);

            Turtle.X = 380;
            Turtle.Y = 200;

            WriteS(60);
        }
    }
}
