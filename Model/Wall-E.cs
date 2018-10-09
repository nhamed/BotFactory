using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class Wall_E : WorkingUnit, IWall_E
    {

        public Wall_E(int vitesse , double temp)
        {
            this.Vitesse = 2;
            this.BuildTime = 4;
        }
    }
}
