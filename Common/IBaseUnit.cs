using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Interface
{
    public interface IBaseUnit
    {
        
         string Nom { get; set; }
         int X { get; set; }
         int Y { get; set; }
         Coordinates CurrentPos { set; get; }

         int Vitesse { get; set; }
        Task<Double> Move(Coordinates positionactuel, Coordinates positionsouhaite);
    }
}
