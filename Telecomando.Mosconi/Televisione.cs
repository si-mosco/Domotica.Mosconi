using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando.Mosconi
{
    public class Televisione
    {
        //attributi
        private string modello;
        private string produttore;
        private string[] conettori;
        private bool stato;
        private int canale;
        private int volume;
        private string risoluzione;
        public string id;

        //costruttori
        public Televisione(string produttore1, string modello1, string connettori, string id1)
        {
            produttore = produttore1;
            modello = modello1;
            id = id1;
        }
        public Televisione(string modello1)
        {
            modello = modello1;
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
        public void setCanale(int n)
        {
            canale = n;
        }
        public void setStato(bool n)
        {
            stato = n;
        }
        public void setVolume(int n)
        {
            volume = n;
        }
        public string getModello()
        {
            return modello;
        }
        public string getProduttore()
        {
            return produttore;
        }
        public bool getStato()
        {
            return stato;
        }
        public int getCanale()
        {
            return canale;
        }
        public int getVolume()
        {
            return volume;
        }
        public string getRisoluzione()
        {
            return risoluzione;
        }
        public string getId()
        {
            return id;
        }
    }
}
