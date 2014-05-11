using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Ecoanimalia_Piura.Logica
{
    public class Usuario
    {
        int serie;
        public int Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        Usuario encargado;
        public Usuario Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }

        string usuario;
        public string Usuario1
        {
            get { return usuario; }
            set { usuario = value; }
        }

        string contrasena;
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        String tipo;
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        String sexo;
        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        string dni;
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        string referencia;
        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        int movistar;
        public int Movistar
        {
            get { return movistar; }
            set { movistar = value; }
        }

        int claro;
        public int Claro
        {
            get { return claro; }
            set { claro = value; }
        }

        int nextel;
        public int Nextel
        {
            get { return nextel; }
            set { nextel = value; }
        }

        int telefono;
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
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

        string ocupacion;
        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }
        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Usuario() { }

       

        public Usuario(int s, string c)
        {
            serie = s;
            codigo = c;
          

        }

        public override string ToString()
        {
            return "DNI: "+dni+" - "+nombres+" "+apellidos;
        }

    }
}