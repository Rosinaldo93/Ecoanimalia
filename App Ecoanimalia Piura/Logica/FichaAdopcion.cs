using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
    public class FichaAdopcion
    {
        int id;
       public int Id
        {
            get { return id; }
            set { id = value; }
        }

        Persona persona;
        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        
        

        string observaciones;
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        DateTime fec_adp;
        public DateTime Fec_adp
        {
            get { return fec_adp; }
            set { fec_adp = value; }
        }
        String rel_res;

        public String Rel_res
        {
            get { return rel_res; }
            set { rel_res = value; }
        }

        public FichaAdopcion() { }

        

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
