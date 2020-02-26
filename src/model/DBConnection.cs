using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FrbaHotel {
    class DBConnection {

        private static readonly DBConnection instance = new DBConnection();

        private readonly string server   = ConfigurationManager.AppSettings["server"].ToString();
        private readonly string user     = ConfigurationManager.AppSettings["user"].ToString();
        private readonly string password = ConfigurationManager.AppSettings["password"].ToString();

        private SqlConnection connection;
        private Usuario usuario;
        private Cliente cliente;

        private DBConnection() { }

        // Properties
        public static DBConnection Instance { get { return instance; } }
        public Usuario Usuario { get { return usuario; } set { usuario = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public SqlConnection Connection {
            get {
                try {
                    if (connection == null) {
                        connection = new SqlConnection();
                        connection.ConnectionString = "SERVER=" + server + "\\SQLEXPRESS;DATABASE=GD1C2018;UID=" + user + ";PASSWORD=" + password + ";MultipleActiveResultSets=true;";
                        connection.Open();
                    };
                    return connection;
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }

        public SqlDataReader executeQuery(String query) {
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            command.Dispose();
            return dataReader;
        }

        public void executeProcedure(String procName, string[] parameters, object[] args) {
            SqlCommand command = new SqlCommand(procName, this.connection);
            command.CommandType = CommandType.StoredProcedure;

            if(args.Length != 0 && args.Length == parameters.Length) {
                for (int i = 0; i < args.Length ; i++) 
                    command.Parameters.AddWithValue(parameters[i], args[i]);
            }

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public bool conexionCorrecta() { return this.Connection != null; }

    }
}
