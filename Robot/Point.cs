using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Point: IPoint
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Left(int steps)
        {
            this.x -= steps;
        }

        public void Rigth(int steps)
        {
            this.x += steps;
        }

        public void Up(int steps)
        {
            this.x -= steps;
        }

        public void Down(int steps)
        {
            this.x -= steps;
        }

        public void Print()
        {
            Console.Write(this.x);
            Console.Write(this.y);
        }
    }
}
