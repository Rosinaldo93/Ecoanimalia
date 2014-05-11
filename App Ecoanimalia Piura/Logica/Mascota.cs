using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
   public class Mascota
    {

        

        TipoMascota tipomascota;
        public TipoMascota Tipomascota
        {
            get { return tipomascota; }
            set { tipomascota = value; }
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

        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string raza;
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        string sexo;
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        string edad;
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        String esterilizado;
        public String Esterilizado
        {
            get { return esterilizado; }
            set { esterilizado = value; }
        }

        DateTime fecha_esterilizacion;

        public DateTime Fecha_esterilizacion
        {
            get { return fecha_esterilizacion; }
            set { fecha_esterilizacion = value; }
        }
        int serie;
        public int Serie
        {
            get { return serie; }
            set { serie = value; }
        }



        Usuario ser_usu;
        public Usuario Ser_usu
        {
            get { return ser_usu; }
            set { ser_usu = value; }
        }

        

        FichaTemporal fic_temporal;
        public FichaTemporal Fic_tem
        {
            get { return fic_temporal; }
            set { fic_temporal = value; }
        }

        DateTime fecha_ingreso;
        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }


        DateTime fecha_adopcion;
        public DateTime Fecha_adopcion
        {
            get { return fecha_adopcion; }
            set { fecha_adopcion = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
