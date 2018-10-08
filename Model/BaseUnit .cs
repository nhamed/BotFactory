using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common;
using BotFactory.Interface;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    abstract public class BaseUnit : BuildableUnit , IBaseUnit 
    {

        private double _vitesse;
        public string Nom {get; set;}       
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinates CurrentPos { set; get; }
       
        public double Vitesse
        {
            get
            {
                return _vitesse;
            }
            set
            {
                Vitesse = 1;
            }


        }   
        public BaseUnit () {}
        public BaseUnit(string nom , int vitesse) 
        {
            this.Nom = nom;
            this._vitesse = vitesse;
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
                double temp = (v.Length(t)/ _vitesse);
              
                return temp;
            }
            else
            {
                return 0;
            }
        }

    }
}
