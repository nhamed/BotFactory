using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Tools
{
    public class Vector
    {
        public double x { get; set; }
        public double y { get; set; }


        public Vector()
        {
            x = y = 0.0;

        }
        public Vector (double X , double Y)
        {
            this.x = X;
            this.y = Y;
        }

        public static Vector FromCoordinates(Coordinates begin, Coordinates and)
        {
            Vector V = new Vector(and.x - begin.x, and.y - begin.y);
            return V;
        }

        public double Length(Vector v)
        {
            return Math.Sqrt(Math.Pow((v.x), 2) + Math.Pow(v.y, 2));
        }
    }
}
