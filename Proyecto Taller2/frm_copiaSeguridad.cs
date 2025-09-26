using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO; // Necesario para la ruta de archivo
namespace Proyecto_Taller2
{
    public partial class frm_copiaSeguridad : Form
    {
        public frm_copiaSeguridad()
        {
            InitializeComponent();
        }

        private void frm_copiaSeguridad_Load(object sender, EventArgs e)
        {
            txt_nombreServidor.Text = "DESKTOP-SK0290T\\SQLEXPRESS"; // Valor por defecto para servidor local
        }





        // Asegúrate de tener la referencia al proyecto de la Capa de Negocio (BLL)
        // y los 'using' necesarios.

        private BackupManager _manager = new BackupManager();

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(true))
            {
                return; // Detiene la ejecución si hay campos de conexión vacíos
            }

            try
            {
                lblEstado.Text = "Conectando y cargando bases de datos...";

                // Llama a la Capa de Negocio
                List<string> dbs = _manager.ConectarYCargarDBs(
                    txt_nombreServidor.Text,
                    txt_nombreUsuario.Text,
                    txt_contraseña.Text
                );

                cmbBaseDatos.Items.Clear();
                foreach (string db in dbs)
                {
                    cmbBaseDatos.Items.Add(db);
                }

                if (dbs.Count > 0)
                {
                    cmbBaseDatos.SelectedIndex = 0;
                    btn_backup.Enabled = true;
                    lblEstado.Text = "Bases de datos cargadas. Listo.";
                }
                else
                {
                    lblEstado.Text = "Conexión exitosa, pero no se encontraron bases de datos de usuario.";
                }
            }
            catch (ArgumentException ex)
            {
                lblEstado.Text = "Error de validación.";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error de conexión. Revisa los datos.";
                MessageBox.Show("Error al conectar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(true))
            {
                return; // Detiene la ejecución si hay campos de conexión vacíos
            }

            btn_backup.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            lblEstado.Text = "Iniciando copia de seguridad...";

            try
            {
                DateTime startTime = DateTime.Now;

                // Llama a la Capa de Negocio
                _manager.ProcesarBackup(
                    txt_nombreServidor.Text,
                    txt_nombreUsuario.Text,
                    txt_contraseña.Text,
                    cmbBaseDatos.SelectedItem.ToString(),
                    txt_ruta.Text,
                    txt_nombreArchivo.Text
                );

                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime;

                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 100;
                lblEstado.Text = $"Copia de seguridad finalizada en {duration.TotalSeconds:F2} segundos.";
                MessageBox.Show("¡Copia de seguridad completada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                lblEstado.Text = "Error de validación.";
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                lblEstado.Text = "Error durante el respaldo.";
                MessageBox.Show("Error en la copia de seguridad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_backup.Enabled = true;
                progressBar1.Style = ProgressBarStyle.Blocks; // Asegura que vuelva a la normalidad
            }
        }

        // El código para btnRuta_Click (seleccionar carpeta) permanece en la Capa de Presentación
        private void btnRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txt_ruta.Text = fbd.SelectedPath;

                    // Lógica de presentación: Sugerir nombre de archivo
                    if (cmbBaseDatos.SelectedItem != null)
                    {
                        string dbName = cmbBaseDatos.SelectedItem.ToString();
                        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                        txt_nombreArchivo.Text = $"{dbName}_{timestamp}.bak";
                    }
                }
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia los campos de conexión
            txt_nombreServidor.Text = string.Empty;
            txt_nombreUsuario.Text = string.Empty;
            txt_contraseña.Text = string.Empty;

            // Limpia el ComboBox de Base de Datos y lo deshabilita
            cmbBaseDatos.Items.Clear();
            cmbBaseDatos.Text = string.Empty;
            cmbBaseDatos.Enabled = false; // Opcional: Deshabilita hasta una nueva conexión

            // Limpia los campos de destino
            txt_ruta.Text = string.Empty;
            txt_nombreArchivo.Text = string.Empty;

            // Restablece el estado de los controles de acción
            btn_backup.Enabled = false;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Blocks; // Asegura que vuelva a un estado estático

            // Restablece el mensaje de estado
            lblEstado.Text = "";
        }









            // ... dentro de la clase Form1.cs

            /// <summary>
            /// Valida los campos del formulario.
            /// </summary>
            /// <param name="modoConexion">True si valida solo la conexión; False si valida todo para el backup.</param>
            /// <returns>True si todos los campos requeridos están llenos; False en caso contrario.</returns>
            private bool ValidarCampos(bool modoConexion)
                {
                    // Lista para guardar los controles vacíos para el mensaje genérico
                    List<Control> camposVacios = new List<Control>();

                    // 1. Limpiar el formato de error anterior y restablecer el estado
                    RestablecerFormato();
                    lblEstado.Text = "Realizando validaciones...";

                    // 2. Validar campos de Conexión
                    if (string.IsNullOrWhiteSpace(txt_nombreServidor.Text))
                    {
                        MarcarError(txt_nombreServidor, "El nombre del servidor no puede estar vacío.");
                        return false;
                    }

                    // Nota: Esta validación es simple. En un caso real, solo se validarían
                    // Usuario/Contraseña si se elige Autenticación SQL.
                    if (string.IsNullOrWhiteSpace(txt_nombreUsuario.Text))
                    {
                        MarcarError(txt_nombreUsuario, "El campo Usuario es obligatorio para la conexión.");
                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
                    {
                        MarcarError(txt_contraseña, "El campo Contraseña es obligatorio para la conexión.");
                        return false;
                    }

                    // Si solo estamos validando para la conexión, podemos terminar aquí.
                    if (modoConexion)
                    {
                        return true;
                    }

                    // 3. Validar campo de Base de Datos (solo para el Backup)
                    if (cmbBaseDatos.SelectedItem == null)
                    {
                        // En lugar de usar MarcarError en ComboBox, usaremos un MessageBox.
                        MessageBox.Show("Debe seleccionar una Base de Datos de la lista.", "Advertencia de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbBaseDatos.Focus();
                        return false;
                    }

                    // 4. Validar campos de Destino (solo para el Backup)
                    if (string.IsNullOrWhiteSpace(txt_ruta.Text))
                    {
                        MarcarError(txt_ruta, "Debe seleccionar una Ruta Destino válida para guardar el archivo.");
                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(txt_nombreArchivo.Text))
                    {
                        MarcarError(txt_nombreArchivo, "Debe especificar un Nombre de Archivo para la copia de seguridad.");
                        return false;
                    }

                    // Si llegamos aquí, todas las validaciones han pasado
                    return true;
                }

                /// <summary>
                /// Aplica el color de error y muestra el MessageBox.
                /// </summary>
                private void MarcarError(Control control, string mensaje)
                {
                    control.BackColor = Color.MistyRose; // Color rosa claro
                    MessageBox.Show(mensaje, "Advertencia de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                }

                /// <summary>
                /// Restablece el formato visual de los campos.
                /// </summary>
                private void RestablecerFormato()
                {
                    // Restablece el color de fondo de todos los TextBoxes
                    txt_nombreArchivo.BackColor = SystemColors.Window;
                    txt_nombreUsuario.BackColor = SystemColors.Window;
                    txt_contraseña.BackColor = SystemColors.Window;
                    txt_ruta.BackColor = SystemColors.Window;
                    txt_nombreArchivo.BackColor = SystemColors.Window;
                    // ... agrega cualquier otro control de entrada aquí si lo usas.
                }





}

    }