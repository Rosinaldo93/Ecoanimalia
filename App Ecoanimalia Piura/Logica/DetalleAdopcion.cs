using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
    public class DetalleAdopcion
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

        FichaAdopcion fichaadopcion;
        public FichaAdopcion Fichaadopcion
        {
            get { return fichaadopcion; }
            set { fichaadopcion = value; }
        }
        String nombre_adoptarse;

        public String Nombre_adoptarse
        {
            get { return nombre_adoptarse; }
            set { nombre_adoptarse = value; }
        }
        int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        String observacion;

        public String Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        public DetalleAdopcion() { }

        


        public override string ToString()
        {
            return base.ToString();
        }

    }
}
