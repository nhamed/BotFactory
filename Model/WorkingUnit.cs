using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Tools;

namespace BotFactory.Model
{
    abstract public class WorkingUnit
    {

        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        public bool IsWorking { get; set; }

        public WorkingUnit() { }
        public WorkingUnit(Coordinates parkingPos ,Coordinates workingPos ,bool isWorking)
        {
            this.ParkingPos = parkingPos;
            this.WorkingPos = workingPos;
            this.IsWorking = isWorking;
        }
        
        
        public async Task<bool> WorkBegins ()
        {
            //
            return true;
        }
        public async Task<bool> WorkEnds()
        {
            //return true;
            return true;
        }

    }
}
