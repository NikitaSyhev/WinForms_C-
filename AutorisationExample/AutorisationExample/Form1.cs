using NetworkUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutorisationExample
{
    public partial class Form1 : Form
    {
        private List<User> users;
        //
        private string dbName = "user_database.db";
        private string create_table = $"CREATE TABLE IF NOT EXISTS REQUISITES (" +
            $"ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
            $"NAME NVARCHAR(25), PASSWORD NVARCHAR(25), " +
            $"ROLE NVARCHAR(15));";
        private string init_data = $"INSERT INTO REQUISITES (" +
            $"NAME, PASSWORD, ROLE" +
            $") VALUES  (" +
            $"'Admin', '0', 'Пользователь');";
        private string show_all_data = $"SELECT * FROM REQUISITES;";
        private string show_all_users = $"SELECT NAME, PASSWORD FROM REQUISITES;";
        private string delete_main_table = $"DROP TABLE IF EXISTS REQUISITES;";
        private SQLiteDataAdapter _adapter;
        private DataSet _dataSet;
        private DBWork dBWork;
        private SQLiteConnection _connection;
        
        public Form1()
        {
            InitializeComponent();
            users = new List<User>();
            initDB();
        }
        private void initDB()
        {
            Action<string> action = (string _text) => { lbConnect.Text = _text; };
            dBWork = new DBWork(dbName, action, create_table);
            _connection =  dBWork.getConnection;
            updateGridFromDB();
            updateUsersFromDB();
        }
        private void updateUsersFromDB()
        {
            SQLiteCommand sQLiteCommand = 
                new SQLiteCommand(show_all_users, _connection);
            var reader =  sQLiteCommand.ExecuteReader();
            User user = new User("name", 1);
            users.Clear();
            while (reader.Read())
            {
                IDataRecord tmp = (IDataRecord)reader;
                string name = tmp[0].ToString();
                int password = Convert.ToInt32(tmp[1]);
                users.Add(new User(name, password));
            } 
            
            
        }
        private void updateGridFromDB()
        {
            Action<string> action = (string _text) => { lbConnect.Text = _text; };
            _adapter = dBWork.getDataAdapter;
            _dataSet = dBWork.GetDataSet(show_all_data, action);
            // Создаём привязку
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dBWork.getDataSet.Tables[0];
            dataGridViewUsers.DataSource = bindingSource1;
            SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder(_adapter);
            _adapter.Update(_dataSet);
        }

        private void updateDbFromGrid()
        {
            _adapter = dBWork.getDataAdapter;
            Action<string> action = (string _text) => { lbConnect.Text = _text; };
            _dataSet = dBWork.GetDataSet("default", action);
            // Создаём привязку 
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dBWork.getDataSet.Tables[0];
            dataGridViewUsers.DataSource = bindingSource1;
            SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder(_adapter);
            _adapter.Update(_dataSet);
            updateUsersFromDB();
        }
        private void doSqlQuery(string query)
        {
            Action<string> action = (string _text) => { lbConnect.Text = _text; };
            dataGridViewUsers.DataSource = dBWork.GetDataSet(query, action);
        }
        private void addUserToDB(string name, int password)
        {
            string add_data = $"INSERT INTO REQUISITES (" +
            $"NAME, PASSWORD, POSITION, ROLE" +
            $") VALUES  (" +
            $"'{name}', '{password}');";
            doSqlQuery(add_data);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {

          //  Position selectedPosition = (Position)comboPosition.SelectedItem;
            //Roles selectedRole = (Roles)comboRole.SelectedItem;

            if (textBoxLogin.Text != string.Empty && maskedTextBoxPassword.Text != string.Empty)
            {

                User user = new User(
                    textBoxLogin.Text,
                    maskedTextBoxPassword.Text.GetHashCode());
                users.Add(user);
                labelUsers.Text = "Активные пользователи:\r\n";
                foreach (var item in users)
                {
                    addUserToDB(item.Name, item.Password);
                    updateGridFromDB();
                    labelUsers.Text += $"{item.Name} {item.Password}" + "\r\n";
                }
            }
        }

        private void buttonTestLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = maskedTextBoxPassword.Text.GetHashCode();
            User user = new User(login, password);
            
            foreach (var item in users)
            {
                if (user.Name == item.Name && user.Password == item.Password)
                {
                    MessageBox.Show($"Пользователь {login} существует");
                }
            }
            
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            updateGridFromDB();
        }

        private void buttonSaveToDB_Click(object sender, EventArgs e)
        {
            updateDbFromGrid();
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = maskedTextBoxPassword.Text;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbName};Mode=ReadWriteCreate;Cache=Shared;"))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(show_all_users, connection))
                    {
                        command.Parameters.Add(new SQLiteParameter("@name", DbType.String) { Value = login });
                        command.Parameters.Add(new SQLiteParameter("@pass", DbType.String) { Value = password });

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                Form2 newForm = new Form2();
                                newForm.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("У вас нет доступа");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
