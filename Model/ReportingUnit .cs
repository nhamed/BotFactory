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
        //Le client souhaite que les robots puissent faire du reporting sur leurs activités pour que des
        //contrôleurs puissent vérifier leur bon fonctionnement
        //les robots déclenchent des événements et renvoient des
        //arguments aux observateurs
        //Le reporting doit pouvoir être fait par n’importe quel robot construit, même s’il n’est pas
        //mobile.
        public event EventHandler UnitStatusChanged;
        public ReportingUnit() { }

        protected virtual void OnStatusChanged(EventArgs StatusChangedEventArgs)
        {
            if (UnitStatusChanged != null)
            {
                UnitStatusChanged(this, StatusChangedEventArgs);
            }

        }

    }
}
