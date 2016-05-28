using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormPatients : Form
    {
        public FormPatients(SqlServer sqlServer)
        {
            InitializeComponent();
            _sqlServer = sqlServer;
        }

        private readonly SqlServer _sqlServer;
        private readonly Random _random = new Random();

        private int _policyId;
        private int _diagnosisId;


        private void FormMain_Load(object sender, EventArgs e)
        {
            InitTables();
        }

        private void InitTables()
        {
            диагнозTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Диагноз);

            карточка_пациентаTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Карточка_пациента);

            палатаTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Палата);

            физическое_лицоTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Физическое_лицо);

            диагнозTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Диагноз);

            пациентTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Пациент);
            txtBranch.Text = GetBranch(Convert.ToInt32(cbChamber.Text));
            UpdateTablePolicy();
            UpdateTableDiagnosis();
        }

        #region Добавление записи в карточку клиента

        private void btnAddRecord_Click(object sender, EventArgs e)
        {

            int cardNumber = Convert.ToInt32(cbCardNumber.SelectedValue);
            int idPatient = Convert.ToInt32(cbPatient.SelectedValue);
            int idDiagnosis = Convert.ToInt32(cbDiagnosis.SelectedValue);
            int idContract = GetContract(cbDoctor.Text);
            int idChamber = Convert.ToInt32(cbChamber.SelectedValue);
            int number = _random.Next(1000);
            string record = txtRecord.Text;

            bool result;
            do
            {
                string query = "INSERT INTO [Запись в карточке пациента]  " +
                               "([Код карточки], [Код диагноза], [Код пациента], " +
                               "[Код врача], [Код палаты], Номер, Наименование) " +
                               "VALUES (" + cardNumber + "," + idDiagnosis + ", " +
                               idPatient + "," + idContract + "," + idChamber +
                               "," + number + ", '" + record + "');";
                result = _sqlServer.InsertData(query);

            } while (_sqlServer.SqlError());

            if (result)
                MessageBox.Show("Данные успешно добавлены!");
        }

        /// <summary>
        /// Получить название отделения
        /// </summary>
        /// <param name="chamberName">Номер комнаты</param>
        /// <returns>Название отделения по номеру комнаты</returns>
        private string GetBranch(int chamberName)
        {
            string branch;
            do
            {
                string query = "SELECT Палата.Отделение FROM dbo.Палата WHERE Палата.Номер = " + chamberName;
                branch = _sqlServer.Scalar(query);
            } while (_sqlServer.SqlError());

            return branch;

        }

        /// <summary>
        /// Получить код трудового договора 
        /// </summary>
        /// <param name="lastNameDoctor">Фамилия медработника</param>
        /// <returns>Кодж трудового договора медработника</returns>
        private int GetContract(string lastNameDoctor)
        {
            int individual; // код физического лица
            int contract; // код трудового договора

            do
            {
                string query = "SELECT [Физическое лицо].[Код физического лица] " +
                               "FROM dbo.[Физическое лицо] WHERE [Физическое " +
                               "лицо].Фамилия = '" + lastNameDoctor + "'";
                individual = Convert.ToInt32(_sqlServer.Scalar(query));
            } while (_sqlServer.SqlError());

            do
            {
                string query =
                    "SELECT [Трудовой договор].[Код трудового договора] FROM dbo.[Трудовой договор] WHERE [Трудовой договор].[Код физического лица] = " +
                    individual;
                contract = Convert.ToInt32(_sqlServer.Scalar(query));
            } while (_sqlServer.SqlError());

            return contract;
        }


        private void cbChamber_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBranch.Text = GetBranch(Convert.ToInt32(cbChamber.Text));
        }

        #endregion

        #region Изменение данных медицинского полиса

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                insurancePolicyTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.InsurancePolicy,
                    lastNameToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void insurancePolicyDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowTableInsurancePolicy(e);
        }

        private void ShowTableInsurancePolicy(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtNumberPolicy.Text = insurancePolicyDataGridView[4,
                e.RowIndex].Value.ToString();
            txtSeriesPolicy.Text = insurancePolicyDataGridView[3,
                e.RowIndex].Value.ToString();
            _policyId = GetInsurancePolicyId(Convert.ToInt32(txtNumberPolicy.Text),
            Convert.ToInt32(txtSeriesPolicy.Text));
        }


        private void UpdateTablePolicy()
        {
            insurancePolicyTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.InsurancePolicy,
                "");
        }

        private void btnChangePolicy_Click(object sender, EventArgs e)
        {

            int seriesPolicy = Convert.ToInt32(txtSeriesPolicy.Text);
            int numberPolicy = Convert.ToInt32(txtNumberPolicy.Text);

            int rowsUpdate;

            do
            {
                string query = "UPDATE [Страховой медицинский полис] SET Серия ="
                    + seriesPolicy + ", Номер = " + numberPolicy +
                    " WHERE [Код страхового медицинского полиса] = " + _policyId;
                rowsUpdate = _sqlServer.UpdateDate(query);
            } while (_sqlServer.SqlError());

            if (rowsUpdate == 1)
            {
                MessageBox.Show("Данные успешно изменены!");
                UpdateTablePolicy();
            }
        }

        /// <summary>
        /// Получить код медицинского полиса
        /// </summary>
        /// <param name="numberPolicy">Номер медиц. полиса</param>
        /// <param name="seriesPolicy">Серия медиц. полиса</param>
        /// <returns>Код медицинского полиса по номеру и серии</returns>
        private int GetInsurancePolicyId(int numberPolicy, int seriesPolicy)
        {
            int polId;
            do
            {
                string query =
                    "SELECT [Страховой медицинский полис].[Код страхового " +
                    "медицинского полиса] FROM dbo.[Страховой медицинский полис] " +
                    "WHERE [Страховой медицинский полис].Номер = " + numberPolicy +
                    " AND [Страховой медицинский полис].Серия =" + seriesPolicy;
                polId = Convert.ToInt32(_sqlServer.Scalar(query));
            } while (_sqlServer.SqlError());
            return polId;
        }


        #endregion

        #region Изменение диагноза пациента

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                diagnosisTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Diagnosis, lastNameToolStripTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateTableDiagnosis()
        {
            diagnosisTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Diagnosis, "");
        }

        private void diagnosisDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowTableDiagnosis(e);
        }

        private void ShowTableDiagnosis(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtDiagnosis_.Text = diagnosisDataGridView[3,
                e.RowIndex].Value.ToString();

            _diagnosisId = GetDiagnosisId(txtDiagnosis_.Text);
        }

        /// <summary>
        /// Получить код диагноза
        /// </summary>
        /// <param name="diagnosis">Название диагноза</param>
        /// <returns>Получить код диагноза по названию</returns>
        private int GetDiagnosisId(string diagnosis)
        {
            int diagId;
            do
            {
                string query =
                    "SELECT Диагноз.[Код диагноза] FROM dbo.Диагноз WHERE Диагноз.Наименование = '" + diagnosis + "'";
                diagId = Convert.ToInt32(_sqlServer.Scalar(query));
            } while (_sqlServer.SqlError());
            return diagId;
        }

        private void btnChangeDiagnosis_Click(object sender, EventArgs e)
        {
            int rowsUpdate;

            string diagnosis = txtDiagnosis_.Text;
            do
            {
                string query = "UPDATE Диагноз SET Наименование = '" + diagnosis +
                    "' WHERE [Код диагноза] = " + _diagnosisId;
                rowsUpdate = _sqlServer.UpdateDate(query);

            } while (_sqlServer.SqlError());

            if (rowsUpdate == 1)
            {
                MessageBox.Show("Данные успешно изменены!");
                UpdateTableDiagnosis();
            }
        }

        #endregion


    }
}
