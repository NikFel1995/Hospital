using Microsoft.Office.Interop.Excel;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Hospital
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            InitTables();
        }

        private void InitTables()
        {
            физическое_лицоTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Физическое_лицо);
            палатаTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Палата);
            пациентTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Пациент);
            report1TableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.report1);
            диагнозTableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.Диагноз);
        }

        #region Отчет 2

        private void btnSearchReport2_Click(object sender, EventArgs e)
        {
            try
            {
                report2TableAdapter.Fill
                    (ведение_карточек_пациентов_в_больницеDataSet.report2,
                        cbBranch.Text, cbLastName.Text, txtDateBegin.Text,
                        txtDateEnd.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchReport2_Click(sender, EventArgs.Empty);
        }

        #endregion

        #region Отчет 3

        private void btnSearchReport3_Click(object sender, EventArgs e)
        {
            try
            {
                report3TableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.report3,
                    (int)Convert.ChangeType(cbRoomNumber.Text, typeof(int)), cbDiagnosis.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbRoomNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchReport3_Click(sender, EventArgs.Empty);
        }

        #endregion

        #region Отчет 4

        private void btnSearchReport4_Click(object sender, EventArgs e)
        {
            try
            {
                report4TableAdapter.Fill
                    (ведение_карточек_пациентов_в_больницеDataSet.report4,
                        cbLastNamePatients.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbLastNamePatients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchReport4_Click(sender, EventArgs.Empty);
        }

        #endregion

        private void SaveReport_Click(object sender, EventArgs e)
        {
            var control = contextMenu.SourceControl;
            if (control.GetType() == typeof(DataGridView))
            {
                if (((DataGridView)control).RowCount > 0)
                {
                    var tag = control.Tag.ToString();
                    switch (tag)
                    {
                        case "1": SaveDataFromTable(report1DataGridView); break;
                        case "2": SaveDataFromTable(report2DataGridView); break;
                        case "3": SaveDataFromTable(report3DataGridView); break;
                        case "4": SaveDataFromTable(report4DataGridView); break;
                    }
                }
            }

        }


        /// <summary>
        /// Сохранение данных из таблицы в файл
        /// <param name="dataTable">Таблица dataGridView</param>
        /// </summary>
        private void SaveDataFromTable(DataGridView dataTable)
        {
            Application exApp = new Application { Visible = false };
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;

            for (int i = 0; i < dataTable.ColumnCount; i++)
            {
                workSheet.Cells[1, (i + 1)] = dataTable.Columns[i].HeaderText;
            }


            int rowExcel = 2; //начать со второй строки.


            for (int i = 0; i < dataTable.ColumnCount; i++)
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    //заполняем строку
                    workSheet.Cells[j + 2, i + 1] = dataTable[i, j].Value.ToString();
                }

            string pathToXmlFile = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Выберите место для сохранения файла",
                DefaultExt = "*.xlsx;*.xls",
                Filter = " Excel 2007(*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls"
            };


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToXmlFile = saveFileDialog.FileName;
                workSheet.SaveAs(pathToXmlFile);
            }
            exApp.Quit();


            DialogResult dialog = MessageBox.Show("Открыть Excel-файл?", "Открываем?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Process.Start(pathToXmlFile);

        }

    }
}
