using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    interface IPoint
    {
        int x { get; set; }
        int y { get; set; }

        void Print();
    }
}
