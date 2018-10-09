using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common;
using BotFactory.Interface;
using System.Timers;

namespace BotFactory.Models
{
    abstract public class BuildableUnit : ReportingUnit, IBuildableUnit
    {

        //Le client souhaite que l'usine fabrique uniquement les robots constructibles
        //Le client pense que 5 secondes est un bon temps des construction par défaut.

        private Timer _timer = new Timer();

        private int counter = 0;
        public double BuildTime { get; set; }
        public string Model { get; set; }

        public BuildableUnit()
        {
            BuildTime = (_timer.Interval = 5000);
        }
        public BuildableUnit(double Temps)
        {

            if (Temps <= (_timer.Interval = 5000))
                BuildTime = Temps;

        }
    }

}
