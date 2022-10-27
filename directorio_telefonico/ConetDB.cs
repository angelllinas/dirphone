using MySql.Data.MySqlClient;

namespace directorio_telefonico
{
    internal class ConetDB
    {
        private MySqlConnection conn;
        private string server = "localhost:";
        private string db = "directorio";
        private string user = "root";
        private string password = "12345";
        private string conet;

        public ConetDB()
        {
            conet = "Database=" + db +
                "; DataSource=" + server + 
                "; User Id=" + user + 
                "; Password=" + password;
        }

        public MySqlConnection getConn()
        {
            if (conn == null)
            {
                conn = new MySqlConnection(conet);
                conn.Open();
            }
            return conn;
        }
    }
}
