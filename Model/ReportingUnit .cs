using BotFactory.Common;
using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BotFactory.Models
{
    abstract public class ReportingUnit : IReportingUnit
    {

        public event EventHandler UnitStatusChanged;
        public ReportingUnit() { }

        protected virtual void OnStatusChanged (EventArgs statusChangedEventArgs)
        {
            if (UnitStatusChanged !=null)
            {
                UnitStatusChanged(this, StatusChangedEventArgs);
            }

        }

    }
}
