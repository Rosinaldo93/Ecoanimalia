using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
   public class HistorialClinico
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

        DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        decimal precio;
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }


       public HistorialClinico() { }

       public HistorialClinico(int i, Mascota m, DateTime f, string d, decimal p) {
           id = i;
           mascota = m;
           fecha = f;
           descripcion = d;
           precio = p;
       }

       public HistorialClinico(Mascota m, DateTime f, string d, decimal p)
       {
           mascota = m;
           fecha = f;
           descripcion = d;
           precio = p;

       }

       public HistorialClinico(int i)
       {
           id = i;
          
       }

       public override string ToString()
       {
           return base.ToString();
       }



    }
}
