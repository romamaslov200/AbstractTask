using AbstractTask.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask.Model
{
    internal class Point : IMovable
    {
        int X, Y;

        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
            Console.WriteLine($"Point = x-{X} y-{Y}");
        }
    }
}
