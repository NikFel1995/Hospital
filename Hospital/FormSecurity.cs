using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormSecurity : Form
    {
        public FormSecurity()
        {
            InitializeComponent();
        }

        private void securityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            securityBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(ведение_карточек_пациентов_в_больницеDataSet);

        }

        private void FormSecurity_Load(object sender, EventArgs e)
        {
            securityTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Security);
            securityDataGridView.Columns[0].Visible = false;
            securityDataGridView[0, 2].ReadOnly = true; // запрет на изменение имя пользователя (Admin)
            securityDataGridView[0, 3].ReadOnly = true; // и пароля

        }
    }
}
