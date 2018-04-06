using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tijolo
    {
        public Tijolo(){ }
        public Tijolo(Tijolo tijoloex)
        {
            this.material = tijoloex.material;
            this.date = tijoloex.date;
            this.fabrica = tijoloex.fabrica;
            this.serial = tijoloex.serial;
        }
        public Tijolo(string matrial, DateTime date, string fabrica, int serial)
        {
            this.material = matrial;
            this.date = date;
            this.fabrica = fabrica;
            this.serial = serial;
        }


        public string material { get; set; }
        public DateTime date { get; set; }
        public string fabrica { get; set; }
        public int serial { get; set; }

    }
}
