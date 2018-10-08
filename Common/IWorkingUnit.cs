using BotFactory.Common.Tools;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface IWorkingUnit
    {

         Coordinates ParkingPos { get; set; }
         Coordinates WorkingPos { get; set; }
         bool IsWorking { get; set; }
        async Task<bool> WorkBegins();
        async Task<bool> WorkEnds();



    }
}