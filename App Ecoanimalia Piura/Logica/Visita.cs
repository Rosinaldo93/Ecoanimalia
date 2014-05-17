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
        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        

        public Visita() { }

        

        
    }
}
