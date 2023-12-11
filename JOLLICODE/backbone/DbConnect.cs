using MySql.Data.MySqlClient;
using System.Data;
using pv = backbone.PublicVariables;
namespace backbone
{
    class DbConnect
    {
        private MySqlConnection con = new MySqlConnection($"server=127.0.0.1; user=root; database={pv.dbname}; password=");

        public MySqlConnection Getcon()
        {
            return con;
        }
        public void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
