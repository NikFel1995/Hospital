namespace Hospital
{
    partial class FormPatientsShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientsShow));
            this.tabPatientsView = new System.Windows.Forms.TabControl();
            this.tpPatients = new System.Windows.Forms.TabPage();
            this.tpDoctors = new System.Windows.Forms.TabPage();
            this.ведение_карточек_пациентов_в_больницеDataSet = new Hospital.Ведение_карточек_пациентов_в_больницеDataSet();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view1TableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.view1TableAdapter();
            this.tableAdapterManager = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.TableAdapterManager();
            this.view1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view2TableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.view2TableAdapter();
            this.view2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPatientsView.SuspendLayout();
            this.tpPatients.SuspendLayout();
            this.tpDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ведение_карточек_пациентов_в_больницеDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPatientsView
            // 
            this.tabPatientsView.Controls.Add(this.tpPatients);
            this.tabPatientsView.Controls.Add(this.tpDoctors);
            this.tabPatientsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPatientsView.Location = new System.Drawing.Point(0, 0);
            this.tabPatientsView.Name = "tabPatientsView";
            this.tabPatientsView.SelectedIndex = 0;
            this.tabPatientsView.Size = new System.Drawing.Size(584, 262);
            this.tabPatientsView.TabIndex = 0;
            // 
            // tpPatients
            // 
            this.tpPatients.Controls.Add(this.view1DataGridView);
            this.tpPatients.Location = new System.Drawing.Point(4, 22);
            this.tpPatients.Name = "tpPatients";
            this.tpPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatients.Size = new System.Drawing.Size(571, 317);
            this.tpPatients.TabIndex = 0;
            this.tpPatients.Text = "Информация о пациентах";
            this.tpPatients.UseVisualStyleBackColor = true;
            // 
            // tpDoctors
            // 
            this.tpDoctors.Controls.Add(this.view2DataGridView);
            this.tpDoctors.Location = new System.Drawing.Point(4, 22);
            this.tpDoctors.Name = "tpDoctors";
            this.tpDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoctors.Size = new System.Drawing.Size(576, 236);
            this.tpDoctors.TabIndex = 1;
            this.tpDoctors.Text = "Информация о врачах";
            this.tpDoctors.UseVisualStyleBackColor = true;
            // 
            // ведение_карточек_пациентов_в_больницеDataSet
            // 
            this.ведение_карточек_пациентов_в_больницеDataSet.DataSetName = "Ведение_карточек_пациентов_в_больницеDataSet";
            this.ведение_карточек_пациентов_в_больницеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "view1";
            this.view1BindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // view1TableAdapter
            // 
            this.view1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДиагнозTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.Запись_в_карточке_пациентаTableAdapter = null;
            this.tableAdapterManager.Карточка_пациентаTableAdapter = null;
            this.tableAdapterManager.ПалатаTableAdapter = null;
            this.tableAdapterManager.ПациентTableAdapter = null;
            this.tableAdapterManager.Страховой_медицинский_полисTableAdapter = null;
            this.tableAdapterManager.Трудовой_договорTableAdapter = null;
            this.tableAdapterManager.Физическое_лицоTableAdapter = null;
            // 
            // view1DataGridView
            // 
            this.view1DataGridView.AllowUserToAddRows = false;
            this.view1DataGridView.AllowUserToDeleteRows = false;
            this.view1DataGridView.AutoGenerateColumns = false;
            this.view1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.view1DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.view1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.view1DataGridView.DataSource = this.view1BindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.view1DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.view1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view1DataGridView.Location = new System.Drawing.Point(3, 3);
            this.view1DataGridView.MultiSelect = false;
            this.view1DataGridView.Name = "view1DataGridView";
            this.view1DataGridView.ReadOnly = true;
            this.view1DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.view1DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.view1DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view1DataGridView.Size = new System.Drawing.Size(565, 311);
            this.view1DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Отделение";
            this.dataGridViewTextBoxColumn5.HeaderText = "Отделение";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Палата";
            this.dataGridViewTextBoxColumn6.HeaderText = "Палата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Диагноз";
            this.dataGridViewTextBoxColumn7.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "view2";
            this.view2BindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // view2TableAdapter
            // 
            this.view2TableAdapter.ClearBeforeFill = true;
            // 
            // view2DataGridView
            // 
            this.view2DataGridView.AllowUserToAddRows = false;
            this.view2DataGridView.AllowUserToDeleteRows = false;
            this.view2DataGridView.AutoGenerateColumns = false;
            this.view2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.view2DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view2DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.view2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.view2DataGridView.DataSource = this.view2BindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.view2DataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.view2DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view2DataGridView.Location = new System.Drawing.Point(3, 3);
            this.view2DataGridView.MultiSelect = false;
            this.view2DataGridView.Name = "view2DataGridView";
            this.view2DataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view2DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.view2DataGridView.RowHeadersVisible = false;
            this.view2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view2DataGridView.Size = new System.Drawing.Size(570, 230);
            this.view2DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn8.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 81;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn9.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 54;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn10.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 79;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 102;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Серия паспорта";
            this.dataGridViewTextBoxColumn12.HeaderText = "Серия паспорта";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 104;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Номер паспорта";
            this.dataGridViewTextBoxColumn13.HeaderText = "Номер паспорта";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 106;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Кем выдан";
            this.dataGridViewTextBoxColumn14.HeaderText = "Кем выдан";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 81;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Дата выдачи";
            this.dataGridViewTextBoxColumn15.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 90;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn16.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 90;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Дата начала работы";
            this.dataGridViewTextBoxColumn17.HeaderText = "Дата начала работы";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 124;
            // 
            // FormPatientsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.tabPatientsView);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FormPatientsShow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр данных о пациентов";
            this.Load += new System.EventHandler(this.FormPatientsShow_Load);
            this.tabPatientsView.ResumeLayout(false);
            this.tpPatients.ResumeLayout(false);
            this.tpDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ведение_карточек_пациентов_в_больницеDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPatientsView;
        private System.Windows.Forms.TabPage tpPatients;
        private System.Windows.Forms.TabPage tpDoctors;
        private Ведение_карточек_пациентов_в_больницеDataSet ведение_карточек_пациентов_в_больницеDataSet;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.view1TableAdapter view1TableAdapter;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.view2TableAdapter view2TableAdapter;
        private System.Windows.Forms.DataGridView view2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

    }
}