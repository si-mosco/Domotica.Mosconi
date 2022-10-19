using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando.Mosconi
{
    public class Termostato
    {
        //attributi
        private bool stato;
        private double temperatura;
        private string modello;
        private string produttore;
        private string data;
        private int ndiserie;

        //costruttori
        public Termostato(string Modello, string Produttore, string Data, int NumDiSerie)
        {
            modello = Modello;
            produttore = Produttore;
            data = Data;
            ndiserie = NumDiSerie;
        }

        //metodi
        public void accendi()
        {
            stato = true;
        }
        public void spegni()
        {
            stato = false;
        }
        public void aumentaTemperatura()
        {
            if (temperatura<40)
                temperatura += 1;
        }
        public void diminuisciTemperatura()
        {
            if (temperatura >= 1)
                temperatura -= 1;
        }
        public bool getStato()
        {
            return stato;
        }
        public double getTemperatura()
        {
            return temperatura;
        }
        public string getModello()
        {
            return modello;
        }
        public string getProduttore()
        {
            return produttore;
        }
        public string getData()
        {
            return data;
        }
        public int getNdiserie()
        {
            return ndiserie;
        }
    }
}
