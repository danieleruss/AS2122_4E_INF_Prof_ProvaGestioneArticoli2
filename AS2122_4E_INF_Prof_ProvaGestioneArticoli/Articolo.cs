using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_Prof_ProvaGestioneArticoli
{
    class Articolo
    {
        // TODO: (8) aggiungere attributi privati di Articolo
        // ...
        private int codice;
        private string descrizione;
        private string unitaMisura;
        private double prezzo;

        // TODO: (9) aggiungere property di sola lettura dei dati necessari all'esterno di Articolo
        // ...

        public int Codice
        {
            get { return codice; }
        }
        public string Descrizione
        {
            get { return descrizione; }
        }

        public string UnitaMisura
        {
            get { return unitaMisura; }
        }

        public double Prezzo
        {
            get { return codice; }
        }

        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            // ...
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaMisura = unitaMisura;
            this.prezzo = prezzo;
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }
    }
}