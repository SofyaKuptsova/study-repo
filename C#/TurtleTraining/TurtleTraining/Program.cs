using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void WriteT(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            //Буква "Т" начало
            Turtle.Angle = 0;
            Turtle.Move(size);
            //Turtle.Angle = 270;
            Turtle.TurnLeft();
            Turtle.Move(size / 3);
            Turtle.Angle = 90;
            Turtle.Move(size / 1.5);
            //Буква "Т" конец
        }
        static void WriteO(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }

        static void WriteR(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 180;
            Turtle.Move(size);
            Turtle.Angle = 0;
            WriteO(size);
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 8;

            //Торт
            WriteT(200, 200, 60);
           
            WriteO(240, 200, 30);

            WriteR(260, 200, 30);

            WriteT(300, 200, 30);

            /*for(int i = 0; i < 4; i++)
            {
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnLeft();
                Turtle.Move(20);
                Turtle.TurnLeft();
            }
            
            
            /*int i = 0;
            while(i < 6)
            {
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnLeft();
                Turtle.Move(20);
                Turtle.TurnLeft();
                //Turtle.Turn(60);
                //Turtle.TurnLeft();
                i++;
            }
            */
        }
    }
}
