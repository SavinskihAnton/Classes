using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Point
    {
        int x, y;
        string z;

        public Point(int x, int y, string z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public int X 
        { 
            get
            { 
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Z
        {
            get
            {
                return z;
            }
        }
    }
}
