using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Negocio
{
    public class NFichaTemporal
    {


        public int registrar_temporarl(TipoMascota tipo, String tamaño, String nombre, String apellido, String dni, String direccion, String sexo, String edad, String email, String facebook, String rpm, int movistar, int claro, String nextel, int casa, String horario, string observa, String esta,Usuario voluntario)
        {
            Persona p = new Persona();
            p.Nombre = nombre;
            p.Apellidos = apellido;
            p.Dni = dni;
            p.Direccion = direccion;
            p.Sexo = sexo;
            p.Edad = edad;
            p.Email = email;
            p.Facebook = facebook;
            p.Rpm = rpm;
            p.Tel_mov = movistar;
            p.Tel_claro = claro;
            p.Tel_nex = nextel;
            p.Tel_casa = casa;
            p.Hor_disp = horario;
            FichaTemporal ficha = new FichaTemporal();
            ficha.Tipomascota = (TipoMascota)tipo;
            ficha.Persona = (Persona)p;
            ficha.Tamano = tamaño;
            ficha.Observaciones = observa;
            ficha.Estado = esta;
            ficha.Voluntario = (Usuario)voluntario;
            int band = new DFichaTemporal().D_registrar_fichaTemporal(ficha);
            return band;
        }

        public List<FichaTemporal> N_Listar_FichaTemporal()
        {
            List<FichaTemporal> lista = new DFichaTemporal().D_Listar_FichaTemporal();
            return lista;
        }
        public List<FichaTemporal> N_Listar_FichaTemporal_Activos()
        {
            List<FichaTemporal> lista = new DFichaTemporal().D_Listar_FichaTemporal_activos();
            return lista;
        }
        public int N_Modificar_Ficha_Temp(TipoMascota tipo, String tamaño, String nombre, String apellido, String dni, String direccion, String sexo, String edad, String email, String facebook, String rpm, int movistar, int claro, String nextel, int casa, String horario, string observa, String esta,int id_ficha,int id_perso,Usuario voluntario)
        {
            Persona p = new Persona();
            p.Id = id_perso;
            p.Nombre = nombre;
            p.Apellidos = apellido;
            p.Dni = dni;
            p.Direccion = direccion;
            p.Sexo = sexo;
            p.Edad = edad;
            p.Email = email;
            p.Facebook = facebook;
            p.Rpm = rpm;
            p.Tel_mov = movistar;
            p.Tel_claro = claro;
            p.Tel_nex = nextel;
            p.Tel_casa = casa;
            p.Hor_disp = horario;
            FichaTemporal ficha = new FichaTemporal();
            ficha.Id = id_ficha;
            ficha.Tipomascota = (TipoMascota)tipo;
            ficha.Persona = (Persona)p;
            ficha.Tamano = tamaño;
            ficha.Observaciones = observa;
            ficha.Estado = esta;
            ficha.Voluntario = (Usuario)voluntario;
            int band = new DFichaTemporal().D_Modificar_fichaTemporal(ficha);
            return band;
        }


        //public int N_asignar_temporal(TipoMascota tipo,Persona persona, string tamano,int estado)
        //{
        //    FichaTemporal temporal = new FichaTemporal();
        //    temporal.Tipomascota = tipo;
        //    temporal.Persona = persona;
        //    temporal.Tamano = tamano;
        //    temporal.Estado = estado;


        //    int band = new DFichaTemporal().D_registrar_fichaT(temporal);
        //    return band;
        //}

        //public int N_modificar_temporal(int id, TipoMascota tipo, Persona persona, string tamano, int estado)
        //{

        //    FichaTemporal temporal = new FichaTemporal();
        //    temporal.Id = id;
        //    temporal.Tipomascota = tipo;
        //    temporal.Persona = persona;
        //    temporal.Tamano = tamano;
        //    temporal.Estado = estado;
        //    int band = new DFichaTemporal().D_modificar_fichaT(temporal);
        //    return band;
        //}

        public int N_eliminar_temporal(int id)
        {
            int band = new DFichaTemporal().D_eliminar_fichaT(id);
            return band;
        }


    }
}
