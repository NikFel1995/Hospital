using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        public SqlServer SqlServer { get; protected internal set; }
        private string DataSource { get; set; }


        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            cbUserType.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string port = txtPort.Text;
            string userType = cbUserType.Text;
            string user = txtUserName.Text;
            string password = txtPassword.Text;


            if (CorrectData(server, port, user, password, userType)) return;

            DataSource = server + "," + port;

            SqlServer = new SqlServer(DataSource, DataConnection.DataBaseName);

            if (!SqlServer.Open())
            {
                MessageBox.Show("Ошибка при подключении к базе данных!");
                SqlServer = null;
                return;
            }

            Login(user, password, userType, server, port);
        }

        private void Login(string user, string password, string userType, string server, string port)
        {
            string query = "SELECT * FROM Security s WHERE s.[Login] = '" +
                           user + "' AND s.Password = '" + password + "'";

            int rowsCount;
            do
            {
                var identity = SqlServer.SelectDataTable(query);
                rowsCount = identity.Rows.Count;
            } while (SqlServer.SqlError());

            try
            {
                if (rowsCount == 1)
                {
                    DataConnection.UserType = userType;
                    DataConnection.User = user;
                    DataConnection.Password = password;
                    DataConnection.Ip = server;
                    DataConnection.Port = port;
                    MessageBox.Show("Успешное подключение!");
                    Close();
                }
                else if (rowsCount <= 0)
                    MessageBox.Show(@"Имя пользователя или пароль некорректны!");
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, @"Ошибка");
                SqlServer = null;
            }

            finally
            {
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }

        private static bool CorrectData(string server, string port, string user, string password, string userType)
        {
            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(port))
            {
                MessageBox.Show(@"Пожалуйста, заполните IP-адрес и/или порт!", @"Внимание!");
                return true;
            }

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(@"Пожалуйста, заполните имя пользователя и/или пароль!", @"Внимание!");
                return true;
            }

            if (userType == "Администратор" && user != "Admin")
            {
                MessageBox.Show("Проверьте корректность выбранного типа пользователя!");
                return true;
            }


            if (userType != "Администратор" && user == "Admin")
            {
                MessageBox.Show("Проверьте корректность выбранного типа пользователя!");
                return true;
            }
            return false;
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.Match(e.KeyChar.ToString(),
                    @"[0-9]").Success &&
               !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') e.KeyChar = '.';
        }
    }
}
