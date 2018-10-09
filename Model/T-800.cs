using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class T_800 : WorkingUnit, IT_800
    {

        public T_800(int vitesse, double temp)
        {

            this.Vitesse = 3;
            this.BuildTime = 10;
        }
    }
}
