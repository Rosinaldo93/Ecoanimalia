using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
    public class Vacuna
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

        int numero_vacuna;
        public int Numero_vacuna
        {
            get { return numero_vacuna; }
            set { numero_vacuna = value; }
        }

        DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        string observacion;
        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public Vacuna() { }
        Decimal precio_Vacuna;

        public Decimal Precio_Vacuna
        {
            get { return precio_Vacuna; }
            set { precio_Vacuna = value; }
        }

       
        public override string ToString()
        {
            return base.ToString();
        }
       
    }
}
