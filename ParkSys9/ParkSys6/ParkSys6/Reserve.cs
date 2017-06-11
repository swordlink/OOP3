using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Reserve : Parking
    {
        private string rsv; // Reserved Parking

        public Reserve(string rsv, string level, string lot) : base(level, lot) {

            this.rsv = rsv;
        
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Reserve: " + rsv + "\n");
        }

        public string getRsv() {

            return rsv;
        }

    }
}


