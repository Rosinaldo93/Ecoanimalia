using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
   public class Persona
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
      
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        string sexo;
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        string rpm;

        public string Rpm
        {
            get { return rpm; }
            set { rpm = value; }
        }

        string edad;
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        string facebook;
        public string Facebook
        {
            get { return facebook; }
            set { facebook = value; }
        }

        int tel_mov;
        public int Tel_mov
        {
            get { return tel_mov; }
            set { tel_mov = value; }
        }

        int tel_claro;
        public int Tel_claro
        {
            get { return tel_claro; }
            set { tel_claro = value; }
        }

        string tel_nex;
        public string Tel_nex
        {
            get { return tel_nex; }
            set { tel_nex = value; }
        }
        
        int tel_casa;
        public int Tel_casa
        {
            get { return tel_casa; }
            set { tel_casa = value; }
        }
       
        string hor_disp;
        public string Hor_disp
        {
            get { return hor_disp; }
            set { hor_disp = value; }
        }

        string rel_rsc;
        public string Rel_rsc
        {
            get { return rel_rsc; }
            set { rel_rsc = value; }
        }
        

        public Persona() { }

       
        
        public override string ToString()
        {
            return dni;
        }
    }
}
