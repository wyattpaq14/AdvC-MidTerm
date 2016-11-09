using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    //class for automobiles
    public class Automobile : Vehicle


    {
        private string transType;

        public Automobile(string vType, string avgSpeed, string transType) : base(vType, avgSpeed) //call base class
        {
            this.TransType = transType;
        }



        public string TransType
        {
            get
            {
                return transType;
            }
            set
            {
                transType = value;
            }
        }


        public override string displayInfo()//overrides the display method
        {
            return base.displayInfo
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                () + "\n" + "Transmission type is: " + this.TransType;
        }
    }
}
