using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando.Mosconi
{
    internal class Telecomando
    {
        //attributi
        private string produttore;
        private string modello;
        private string modFunc;
        private bool stato=false;
        private int volume=0;
        private int canale=0;

        //costruttori
        public Telecomando(string Produttore, string Modello, string ModalitaFunzionamento)
        {
            produttore = Produttore;
            modello = Modello;
            modFunc = ModalitaFunzionamento;
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
            volume +=1;
        }
        public void diminuisciVolume()
        {
            volume -= 1;
        }
        public void setCanale(int c1)
        {
            canale = c1;
        }
        public bool getStato()
        {
            return stato;
        }
        public int getVolume()
        {
            return volume;
        }
        public int getCanale()
        {
            return canale;
        }

    }
}
