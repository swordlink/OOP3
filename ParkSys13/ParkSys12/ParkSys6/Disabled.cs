using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Disabled : Parking
    {
         private string oku; // Disabled Parking
         public static string[] lot = new string[2] { "A1", "A2",};

        public Disabled(string oku, string level, string lot) : base(level, lot) {

            this.oku = oku;
        
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Disabled: " + oku + "\n");
        }

        public string getOku() {

            return oku;
        }
    }
}
