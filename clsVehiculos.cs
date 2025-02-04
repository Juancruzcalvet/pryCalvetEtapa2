﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Sin esto no podemos referenciar pct

namespace pryCalvetEtapa2
{
    internal class clsVehiculos
    {
        public PictureBox pctAuto; //Instanciamos para poder asignar imagen
        public PictureBox pctAvion;
        public PictureBox pctBarco;

        public void CrearAuto()
        {
            pctAuto = new PictureBox(); //tendra imagen
            pctAuto.SizeMode = PictureBoxSizeMode.StretchImage;//estara estirada
            pctAuto.Width = 200;//ancho
            pctAuto.Height = 200;//largo
            pctAuto.BackColor = Color.Transparent;//fondo transparente
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "auto.png");//ruta
            pctAuto.ImageLocation = ruta;//su imagen corresponde a la ruta anteriormente dicha
        }

        public void CrearAvion()
        {
            pctAvion = new PictureBox();
            pctAvion.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAvion.Width = 200;
            pctAvion.Height = 200;
            pctAvion.BackColor = Color.Transparent;
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "avion.png");
            pctAvion.ImageLocation = ruta;
        }

        public void CrearBarco()
        {
            pctBarco = new PictureBox();
            pctBarco.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBarco.Width = 200;
            pctBarco.Height = 200;
            pctBarco.BackColor = Color.Transparent;
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "barco.png");
            pctBarco.ImageLocation = ruta;
        }
    }
}
