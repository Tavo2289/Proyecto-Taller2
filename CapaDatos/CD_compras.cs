using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_compras
    {

        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA"); //consulta para obtener el siguiente correlativo
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar()); //retorna un valor unico 
                }
                catch
                {
                    idCorrelativo = 0; //en caso de error retorna 0
                }
            }

            return idCorrelativo;
        }


        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.id_usuario.id_usuario);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.id_proveedor.id_proveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.tipo_documento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.nro_documento);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.monto_total);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure; // It seems this line is missing or should be "StoredProcedure" based on the stored procedure name

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                   

                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = ex.Message;
                }
            }

            return respuesta;
        }


        public Compra ObtenerCompra(string numero)
        {
            Compra obj = new Compra();

            using (SqlConnection oconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {


                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.id_compra,");
                    query.AppendLine("u.nombre,");
                    query.AppendLine("u.apellido,");

                    query.AppendLine("pr.nro_documento as NroDocumentoProveedor, pr.razon_social,");
                    query.AppendLine("c.tipo_documento, c.nro_documento as NroDocumentoCompra, c.total, convert(char(10), c.fecha_compra, 103)[fecha_compra]");
                    query.AppendLine("from COMPRA c");
                    query.AppendLine("inner join USUARIO u on u.id_usuario = c.id_usuario");
                    query.AppendLine("inner join PROVEEDOR pr on pr.id_proveedor = c.id_proveedor");
                    query.AppendLine("where c.nro_documento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                id_usuario = new Usuario() { nombre = dr["nombre"].ToString(), apellido = dr["apellido"].ToString()  },
                                id_proveedor = new Proveedor() { nro_documento = dr["NroDocumentoProveedor"].ToString(), razon_social = dr["razon_social"].ToString() },
                                tipo_documento = dr["tipo_documento"].ToString(),
                                nro_documento = dr["NroDocumentoCompra"].ToString(),
                                monto_total = Convert.ToDecimal(dr["total"].ToString()),
                                fecha_compra = dr["fecha_compra"].ToString()
                            };
                        }
                    }

                }
                catch
                {
                    obj = new Compra();
                }
            }
            return obj;
        }

        public List<DetalleCompra> ObtenerDetalleCompra(int idcompra)
        {
            List<DetalleCompra> olista = new List<DetalleCompra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select  p.nombre_producto, dc.precioCompra, dc.cantidad, dc.montoTotal from DetalleCompra dc\r\n");
                    query.AppendLine("inner join PRODUCTO p on p.id_producto = dc.id_producto");
                    query.AppendLine("where dc.id_compra = @id_compra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@id_compra", idcompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            olista.Add(new DetalleCompra()
                            {
                                id_producto = new Producto() { nombre_producto = dr["nombre_producto"].ToString() },
                                precioCompra = Convert.ToDecimal(dr["precioCompra"].ToString()),
                                cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                olista = new List<DetalleCompra>();
            }
            return olista;
        }

    }
}
