using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Negocio
{
   public class NUsuario
    {
       public int N_Registrar_Usuario_conacceso(int serie,String codigo, String usu, String contra, string nom, string ape, String sexo, string dni, string dire, string refe, int movi, int claro, int next, int tele, string email, string face, string ocupa, string tipo, string esta,Usuario encar)
       {
           Usuario usuario = new Usuario();
           usuario.Serie = serie;
           usuario.Codigo = codigo;
           usuario.Encargado = (Usuario)encar;
           usuario.Usuario1 = usu;
           CCryptorEngine cr = new CCryptorEngine();
           usuario.Contrasena = cr.Encriptar(contra);
           usuario.Nombres = nom;
           usuario.Apellidos = ape;
           usuario.Sexo = sexo;
           usuario.Dni = dni;
           usuario.Direccion = dire;
           usuario.Referencia = refe;
           usuario.Movistar = movi;
           usuario.Claro = claro;
           usuario.Telefono = tele;
           usuario.Nextel = next;
           usuario.Email = email;
           usuario.Facebook = face;
           usuario.Ocupacion = ocupa;
           usuario.Estado = esta;
           usuario.Tipo = tipo;

           int band = new DUsuario().D_registrar_Usuario_Admin(usuario);
           return band;
       }
       public int N_Registrar_Usuario_admin(int serie ,String codigo,String usu,String contra,string nom,string ape,String sexo,string dni,string dire,string refe,int movi,int claro,int next ,int tele,string email,string face ,string ocupa ,string tipo,string esta)
       {
           Usuario usuario = new Usuario();
           usuario.Serie = serie;
           usuario.Codigo = codigo;
           usuario.Usuario1 = usu;
           CCryptorEngine cr = new CCryptorEngine();
           usuario.Contrasena = cr.Encriptar(contra);
           usuario.Nombres = nom;
           usuario.Apellidos = ape;
           usuario.Sexo = sexo;
           usuario.Dni = dni;
           usuario.Direccion = dire;
           usuario.Referencia = refe;
           usuario.Movistar = movi;
           usuario.Claro = claro;
           usuario.Telefono = tele;
           usuario.Nextel = next;
           usuario.Email = email;
           usuario.Facebook = face;
           usuario.Ocupacion = ocupa;
           usuario.Estado = esta;
           usuario.Tipo = tipo;

           int band = new DUsuario().D_registrar_Usuario_Admin(usuario);
           return band;
       }
       public int N_Registrar_Usuario_sinacceso(int serie,String codigo, string nom, string ape, String sexo, string dni, string dire, string refe, int movi, int claro, int next, int tele, string email, string face, string ocupa, string tipo, string esta,Usuario encar)
       {
           Usuario usuario = new Usuario();
           usuario.Serie = serie;
           usuario.Codigo = codigo;
           usuario.Encargado = (Usuario)encar;
           usuario.Nombres = nom;
           usuario.Apellidos = ape;
           usuario.Sexo = sexo;
           usuario.Dni = dni;
           usuario.Direccion = dire;
           usuario.Referencia = refe;
           usuario.Movistar = movi;
           usuario.Claro = claro;
           usuario.Telefono = tele;
           usuario.Nextel = next;
           usuario.Email = email;
           usuario.Facebook = face;
           usuario.Ocupacion = ocupa;
           usuario.Estado = esta;
           usuario.Tipo = tipo;

           int band = new DUsuario().D_registrar_Usuario_Admin(usuario);
           return band;
       }
       public int N_Modificar_Usuario_perfil_admin(String codigo, String usu, String contra, string nom, string ape, String sexo, string dni, string dire, string refe, int movi, int claro, int next, int tele, string email, string face, string ocupa, string tipo, string esta,int serie)
       {
           Usuario usuario = new Usuario();
           usuario.Codigo = codigo;
           usuario.Usuario1 = usu;
           CCryptorEngine cr = new CCryptorEngine();
           usuario.Contrasena = cr.Encriptar(contra);
           usuario.Nombres = nom;
           usuario.Apellidos = ape;
           usuario.Sexo = sexo;
           usuario.Dni = dni;
           usuario.Direccion = dire;
           usuario.Referencia = refe;
           usuario.Movistar = movi;
           usuario.Claro = claro;
           usuario.Telefono = tele;
           usuario.Nextel = next;
           usuario.Email = email;
           usuario.Facebook = face;
           usuario.Ocupacion = ocupa;
           usuario.Estado = esta;
           usuario.Tipo = tipo;
           usuario.Serie = serie;



           int band = new DUsuario().D_modificar_Usuario_Admin(usuario);
           return band;
       }
       public int N_Modificar_Usuario_sinacceso(String codigo, string nom, string ape, String sexo, string dni, string dire, string refe, int movi, int claro, int next, int tele, string email, string face, string ocupa, string tipo, string esta, Usuario encar,int serie)
       {

           Usuario usuario = new Usuario();
           usuario.Serie = serie;
           usuario.Codigo = codigo;
           usuario.Encargado = (Usuario)encar;
           usuario.Nombres = nom;
           usuario.Apellidos = ape;
           usuario.Sexo = sexo;
           usuario.Dni = dni;
           usuario.Direccion = dire;
           usuario.Referencia = refe;
           usuario.Movistar = movi;
           usuario.Claro = claro;
           usuario.Telefono = tele;
           usuario.Nextel = next;
           usuario.Email = email;
           usuario.Facebook = face;
           usuario.Ocupacion = ocupa;
           usuario.Estado = esta;
           usuario.Tipo = tipo;

           int band = new DUsuario().D_modificar_Usuario_Admin(usuario);
           return band;
       }
       public int N_Modificar_Usuario_conacceso(String codigo, String usu, String contra, string nom, string ape, String sexo, string dni, string dire, string refe, int movi, int claro, int next, int tele, string email, string face, string ocupa, string tipo, string esta, Usuario encar,int serie)
       {
           Usuario usuario = new Usuario();
           usuario.Serie = serie;
           usuario.Codigo = codigo;
           usuario.Encargado = (Usuario)encar;
           usuario.Usuario1 = usu;
           CCryptorEngine cr = new CCryptorEngine();
           usuario.Contrasena = cr.Encriptar(contra);
           usuario.Nombres = nom;
           usuario.Apellidos = ape;
           usuario.Sexo = sexo;
           usuario.Dni = dni;
           usuario.Direccion = dire;
           usuario.Referencia = refe;
           usuario.Movistar = movi;
           usuario.Claro = claro;
           usuario.Telefono = tele;
           usuario.Nextel = next;
           usuario.Email = email;
           usuario.Facebook = face;
           usuario.Ocupacion = ocupa;
           usuario.Estado = esta;
           usuario.Tipo = tipo;

           int band = new DUsuario().D_modificar_Usuario_Admin(usuario);
           return band;
       }
       public Usuario N_ver_Usuarioxserie(int serie)
       {

           Usuario band = new DUsuario().D_ver_Usuarioxserie(serie);
           return band;
       }
       public Usuario N_ver_Usuarioxcodigo(String cod)
       {

           Usuario band = new DUsuario().D_ver_Encargado_xcodigo(cod);
           return band;
       }
       public int N_cambiar_contra_usuario(int serie,String nueva)
       {
           Usuario a = new Usuario();
           a.Serie = serie;
           CCryptorEngine cr = new CCryptorEngine();
           a.Contrasena = cr.Encriptar(nueva);
           int band = new DUsuario().D_cambiar_contra_usuario(a);
           return band;
       }
       public List<Usuario> N_listar_usuarios()
       {
           List<Usuario> lista = new DUsuario().D_mostrar_usuarios();
           return lista;
       }
       public int N_Ultima_Serie()
       {
           int a = new DUsuario().ultima_serie();
           return a;
       }
       public int N_eliminar_usuario_voluntario(int serie)
       {
           int band = new DUsuario().D_Eliminar_usuario_voluntario(serie);
           return band;
       }
       public List<Usuario> N_listar_soloVoluntarios()
       {
           List<Usuario> lista = new DUsuario().D_mostrar_solo_Voluntarios();
           return lista;
       }
    }
}
