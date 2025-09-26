using System;
using System.Collections.Generic;
using System.IO;

public class BackupManager
{
    private SqlBackupDAL _dataAccess = new SqlBackupDAL();

    // Método que valida la conexión y llama a la DAL
    public List<string> ConectarYCargarDBs(string serverName, string userId, string password)
    {
        if (string.IsNullOrWhiteSpace(serverName) || string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Todos los campos de conexión son obligatorios.");
        }

        // La lógica de la DAL lanzará una excepción si la conexión falla,
        // lo cual se propaga al método que llama (Presentación).
        return _dataAccess.ObtenerBasesDeDatos(serverName, userId, password);
    }

    // Método que valida las rutas y llama a la DAL para ejecutar el respaldo
    public void ProcesarBackup(string serverName, string userId, string password, string databaseName, string destinationFolder, string fileName)
    {
        // 1. Validaciones de Negocio
        if (string.IsNullOrWhiteSpace(databaseName) || string.IsNullOrWhiteSpace(destinationFolder) || string.IsNullOrWhiteSpace(fileName))
        {
            throw new ArgumentException("Debe seleccionar una base de datos, ruta de destino y nombre de archivo.");
        }

        string fullPath = Path.Combine(destinationFolder, fileName);

        // 2. Delegar la ejecución a la Capa de Datos
        _dataAccess.EjecutarBackup(serverName, userId, password, databaseName, fullPath);
    }
}