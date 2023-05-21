using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojistenych
{
    class Pojisteny
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int TelefoniCislo { get; set; }

        public Pojisteny(string jmeno, string prijmeni, int vek, int telefoniCislo) 
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefoniCislo = telefoniCislo;
        }
       
        public override string ToString()
        {
            return this.Jmeno + "\t" + this.Prijmeni + "\t" + this.Vek + "\t" + this.TelefoniCislo;
        }
        

    }
}
