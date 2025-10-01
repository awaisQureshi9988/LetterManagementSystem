using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class SqlHelperClass : IDisposable
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        public SqlHelperClass()
        {
            // Reads connection string from App.config
            _connectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            _connection = new SqlConnection(_connectionString);
        }

        private void EnsureConnectionOpen()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
        }

        // ✅ For INSERT, UPDATE, DELETE (no return data)
        public int ExecuteNonQuery(string query, CommandType cmdType, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                cmd.CommandType = cmdType;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                EnsureConnectionOpen();
                return cmd.ExecuteNonQuery();
            }
        }

        // ✅ For single value (e.g., COUNT, MAX, identity value)
        public object ExecuteScalar(string query, CommandType cmdType, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                cmd.CommandType = cmdType;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                EnsureConnectionOpen();
                return cmd.ExecuteScalar();
            }
        }

        // ✅ For reading multiple rows (forward-only, fast)
        public SqlDataReader ExecuteReader(string query, CommandType cmdType, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.CommandType = cmdType;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            EnsureConnectionOpen();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // ✅ For loading data into DataTable (good for GridView/DataGridView)
        public DataTable GetDataTable(string query, CommandType cmdType, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                cmd.CommandType = cmdType;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // ✅ Dispose to close connection safely
        public void Dispose()
        {
            if (_connection != null)
            {
                if (_connection.State != ConnectionState.Closed)
                    _connection.Close();

                _connection.Dispose();
                _connection = null;
            }
        }
    }
}
