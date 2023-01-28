using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace RestApi.Config
{
    public class DBConnection
    {
        private DBConnection() { }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Charset { get; set; }

        public MySqlConnection Connection { get; set; }
        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
                _instance.Server = "127.0.0.1";
                _instance.DatabaseName = "wpf";
                _instance.UserName = "root";
                _instance.Password = "";
                _instance.Charset = "utf8";
            }
            return _instance;
        }

        public bool IsConnect()
        {
            if (String.IsNullOrEmpty(DatabaseName))
                return false;
            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}; charset={4};", Server, DatabaseName, UserName, Password, Charset);
            Connection = new MySqlConnection(connstring);
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
