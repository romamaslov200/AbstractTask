using AbstractTask.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask.Model
{
    internal class Triangle : IShape
    {
        public void GetPerimetr()
        {
            Console.WriteLine($"Triangle - GetPerimetr");
        }

        public void GetArea()
        {
            Console.WriteLine($"Triangle - GetArea");
        }
    }
}
