using System.Data;
using MySql.Data.MySqlClient;

namespace transport.infrastructure.data.MySql
{
    public class MySql
    {
        private const string ConnStr = "SERVER=localhost;DATABASE=service-transport;UID=root;Password=;Pooling=true;";

        public static void Query(MySqlCommand command)
        {
            using MySqlConnection conn = new MySqlConnection(ConnStr);
            try
            {
                conn.Open();
                command.Connection = conn;
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw new NotImplementedException();
                //throw new ServerException(Server.ServerIsNotAvaliable);
            }
        }

        public static DataTable? QueryRead(MySqlCommand command)
        {
            using var conn = new MySqlConnection(ConnStr);
            try
            {
                conn.Open();
                command.Connection = conn;
                using var reader = command.ExecuteReader();
                DataTable dt = new (null);
                dt.Load(reader);
                return dt;
            }
            catch
            {
                throw new NotImplementedException();
                //throw new ServerException(Server.ServerIsNotAvaliable);
            }
        }
    }
}
