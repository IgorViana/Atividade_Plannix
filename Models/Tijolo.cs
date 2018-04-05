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
        public Tijolo(string Matrial, DateTime Date, string Fabrica, int Serial)
        {
            material = Matrial;
            date = Date;
            fabrica = Fabrica;
            serial = Serial;
        }


        public string material { get; set; }
        public DateTime date { get; set; }
        public string fabrica { get; set; }
        public int serial { get; set; }

    }
}
