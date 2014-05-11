using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
   public class Visita
    {
         int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        Mascota mascota;
        public Mascota Mascota
        {
            get { return mascota; }
            set { mascota = value; }
        }

        int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        string observacion;
        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public Visita() { }

        public Visita(int i, Mascota m, int n, string o) {

            id = i;
            mascota = m;
            numero = n;
            observacion = o;

        }

        public Visita(Mascota m, int n, string o)
        {
            mascota = m;
            numero = n;
            observacion = o;

        }

        public Visita(int i)
        {
            id = i;
        }
    }
}
