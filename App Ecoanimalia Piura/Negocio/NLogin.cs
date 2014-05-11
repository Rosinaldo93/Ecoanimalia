using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Negocio
{
   public class NLogin
   {
       #region
       public Boolean verificar_sesion(String usuario, String clave)
       {
           Usuario login = new Usuario();
           CCryptorEngine encri = new CCryptorEngine();

           login.Usuario1 = usuario;
           login.Contrasena = encri.Encriptar(clave);
           Boolean band = new DLogin().iniciar_sesion(login);
           return band;
       }
       public Usuario ver_tipo(String usuario, String clave)
       {
           Usuario login = new Usuario();
           CCryptorEngine encri = new CCryptorEngine();

           login.Usuario1 = usuario;
           login.Contrasena = encri.Encriptar(clave);
           Usuario band = new DLogin().D_ver_tipo(login);
           return band;
       }
       public Boolean N_consultar_admin()
       {
           Boolean val = new DLogin().D_consultar_admin();
           return val;
       }
       #endregion
   }
}
