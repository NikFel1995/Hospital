using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private SqlServer _sqlServer;


        #region Формы

        private FormAuthorization _formAuthorization;
        private FormPatients _formPatients;
        private FormPatientsShow _formPatientsShow;
        private FormReports _formReports;
        private FormSecurity _formSecurity;
        private FormAbout _formAbout;

        #endregion



        private static IEnumerable<Form> GetVisibleForms()
        {
            return Application.OpenForms.Cast<Form>().Where(form => form.Visible).ToList();
        }


        private void menuServerDisconnect_Click(object sender, EventArgs e)
        {
            var listVisibleForms = GetVisibleForms();
            foreach (var visibleForm in listVisibleForms.Where(visibleForm => visibleForm.Name != Name))
                visibleForm.Close();
            _formAuthorization.SqlServer = null;

        }

        #region Открытие других окон (MDI-форм)

        private void menuServerConnect_Click(object sender, EventArgs e)
        {
            if (_formAuthorization == null || _formAuthorization.IsDisposed)
            {
                _formAuthorization = new FormAuthorization { MdiParent = this };
                _formAuthorization.Show();
            }
            else
                _formAuthorization.Activate();
        }

        private void menuReports_Click(object sender, EventArgs e)
        {
            if (_formReports == null || _formReports.IsDisposed)
            {
                _formReports = new FormReports { MdiParent = this };
                _formReports.Show();
            }
            else
                _formPatients.Activate();
        }

        private void menuDataChange_Click(object sender, EventArgs e)
        {
            if (_formPatients == null || _formPatients.IsDisposed)
            {
                _formPatients = new FormPatients(_sqlServer) { MdiParent = this };
                _formPatients.Show();
            }
            else
                _formPatients.Activate();
        }
        private void menuDataShow_Click(object sender, EventArgs e)
        {
            if (_formPatientsShow == null || _formPatientsShow.IsDisposed)
            {
                _formPatientsShow = new FormPatientsShow { MdiParent = this };
                _formPatientsShow.Show();
            }
            else
                _formPatientsShow.Activate();
        }

        private void menuSecurity_Click(object sender, EventArgs e)
        {
            if (_formSecurity == null || _formSecurity.IsDisposed)
            {
                _formSecurity = new FormSecurity { MdiParent = this };
                _formSecurity.Show();
            }
            else
                _formSecurity.Activate();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            if (_formAbout == null || _formAbout.IsDisposed)
            {
                _formAbout = new FormAbout { MdiParent = this };
                _formAbout.Show();
            }
            else
                _formAbout.Activate();
        }

        #endregion



        private void timer_Tick(object sender, EventArgs e)
        {
            if (_formAuthorization != null)
                _sqlServer = _formAuthorization.SqlServer;

            ConnectDisconnetEnabled(_sqlServer);
        }

        private void ConnectDisconnetEnabled(SqlServer sqlServer)
        {
            if (sqlServer != null)
            {
                menuServerDisconnect.Enabled = true;
                menuServerConnect.Enabled = false;
                Roles();
                lblStatus.Text = DataConnection.DataBaseName + "  Сервер: " + DataConnection.Ip + "; Порт: " + DataConnection.Port;
            }
            else
            {
                DataConnection.UserType = "";
                Roles();
                menuServerDisconnect.Enabled = false;
                menuServerConnect.Enabled = true;
                lblStatus.Text = lblStatus.Tag.ToString();
            }
        }


        private void Roles()
        {
            switch (DataConnection.UserType)
            {
                case "Администратор":
                    menuData.Visible = menuReports.Visible = menuSecurity.Visible
                   = true;
                    break;

                case "Медработник":
                    menuData.Visible = menuReports.Visible = true;
                    break;

                case "": menuData.Visible = menuReports.Visible = menuSecurity.Visible
                    = false; break;

            }

        }








    }
}
