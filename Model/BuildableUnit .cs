using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Model
{
    abstract public class BuildableUnit : ReportingUnit
    {


        public double BuildTime { get; set; }


        public BuildableUnit()
        {

        }
        public BuildableUnit(double Temps)
        {
            BuildTime = Temps;

        }
    }

}
