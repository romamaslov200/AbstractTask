using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask.Model.Interface
{
    internal interface IWorker
    {
        void Work();
        void TakeBreak();
    }
}
