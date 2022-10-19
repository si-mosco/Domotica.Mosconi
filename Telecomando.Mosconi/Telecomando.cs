using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telecomando.Mosconi
{
    public class Telecomando
    {
        //attributi
        private string produttore;
        private string modello;
        private string modFunc;
        private Televisione televisione;
        public string id;

        //costruttori
        public Telecomando(string Produttore, string Modello, string ModalitaFunzionamento)
        {
            produttore = Produttore;
            modello = Modello;
            modFunc = ModalitaFunzionamento;
        }
        public Telecomando(string Produttore, string Modello, string ModalitaFunzionamento, Televisione televisione1, string Id)
        {
            produttore = Produttore;
            modello = Modello;
            modFunc = ModalitaFunzionamento;
            televisione = televisione1;
            id = Id;
        }

        //metodi
        public void accendi()
        {
            televisione.setStato(true);
        }
        public void spegni()
        {
            televisione.setStato(false);
        }
        public void aumentaVolume()
        {
            if (televisione != null)
                if (televisione.getVolume() <= 100)
                    televisione.setVolume(televisione.getVolume() + 1);
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
        public Televisione getTelevisione()
        {
            return televisione;
        }

        public string getId()
        {
            return id;
        }
    }
}
