using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;
using System.Windows.Forms;

namespace App_Ecoanimalia_Piura.Negocio
{
   public class NImagenMascota{
    

       public List<ImagenMascota> N_listar_imagenes(int serie_mascota)
        {
            List<ImagenMascota> masco = new DImagenMascota().D_listar_imagenes(serie_mascota);
           return masco;

       }
       public int N_Registrar_imagen(String descripcion, PictureBox imagen, int id_mascota)
        {
            ImagenMascota im= new ImagenMascota();
            im.Descripcion = descripcion;
            Mascota m = new Mascota();
            m.Serie = id_mascota;
            im.Mascota = m;
            im.Imagen = imagen;


            int band = new DImagenMascota().D_registrar_imgmasc(im);
            return band;
        }
       public void N_Ver_Imagen(PictureBox imagen, int id)
       {
           DImagenMascota m = new DImagenMascota();
           m.VerImagen(imagen, id);
       }
        public int N_asignar_imagen(Mascota mascota,string descripcion)
        {
           ImagenMascota imgM= new ImagenMascota();
            imgM.Mascota=mascota;
            imgM.Descripcion=descripcion;


            int band = new DImagenMascota().D_registrar_imgmasc(imgM);
            return band;
        }

        public int N_modificar_imagen_descripcion(int id,string descripcion)
        {
            ImagenMascota imgM = new ImagenMascota();
            imgM.Id = id;
            
            imgM.Descripcion = descripcion;

            int band = new DImagenMascota().D_modificar_imgmasc_descrip(imgM);
            return band;
        }

        public int N_eliminar_imagen(int id)
        {
            ImagenMascota imgM = new ImagenMascota();
            imgM.Id = id;
            int band = new DImagenMascota().D_eliminar_imgmasc(imgM);
            return band;
        }
    }
}
