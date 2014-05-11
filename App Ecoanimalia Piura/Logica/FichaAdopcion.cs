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

        int estado;
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        string rel_res;
        public string Rel_res
        {
            get { return rel_res; }
            set { rel_res = value; }
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

        public FichaAdopcion() { }

        public FichaAdopcion(int i, Persona p, Usuario u, int e, string rr, string o,DateTime fa) {

            id = i;
            persona = p;
            usuario = u;
            estado = e;
            rel_res = rr;
            observaciones = o;
            fec_adp = fa;
        }

        public FichaAdopcion(Persona p, Usuario u, int e, string rr, string o, DateTime fa)
        {
            persona = p;
            usuario = u;
            estado = e;
            rel_res = rr;
            observaciones = o;
            fec_adp = fa;
        }

        public FichaAdopcion(int i)
        {
            id = i;
           
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
