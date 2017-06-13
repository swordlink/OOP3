using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Parking
    {

        private string level;
        private string lot;

        public Parking()
        {

            level = "";
            lot = "";
        }

        public Parking(string level, string lot) {

            this.level = level;
            this.lot = lot;
        }

        public virtual void Print() {

            Console.WriteLine("level" + level);
            Console.WriteLine("lot" + lot);
        }

        public string getLevel() {

            return level;
        }

        public string getLot() {

            return lot;
        }
    }
}
