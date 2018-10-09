using BotFactory.Common.Tools;
using System;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface IBaseUnit
    {
        string Nom { get; set; }
        int X { get; set; }
        int Y { get; set; }
        Coordinates CurrentPos { set; get; }
        double Vitesse { get; set; }
        Task<Double> Move(Coordinates positionactuel, Coordinates positionsouhaite);
    }
}