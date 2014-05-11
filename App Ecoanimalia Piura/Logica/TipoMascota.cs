using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
   public class TipoMascota
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public TipoMascota() { }
        public TipoMascota(int i, string d) {
            id = i;
            descripcion = d;
        }
        public TipoMascota(int i) {
            id = i;
        }

        public override string ToString()
        {
            return descripcion;
        }

    }
}
