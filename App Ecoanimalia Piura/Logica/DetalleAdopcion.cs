using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
    public class DetalleAdopcion
    {

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

        public DetalleAdopcion() { }

        public DetalleAdopcion(Mascota m, FichaAdopcion fa) {
            mascota = m;
            fichaadopcion = fa;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
