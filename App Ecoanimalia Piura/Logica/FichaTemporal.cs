using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
    public class FichaTemporal
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        TipoMascota tipomascota;
        public TipoMascota Tipomascota
        {
            get { return tipomascota; }
            set { tipomascota = value; }
        }

        Persona persona;
        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        string tamano;
        public string Tamano
        {
            get { return tamano; }
            set { tamano = value; }
        }

        string estado;
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        String observaciones;

        public String Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        Usuario voluntario;

        public Usuario Voluntario
        {
            get { return voluntario; }
            set { voluntario = value; }
        }
        public override string ToString()
        {
            return "DNI : " + persona.Dni + " - " + persona.Nombre + " " + persona.Apellidos;
        }
    }
}
