using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NetworkUser
{

    internal class DBWork
    {
        // System.Data.SQLite
        //
        private SQLiteConnection _connection;
        private SQLiteDataAdapter _adapter;
        private DataSet _dataSet;
        
        public DataSet getDataSet
        {
            get { return _dataSet; }
        }
        public SQLiteDataAdapter getDataAdapter
        {
            get { return _adapter; }
        }
        public SQLiteConnection getConnection
        {
            get { return _connection; }
        }

        public DBWork(string DB_name,
            Action<string> action = null,
            string sql_command = "default")
        {
            var connectionString = $"Data Source = {DB_name};" +
                $" Mode = ReadWriteCreate;" +
                $" Cache=Shared;";
            SQLiteConnection sql_connection = new SQLiteConnection(connectionString);
            sql_connection.Open();
            _connection = sql_connection;
            if (sql_command != "default")
            {
                // Для загрузки данных создаём adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_command, sql_connection);

                // DataSet - хранилище данных, позволяющее работать независимо от наличия подключения
                DataSet ds = new DataSet();
                adapter.Fill(ds); // Fill загружает данные в ds - объект DataSet
                _dataSet = ds;
                _adapter = adapter;
            }
            if (action != null)
            {
                action($"Connection to {DB_name} " +
                    $"opened in {DateTime.Now.ToString("HH:mm:ss.f")} successfully.");
            }
            
        }
        public DataSet GetDataSet(string query = "default", Action<string> action = null)
        {
            if (query != "default")
            {
                // Для загрузки данных создаём adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, _connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds); // Fill загружает данные в ds - объект DataSet
                _dataSet = ds;
                _adapter = adapter;
            }
            if (action != null)
            {
                action($"Last update are " +
                $"{DateTime.Now.ToString("HH:mm:ss.f")}");
            }
            return _dataSet;
        }
    }
}
