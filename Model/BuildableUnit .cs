using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common;
using BotFactory.Interface;

namespace BotFactory.Models
{
    abstract public class BuildableUnit : ReportingUnit , IBuildableUnit
    {


        public double BuildTime { get; set; }
        public string Model { get; set; }

        public BuildableUnit()
        {

        }
        public BuildableUnit(double Temps)
        {
            BuildTime = Temps;

        }
    }

}
