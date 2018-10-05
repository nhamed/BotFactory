using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BotFactory.Model
{
    abstract public class ReportingUnit
    {

        public event EventHandler UnitStatusChanged;
        public ReportingUnit() { }

        protected virtual void OnStatusChanged (EventArgs StatusChangedEventArgs)
        {
            if (UnitStatusChanged !=null)
            {
                UnitStatusChanged(this, StatusChangedEventArgs);
            }

        }

    }
}
