using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

public class SqlBackupDAL
{
    // Método privado para generar la cadena de conexión
    private string GetConnectionString(string serverName, string userId, string password)
    {
        // En un escenario real con Autenticación de Windows, esta lógica sería más compleja (usando IFs)

        // Asumiendo Autenticación de SQL Server por ahora
        return $"Data Source={serverName};User ID={userId};Password={password};Initial Catalog=master";
    }

    // A. Método para obtener la lista de bases de datos
    public List<string> ObtenerBasesDeDatos(string serverName, string userId, string password)
    {
        string connectionString = GetConnectionString(serverName, userId, password);
        List<string> dbNames = new List<string>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    dbNames.Add(reader["name"].ToString());
                }
            }
        }
        return dbNames;
    }

    // B. Método para ejecutar el comando de copia de seguridad
    public void EjecutarBackup(string serverName, string userId, string password, string databaseName, string backupPath)
    {
        string connectionString = GetConnectionString(serverName, userId, password);

        // Comando de Respaldo SQL Server
        string backupCommand = $"BACKUP DATABASE [{databaseName}] " +
                               $"TO DISK = '{backupPath}' WITH INIT, STATS = 10";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(backupCommand, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        // Nota: Si ocurre un error de SQL, será capturado por la capa superior (BLL o Presentación)
    }
}