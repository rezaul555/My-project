using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VehicleeApp
{
    class Vehicle
    {
        public Vehicle(string vehicleName, int registrationNo)
        {
           this.VehicleName = vehicleName;
           this. RegistrationNo = registrationNo;
           
        }
        private string vehicleName;
        private int registrationNo;
        private double speed; 
        private int counter = 0;
        private double totalSpeed = 0;
        private double Maxspeed=0 ;
        private double Minspeed=0;


        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }

        public int RegistrationNo
        {
            get { return registrationNo; }
            set { registrationNo = value; }
        }

        public  Vehicle(double speed)
        {
            Speed = speed;
            counter = counter + 1;
            totalSpeed = totalSpeed + speed;

        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double MaxSpeed()
        {
            if (Maxspeed > Speed)
            {
               Maxspeed=Speed;
            }
            return Maxspeed;
        }
       

         public double MinSpeed()
        {
            if (Minspeed < Speed)
            {
               Minspeed=Speed;
            }
            return Minspeed;
        }
     

         public double AverageSpeed()
         {
          
             return totalSpeed/counter;
         }

     
    }


}
