using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Location  //composition
    {
        private Reserve rsv1;
        private Disabled oku1;

        public Location(Reserve rsv1) {
            this.rsv1 = rsv1;
        }

        public Location( Disabled oku1) {
            
            this.oku1 = oku1;

        
        }

        public void Cetak1() {
            


            MessageBox.Show("Parking= " + rsv1.getRsv());
            MessageBox.Show("Level = " + rsv1.getLevel());
            MessageBox.Show("Lot = " + rsv1.getLot());

           
            
           
        }

        public void Cetak2() {
        
         MessageBox.Show("Parking= " + oku1.getOku());
         MessageBox.Show("Level = " + oku1.getLevel());
         MessageBox.Show("Lot = " + oku1.getLot());
        
        }


    }
}
