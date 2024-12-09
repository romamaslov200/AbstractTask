using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask.Model.Abstract
{
    public abstract class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle - StartEngine");
        }
    }
}
