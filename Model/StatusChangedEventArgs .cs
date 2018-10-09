using BotFactory.Common;
using BotFactory.Interface;
using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
  public  class StatusChangedEventArgs : EventArgs , IStatusChangedEventArgs
    {
        public string NewStatus { get; set; }

        public StatusChangedEventArgs() { }

        public StatusChangedEventArgs (string newstatus)
        {
            this.NewStatus = newstatus;
        }
    }
}
