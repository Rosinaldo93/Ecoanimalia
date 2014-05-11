using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Ecoanimalia_Piura.Logica
{
    public class ImagenMascota
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        Mascota mascota;
        public Mascota Mascota
        {
            get { return mascota; }
            set { mascota = value; }
        }

        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        PictureBox imagen;

        public PictureBox Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

    }
}
