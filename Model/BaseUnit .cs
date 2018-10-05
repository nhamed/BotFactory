using BotFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Tools;

namespace Botfactory.model
{
    abstract public class BaseUnit : BuildableUnit
    {

        private int vitesse;
        public string nom {get; set;}       
        public int x { get; set; }
        public int y { get; set; }
        public Coordinates CurrentPos { set; get; }
       
        public int Vitesse
        {
            get
            {
                return vitesse;
            }
            set
            {
                Vitesse = 1;
            }


        }   

        public BaseUnit(string nom , int vitesse) 
        {
            this.nom = nom;
            this.vitesse = vitesse;
            this.CurrentPos = new Coordinates(0.0, 0.0);
        }


        public async  Task<Double>  Move (Coordinates positionactuel , Coordinates positionsouhaite)
        {
            if (positionactuel !=null && positionsouhaite !=null)
            {
                Vector v = new Vector();


               
                Vector t = Vector.FromCoordinates(positionactuel, positionsouhaite);
                //sleep pendant le deplaceement du robo
                await Task.Delay(Convert.ToInt16(t));
                //calcule  temps de parcours
                double temp = (v.Length(t)/ vitesse);
              
                return temp;
            }
            else
            {
                return 0;
            }
        }

    }
}
