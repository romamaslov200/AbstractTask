using AbstractTask.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask.Model
{
    public class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Vehicle - Motorcycle");
        }
    }
}
