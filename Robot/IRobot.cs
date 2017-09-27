using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    interface IRobot
    {
        void PrintDetails();

        void Move(string direction, string steps);
    }
}
