using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {

        private int codiceProdotto;
        public string nomeProdotto;
        public string descrizioneProdotto;
        public float prezzoNoIVA;
        public float percentualeIVA;
        public float prezzoIvato;
        public Prodotto(string nomeProdotto, string descrizioneProdotto, float prezzoNoIVA, float percentualeIVA)
        {
            Random rnd = new Random();
            int codiceProdotto = rnd.Next();
            this.codiceProdotto = codiceProdotto;

            this.nomeProdotto = nomeProdotto;
            this.descrizioneProdotto = descrizioneProdotto;
            this.prezzoNoIVA = prezzoNoIVA;
            this.percentualeIVA = percentualeIVA;
        }


        public string calcPrezzoIvato()
        {
            float prezzoIvato = (prezzoNoIVA/100) * percentualeIVA + prezzoNoIVA;

            return prezzoIvato.ToString("N2");


        }


        public int GetCodiceProdotto()
        {

            return codiceProdotto;

        }


       
    }
}

