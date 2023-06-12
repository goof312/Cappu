using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Cappu
{
    public class Order : IDisposable
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        public Order()  
        {

            //initialize database connection
            string fConnStr = ConfigurationManager.ConnectionStrings["OrderManagement"].ConnectionString;
            _connection = new SqlConnection(fConnStr);
            _connection.Open();
            if (_connection.State != System.Data.ConnectionState.Open)
                throw new Exception("Database connection Error!");
        }

        public int ExecuteNonQuery(string command)
        {
            _command = new SqlCommand(command, _connection);
            return _command.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteReader(string command)
        {
            _command = new SqlCommand(command, _connection);
            return _command.ExecuteReader();
        }

        public object ExecuteScalar(string command)
        {
            _command = new SqlCommand(command, _connection);
            return _command.ExecuteScalar();
        }

        public void Dispose()
        {
            //properly dispose connection and command
            if (_command != null)
                _command.Dispose();

            _connection.Dispose();
        }
    }
    
}