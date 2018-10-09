using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;
using BotFactory.Models;
using BotFactory.Common.Tools;

namespace BotFactory.Factories
{
    public class UnitFactory : IUnitFactory
    {

        private int QueueCapacity { get; set; }
        private int StorageCapacity { get; set; }
        public Queue<FactoryQueueElement> Queue { get; set; }
        public UnitFactory() { }
        public UnitFactory(int taillequeue, int tailleentreprise)
        {
            //-Ajouter un constructeur prenant en paramètre la taille de la queue et la taille de l’entrepôt de l’usine.
            //    Ces paramètres ne doivent pas être modifiables en dehors du constructeur.

            this.QueueCapacity = taillequeue;
            this.StorageCapacity = tailleentreprise;
        }

        public bool AddWorkableUnitToQueue(string nom, Type model, Coordinates parkingPos, Coordinates workingPos)
        {

            {
                if ((Queue.Count <= this.QueueCapacity) && ((Queue.Count <= this.StorageCapacity)))
                    {
                    FactoryQueueElement add = new FactoryQueueElement(nom, model, parkingPos, workingPos);
                }
            }
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
