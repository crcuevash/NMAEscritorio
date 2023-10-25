using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.Data;

public class OracleDBManager
{
    private OracleConnection connection;
    private string connectionString;

    public OracleDBManager(string dataSource, string userId, string password)
    {
        // Define la cadena de conexión en el constructor
        connectionString = $"User Id=administrador;Password=admin123;Data Source=xe";
        connection = new OracleConnection(connectionString);
    }

    public bool OpenConnection()
    {
        try
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                MessageBox.Show("Conexión Exitosa");
                return true;
            }
            else
            {
                MessageBox.Show("La conexión ya está abierta.");
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            return false;
        }
    }

    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
            MessageBox.Show("Conexión cerrada exitosamente.");
        }
        else
        {
            MessageBox.Show("La conexión ya está cerrada.");
        }
    }
}
