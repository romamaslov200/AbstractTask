using AbstractTask.Model.Abstract;
using AbstractTask.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask.Model
{
    internal class Rectangle : Shape, IMovable
    {
        int X, Y;
        public override void GetArea()
        {
            Console.WriteLine("Rectangle GetArea()");
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
            Console.WriteLine($"Rectangle = x-{X} y-{Y}");
        }
    }
}
