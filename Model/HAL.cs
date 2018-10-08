using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
   public class HAL : WorkingUnit
    {
        public HAL(int vitesse, double temp)
        {

            this.Vitesse = 0.5;
            this.BuildTime = 7;
        }
    }
}
