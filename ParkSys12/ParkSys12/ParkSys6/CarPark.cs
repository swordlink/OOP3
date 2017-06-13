using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class CarPark
    {
        public static string[] Car = new string[10] ;
        private static int CurrentCar=0;
        public static int num = 2;
        public CarPark()
        { }

        public static void SavePlate(string Plat)
        {
            Car[CurrentCar]=Plat;
            CurrentCar=CurrentCar+1;
        }

        public static string PrintNoPlat()
        {
            return  Car[CurrentCar];

        }

      

                    
    }
}
