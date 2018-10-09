using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BotFactory.Models
{
  public  class R2D2 : WorkingUnit , IR2D2
    {
        public R2D2(double vitesse ,double temps )
        {

            this.Vitesse = 1.5;
            this.BuildTime = 5.5;
        }


    }
}
