using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // para sql    
using System.Data; // para sql

namespace CapaDatos
{
    public class CD_negocio
    {
        public Negocio obtenerDatos ()
        {
            Negocio objeto = new Negocio();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();
                    string query = "\r\nSELECT id_negocio,nombre,ruc,direccion FROM NEGOCIO"; // consulta para obtener los datos del negocio
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            objeto = new Negocio()
                            {
                                id_negocio = Convert.ToInt32(dr["id_negocio"]),
                                nombre = dr["nombre"].ToString(),
                                ruc = dr["ruc"].ToString(),
                                direccion = dr["direccion"].ToString()
                            };


                            //objeto.id_negocio = Convert.ToInt32(dr["id_negocio"]);
                            //objeto.nombre = dr["nombre"].ToString();
                            //objeto.ruc = Convert.ToInt32(dr["ruc"]);
                            //objeto.direccion = dr["direccion"].ToString();
                        }
                    }

                }
            }
            catch (Exception)
            {
              objeto = new Negocio();
            }
            return objeto;
        }


        public bool guardarDatos(Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update  Negocio set nombre = @nombre,");
                    query.AppendLine("ruc = @ruc,");
                    query.AppendLine("direccion = @direccion");
                    query.AppendLine("where id_negocio =1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    
                    cmd.Parameters.AddWithValue("@nombre", objeto.nombre);
                    cmd.Parameters.AddWithValue("@ruc", objeto.ruc);
                    cmd.Parameters.AddWithValue("@direccion", objeto.direccion);
                    cmd.Parameters.AddWithValue("@id_negocio", objeto.id_negocio);
                    cmd.CommandType = CommandType.Text;


                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        mensaje = "Datos guardados correctamente.";
                    }
                    else
                    {
                        mensaje = "No se guardaron los datos.";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message; // capturamos el error
                respuesta = false;
            }
            return respuesta;
        }


        //// para el logo
        ///


        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();
                    string query = "select logo from NEGOCIO where id_negocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogoBytes = (byte[])dr["Logo"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                LogoBytes = new byte[0];
            }
            return LogoBytes;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set logo = @imagen");
                    query.AppendLine("where id_negocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@imagen", image);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }


    }
}
