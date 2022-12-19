using System.Data.SqlClient;

namespace OOOPovaryonok.Classes
{
    public class SQLHelper
    {
        public static string ConnectionString = @"Data Source=ILUVATAR\SQLEXPRESS;Initial Catalog=Trade; Integrated Security = True";
        //public static string ConnectionString = @"Data Source=ILUVATAR\MSSQLMYSERVER;Initial Catalog=Trade; Persist Security Info = True; User ID = loginDElqb2018; Password = RNynil";
        //public static string ConnectionString = @"Data Source=ILUVATAR\MSSQLMYSERVER;Initial Catalog=Trade; Integrated Security = True";

        public static SqlConnection connection = new SqlConnection(ConnectionString);

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
                                                
        public static SQLHelper DatabaseContext { get; set; }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
