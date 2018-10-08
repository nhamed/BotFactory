using BotFactory.Common.Tools;
using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Factories
{
    public class FactoryQueueElement : IFactoryQueueElement
    {
        public string Name { get; set; }
        public Type Model { get; set; }
        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        private Queue<FactoryQueueElement> _q;
        public Queue<FactoryQueueElement> queue { get; set; }

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
        public bool AddWorkableUnitToQueue (string nom, Type model, Coordinates parkingPos, Coordinates workingPos)
        {
            FactoryQueueElement add = new FactoryQueueElement( nom, model,  parkingPos, workingPos);

//- L’usine ne peut construire qu’un robot à la fois. 
//- L’usine ne peut enregistrer plus de commandes si sa queue est pleine 
//- L’usine ne peut construire plus de robots si son entrepôt est plein 
//- On peut appeler l’ajout de commande n’importe quand 
//- La méthode doit retourner false si la commande n’est pas enregistrée 
//- La construction doit être active tant que la queue n’est pas vide ou l’entrepôt plein 
//- La construction d’un robot doit être simulée et prendre le temps indiqué par la propriété BuildTime du robot 


            return true;
        }





    }


}
