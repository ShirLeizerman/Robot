using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Robot: IRobot
    {
        string name { get; set; }
        string id { get; }
        IPoint position { get; set; }

        public Robot(string name)
        {
            id = Utilities.GenerateID();
            this.name = name;
            this.position = new Point();

            Utilities.DicFromClass(moveOptions, typeof(Point));
        }


        Dictionary<string, MethodInfo> moveOptions = new Dictionary<string, MethodInfo>();
        public void Move(string direction, string steps)
        {
            int numStep = Int32.Parse(steps);
            if (moveOptions.ContainsKey(direction))
            {
                moveOptions[direction].Invoke(position, new object[] { numStep });
            }
        }

        public void PrintDetails() {
            this.position.Print();
        }
    }
}
