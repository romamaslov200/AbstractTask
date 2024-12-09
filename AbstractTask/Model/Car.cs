using AbstractTask.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask.Model
{
    internal class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Vehicle - Car");
        }
    }
}
