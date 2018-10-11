using BotFactory.Common.Tools;
using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Factories
{
    public class FactoryQueueElement : UnitFactory , IFactoryQueueElement
    {
        public string Name { get; set; }
        public Type Model { get; set; }
        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        //private Queue<FactoryQueueElement> _q;
       
        private bool QueueFreeSlots { get; set; }
        private bool StorageFreeSlots { get; set; }

        public FactoryQueueElement() { }

        public FactoryQueueElement(string nom, Type model, Coordinates parkingPos, Coordinates workingPos)
        {
            this.Name = nom;
            this.Model = model;
            this.ParkingPos = parkingPos;
            this.WorkingPos = workingPos;

        }

        private List<ITestingUnit> _storage;
        public List<ITestingUnit> storage
        {
            get
            {
                return _storage.ToList();
            }

            set { }

        }






    }


}
