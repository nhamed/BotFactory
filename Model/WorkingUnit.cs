using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Models;
using BotFactory.Common;
using BotFactory.Interface;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    abstract public class WorkingUnit : BaseUnit, IWorkingUnit
    {

        //Le client souhaite que les robots puissent se rendre à leur lieu de travail, ou retourner se
        //recharger de façon indépendante

        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        public bool IsWorking { get; set; }

        public WorkingUnit() : base() { }
        public WorkingUnit(Coordinates parkingPos, Coordinates workingPos, bool isWorking)
        {
            this.ParkingPos = parkingPos;
            this.WorkingPos = workingPos;
            this.IsWorking = isWorking;
        }


        public async Task<bool> WorkBegins()
        {
            //La méthode WorkBegins doit s’assurer que le robot aille se mettre à travailler sur son
            //emplacement du travail WorkingPos , et ce quelle que soit sa position au moment ou la
            //méthode est appelée.

            this.IsWorking = false;
            StatusChangedEventArgs _statusChangedEventArgs = new StatusChangedEventArgs();
            OnStatusChanged(_statusChangedEventArgs);
            while (this.IsWorking != true)
            {
                double temp = await Move(this.ParkingPos , this.WorkingPos);
                while (temp != 0)
                {
                    this.IsWorking = false;
                }

                this.IsWorking = true;
            }

            return true;
        }

        public async Task<bool> WorkEnds()
        {
            //La méthode WorkEnds doit s’assurer que le robot aille se recharger à sa position de
            //stationnement ParkingPos , et ce quelle que soit sa position au moment ou la méthode est
            //appelée.
            // return Task.Run(() =>
            // {
            this.IsWorking = false;
            StatusChangedEventArgs _statusChangedEventArgs = new StatusChangedEventArgs();
            OnStatusChanged(_statusChangedEventArgs);
            while (this.IsWorking != true)
            {
                double temp = await Move(this.WorkingPos, this.ParkingPos);
                while (temp != 0)
                {
                    this.IsWorking = false;
                }

                this.IsWorking = true;
            }

            return true;
            //      });
        }

    }
}

