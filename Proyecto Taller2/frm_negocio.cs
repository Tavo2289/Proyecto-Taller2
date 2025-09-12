using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller2
{
    public partial class frm_negocio : Form
    {
        public frm_negocio()
        {
            InitializeComponent();
        }

        private void frm_negocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new CN_negocio().ObtenerLogo(out obtenido);

            if (obtenido)
            {
                pic_logo.Image = ByteToImage(byteimage);
            }

            Negocio datos = new CN_negocio().ObtenerDatos();

            txt_nombre.Text = datos.nombre;
            txt_ruc.Text = datos.ruc;
            txt_direccion.Text = datos.direccion;
        }


        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        private void btn_subirLogo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                {
                    pic_logo.Image = ByteToImage(byteimage);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                nombre = txt_nombre.Text,
                ruc = txt_ruc.Text,
                direccion = txt_direccion.Text
            };

            bool respuesta = new CN_negocio().guardarDatos(obj, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}