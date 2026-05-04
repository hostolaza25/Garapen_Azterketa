using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_5
{
     class Porra
    {
        private string izena, irabazlea, finalista, goleatzailea;
        private int puntuak;

        public string Izena { get => izena; set => izena = value; }
        public string Irabazlea { get => irabazlea; set => irabazlea = value; }
        public string Finalista { get => finalista; set => finalista = value; }
        public string Goleatzailea { get => goleatzailea; set => goleatzailea = value; }

        public int Puntuak { get => puntuak; set => puntuak = value; }

        public Porra(string i, string ir, string fi, string go, int p) {
            this.izena = i;
            this.irabazlea = ir;
            this.finalista = fi;
            this.goleatzailea= go;
            this.puntuak= p;    
        }
       
        public  string Pantailaratu()
        {
            return "TALDEA=" + izena + ", bere IRABAZLEA=" + irabazlea + ", beste FINALISTA=" + finalista + ", GOLEATZAILEA=" + goleatzailea + " eta PUNTUAK=" + puntuak;

        }
        public  override string ToString()
        {
            return izena+"-"+irabazlea+"-"+finalista+"-"+goleatzailea+"-"+puntuak;
        }
        public int AsmatuIrabazlea()
        {
            return (puntuak + 25);
        }
        public int AsmatuBiFinalistak()
        {
            return (puntuak + 20);
        }
        public int Goleko()
        {
            return (puntuak + 3);
        }

    }
}
