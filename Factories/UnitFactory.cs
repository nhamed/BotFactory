using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;
using BotFactory.Models;

namespace BotFactory.Factories
{
    public class UnitFactory : IUnitFactory
    {

        private int QueueCapacity { get; set; }
        private int StorageCapacity { get; set; }
        public UnitFactory() { }
        public UnitFactory(int taillequeue, int tailleentreprise)
        {
            //-Ajouter un constructeur prenant en paramètre la taille de la queue et la taille de l’entrepôt de l’usine.
            //    Ces paramètres ne doivent pas être modifiables en dehors du constructeur.

            this.QueueCapacity = taillequeue;
            this.StorageCapacity = tailleentreprise;
        }



    }
}
