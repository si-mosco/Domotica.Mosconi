using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando.Mosconi
{
    public class Telecomando
    {
        //attributi
        private string produttore;
        private string modello;
        private string modFunc;
        private bool stato=false;
        private Televisione televisione;

        //costruttori
        public Telecomando(string Produttore, string Modello, string ModalitaFunzionamento)
        {
            produttore = Produttore;
            modello = Modello;
            modFunc = ModalitaFunzionamento;
        }
        public Telecomando(string Produttore, string Modello, string ModalitaFunzionamento, Televisione televisione1)
        {
            produttore = Produttore;
            modello = Modello;
            modFunc = ModalitaFunzionamento;
            televisione = televisione1;
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
        public void aumentaVolume()
        {
            if (televisione != null)
                if (televisione.getVolume() <= 100)
                    televisione.setVolume(televisione.getVolume()+1);
        }
        public void diminuisciVolume()
        {
            if (televisione != null)
                if (televisione.getVolume() >= 1)
                    televisione.setVolume(televisione.getVolume() - 1);
        }
        public void setCanale(int c1)
        {
            if (televisione != null)
                if (c1 > 0 && c1 < 999)
                    televisione.setCanale(c1);
        }
        public void setTelevisione(Televisione tv1)
        {
            televisione = tv1;
        }
        public bool getStato()
        {
            return stato;
        }
        public Televisione getTelevisione()
        {
            return televisione;
        }
    }
}
