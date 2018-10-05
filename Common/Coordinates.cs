using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Tools
{
    public class Coordinates
    {
        public double x { get; set; }
        public double y { get; set; }

        public Coordinates(double X, double Y)
        {
            this.x = X;
            this.y = Y;
        }

        public bool Equals(Coordinates c)
        {
            if (c != null)
            {
               if((c.x ==x)&&(c.y == y))
                {
                    return true;
                }
               else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
