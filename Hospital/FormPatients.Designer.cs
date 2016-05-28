namespace Hospital
{
    partial class FormPatients
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatients));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpAddRecord = new System.Windows.Forms.TabPage();
            this.cbCardNumber = new System.Windows.Forms.ComboBox();
            this.карточкаПациентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ведение_карточек_пациентов_в_больницеDataSet = new Hospital.Ведение_карточек_пациентов_в_больницеDataSet();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.cbChamber = new System.Windows.Forms.ComboBox();
            this.палатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblChamber = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.физическоеЛицоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPatient = new System.Windows.Forms.Label();
            this.cbDiagnosis = new System.Windows.Forms.ComboBox();
            this.диагнозBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.tpInsurancePolicy = new System.Windows.Forms.TabPage();
            this.txtNumberPolicy = new System.Windows.Forms.TextBox();
            this.lblNumberPolicy = new System.Windows.Forms.Label();
            this.btnChangePolicy = new System.Windows.Forms.Button();
            this.txtSeriesPolicy = new System.Windows.Forms.TextBox();
            this.lblSeriesPolicy = new System.Windows.Forms.Label();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lastNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.insurancePolicyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurancePolicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpDiagnosis = new System.Windows.Forms.TabPage();
            this.btnChangeDiagnosis = new System.Windows.Forms.Button();
            this.txtDiagnosis_ = new System.Windows.Forms.TextBox();
            this.lblDiagnosis_ = new System.Windows.Forms.Label();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lastNameToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lastNameToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.diagnosisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентTableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.ПациентTableAdapter();
            this.диагнозTableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.ДиагнозTableAdapter();
            this.физическое_лицоTableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.Физическое_лицоTableAdapter();
            this.палатаTableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.ПалатаTableAdapter();
            this.карточка_пациентаTableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.Карточка_пациентаTableAdapter();
            this.insurancePolicyTableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.InsurancePolicyTableAdapter();
            this.диагнозBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisTableAdapter = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.DiagnosisTableAdapter();
            this.tableAdapterManager = new Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.TableAdapterManager();
            this.tabControl.SuspendLayout();
            this.tpAddRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.карточкаПациентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведение_карточек_пациентов_в_больницеDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическоеЛицоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingSource)).BeginInit();
            this.tpInsurancePolicy.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insurancePolicyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancePolicyBindingSource)).BeginInit();
            this.tpDiagnosis.SuspendLayout();
            this.fillToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpAddRecord);
            this.tabControl.Controls.Add(this.tpInsurancePolicy);
            this.tabControl.Controls.Add(this.tpDiagnosis);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(629, 415);
            this.tabControl.TabIndex = 0;
            // 
            // tpAddRecord
            // 
            this.tpAddRecord.Controls.Add(this.cbCardNumber);
            this.tpAddRecord.Controls.Add(this.lblCardNumber);
            this.tpAddRecord.Controls.Add(this.txtBranch);
            this.tpAddRecord.Controls.Add(this.lblBranch);
            this.tpAddRecord.Controls.Add(this.txtRecord);
            this.tpAddRecord.Controls.Add(this.lblRecord);
            this.tpAddRecord.Controls.Add(this.cbChamber);
            this.tpAddRecord.Controls.Add(this.lblChamber);
            this.tpAddRecord.Controls.Add(this.cbDoctor);
            this.tpAddRecord.Controls.Add(this.lblDoctor);
            this.tpAddRecord.Controls.Add(this.cbPatient);
            this.tpAddRecord.Controls.Add(this.lblPatient);
            this.tpAddRecord.Controls.Add(this.cbDiagnosis);
            this.tpAddRecord.Controls.Add(this.lblDiagnosis);
            this.tpAddRecord.Controls.Add(this.btnAddRecord);
            this.tpAddRecord.Location = new System.Drawing.Point(4, 22);
            this.tpAddRecord.Name = "tpAddRecord";
            this.tpAddRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddRecord.Size = new System.Drawing.Size(621, 389);
            this.tpAddRecord.TabIndex = 0;
            this.tpAddRecord.Text = "Добавление записи в карточку пациента";
            this.tpAddRecord.UseVisualStyleBackColor = true;
            // 
            // cbCardNumber
            // 
            this.cbCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCardNumber.DataSource = this.карточкаПациентаBindingSource;
            this.cbCardNumber.DisplayMember = "Номер карточки";
            this.cbCardNumber.FormattingEnabled = true;
            this.cbCardNumber.Location = new System.Drawing.Point(149, 17);
            this.cbCardNumber.Name = "cbCardNumber";
            this.cbCardNumber.Size = new System.Drawing.Size(456, 21);
            this.cbCardNumber.TabIndex = 17;
            this.cbCardNumber.ValueMember = "Код карточки";
            // 
            // карточкаПациентаBindingSource
            // 
            this.карточкаПациентаBindingSource.DataMember = "Карточка пациента";
            this.карточкаПациентаBindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // ведение_карточек_пациентов_в_больницеDataSet
            // 
            this.ведение_карточек_пациентов_в_больницеDataSet.DataSetName = "Ведение_карточек_пациентов_в_больницеDataSet";
            this.ведение_карточек_пациентов_в_больницеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(10, 20);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(90, 13);
            this.lblCardNumber.TabIndex = 16;
            this.lblCardNumber.Text = "Номер карточки";
            // 
            // txtBranch
            // 
            this.txtBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBranch.BackColor = System.Drawing.Color.White;
            this.txtBranch.Location = new System.Drawing.Point(390, 163);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.ReadOnly = true;
            this.txtBranch.Size = new System.Drawing.Size(216, 20);
            this.txtBranch.TabIndex = 15;
            this.txtBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(322, 166);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(62, 13);
            this.lblBranch.TabIndex = 14;
            this.lblBranch.Text = "Отделение";
            // 
            // txtRecord
            // 
            this.txtRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecord.Location = new System.Drawing.Point(149, 200);
            this.txtRecord.Multiline = true;
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecord.Size = new System.Drawing.Size(459, 122);
            this.txtRecord.TabIndex = 12;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(12, 234);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(44, 13);
            this.lblRecord.TabIndex = 11;
            this.lblRecord.Text = "Запись";
            // 
            // cbChamber
            // 
            this.cbChamber.DataSource = this.палатаBindingSource;
            this.cbChamber.DisplayMember = "Номер";
            this.cbChamber.FormattingEnabled = true;
            this.cbChamber.Location = new System.Drawing.Point(149, 163);
            this.cbChamber.Name = "cbChamber";
            this.cbChamber.Size = new System.Drawing.Size(154, 21);
            this.cbChamber.TabIndex = 8;
            this.cbChamber.ValueMember = "Код палаты";
            this.cbChamber.SelectedIndexChanged += new System.EventHandler(this.cbChamber_SelectedIndexChanged);
            // 
            // палатаBindingSource
            // 
            this.палатаBindingSource.DataMember = "Палата";
            this.палатаBindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // lblChamber
            // 
            this.lblChamber.AutoSize = true;
            this.lblChamber.Location = new System.Drawing.Point(10, 166);
            this.lblChamber.Name = "lblChamber";
            this.lblChamber.Size = new System.Drawing.Size(94, 13);
            this.lblChamber.TabIndex = 7;
            this.lblChamber.Text = "Выберите палату";
            // 
            // cbDoctor
            // 
            this.cbDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDoctor.DataSource = this.физическоеЛицоBindingSource;
            this.cbDoctor.DisplayMember = "Фамилия";
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(149, 124);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(456, 21);
            this.cbDoctor.TabIndex = 6;
            this.cbDoctor.ValueMember = "Код физического лица";
            // 
            // физическоеЛицоBindingSource
            // 
            this.физическоеЛицоBindingSource.DataMember = "Физическое лицо";
            this.физическоеЛицоBindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(10, 127);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(89, 13);
            this.lblDoctor.TabIndex = 5;
            this.lblDoctor.Text = "Выберите врача";
            // 
            // cbPatient
            // 
            this.cbPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPatient.DataSource = this.пациентBindingSource;
            this.cbPatient.DisplayMember = "Фамилия";
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(149, 52);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(456, 21);
            this.cbPatient.TabIndex = 4;
            this.cbPatient.ValueMember = "Код пациента";
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(10, 55);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(107, 13);
            this.lblPatient.TabIndex = 3;
            this.lblPatient.Text = "Выберите пациента";
            // 
            // cbDiagnosis
            // 
            this.cbDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiagnosis.DataSource = this.диагнозBindingSource;
            this.cbDiagnosis.DisplayMember = "Наименование";
            this.cbDiagnosis.FormattingEnabled = true;
            this.cbDiagnosis.Location = new System.Drawing.Point(149, 90);
            this.cbDiagnosis.Name = "cbDiagnosis";
            this.cbDiagnosis.Size = new System.Drawing.Size(456, 21);
            this.cbDiagnosis.TabIndex = 2;
            this.cbDiagnosis.ValueMember = "Код диагноза";
            // 
            // диагнозBindingSource
            // 
            this.диагнозBindingSource.DataMember = "Диагноз";
            this.диагнозBindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Location = new System.Drawing.Point(10, 93);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(101, 13);
            this.lblDiagnosis.TabIndex = 1;
            this.lblDiagnosis.Text = "Выберите диагноз";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRecord.Location = new System.Drawing.Point(258, 344);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(156, 37);
            this.btnAddRecord.TabIndex = 0;
            this.btnAddRecord.Text = "Добавить запись";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // tpInsurancePolicy
            // 
            this.tpInsurancePolicy.Controls.Add(this.txtNumberPolicy);
            this.tpInsurancePolicy.Controls.Add(this.lblNumberPolicy);
            this.tpInsurancePolicy.Controls.Add(this.btnChangePolicy);
            this.tpInsurancePolicy.Controls.Add(this.txtSeriesPolicy);
            this.tpInsurancePolicy.Controls.Add(this.lblSeriesPolicy);
            this.tpInsurancePolicy.Controls.Add(this.fillToolStrip);
            this.tpInsurancePolicy.Controls.Add(this.insurancePolicyDataGridView);
            this.tpInsurancePolicy.Location = new System.Drawing.Point(4, 22);
            this.tpInsurancePolicy.Name = "tpInsurancePolicy";
            this.tpInsurancePolicy.Padding = new System.Windows.Forms.Padding(3);
            this.tpInsurancePolicy.Size = new System.Drawing.Size(621, 389);
            this.tpInsurancePolicy.TabIndex = 1;
            this.tpInsurancePolicy.Text = "Изменение данных медицинского полиса";
            this.tpInsurancePolicy.UseVisualStyleBackColor = true;
            // 
            // txtNumberPolicy
            // 
            this.txtNumberPolicy.Location = new System.Drawing.Point(412, 44);
            this.txtNumberPolicy.Name = "txtNumberPolicy";
            this.txtNumberPolicy.Size = new System.Drawing.Size(156, 20);
            this.txtNumberPolicy.TabIndex = 6;
            this.txtNumberPolicy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumberPolicy
            // 
            this.lblNumberPolicy.AutoSize = true;
            this.lblNumberPolicy.Location = new System.Drawing.Point(354, 47);
            this.lblNumberPolicy.Name = "lblNumberPolicy";
            this.lblNumberPolicy.Size = new System.Drawing.Size(41, 13);
            this.lblNumberPolicy.TabIndex = 5;
            this.lblNumberPolicy.Text = "Номер";
            // 
            // btnChangePolicy
            // 
            this.btnChangePolicy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePolicy.Location = new System.Drawing.Point(400, 84);
            this.btnChangePolicy.Name = "btnChangePolicy";
            this.btnChangePolicy.Size = new System.Drawing.Size(105, 35);
            this.btnChangePolicy.TabIndex = 4;
            this.btnChangePolicy.Text = "Изменить";
            this.btnChangePolicy.UseVisualStyleBackColor = true;
            this.btnChangePolicy.Click += new System.EventHandler(this.btnChangePolicy_Click);
            // 
            // txtSeriesPolicy
            // 
            this.txtSeriesPolicy.Location = new System.Drawing.Point(412, 18);
            this.txtSeriesPolicy.Name = "txtSeriesPolicy";
            this.txtSeriesPolicy.Size = new System.Drawing.Size(156, 20);
            this.txtSeriesPolicy.TabIndex = 3;
            this.txtSeriesPolicy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSeriesPolicy
            // 
            this.lblSeriesPolicy.AutoSize = true;
            this.lblSeriesPolicy.Location = new System.Drawing.Point(354, 21);
            this.lblSeriesPolicy.Name = "lblSeriesPolicy";
            this.lblSeriesPolicy.Size = new System.Drawing.Size(38, 13);
            this.lblSeriesPolicy.TabIndex = 2;
            this.lblSeriesPolicy.Text = "Серия";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastNameToolStripLabel,
            this.lastNameToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(6, 94);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(212, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // lastNameToolStripLabel
            // 
            this.lastNameToolStripLabel.Name = "lastNameToolStripLabel";
            this.lastNameToolStripLabel.Size = new System.Drawing.Size(61, 22);
            this.lastNameToolStripLabel.Text = "Фамилия:";
            // 
            // lastNameToolStripTextBox
            // 
            this.lastNameToolStripTextBox.Name = "lastNameToolStripTextBox";
            this.lastNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillToolStripButton.Text = "Поиск";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // insurancePolicyDataGridView
            // 
            this.insurancePolicyDataGridView.AllowUserToAddRows = false;
            this.insurancePolicyDataGridView.AllowUserToDeleteRows = false;
            this.insurancePolicyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insurancePolicyDataGridView.AutoGenerateColumns = false;
            this.insurancePolicyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.insurancePolicyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.insurancePolicyDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.insurancePolicyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.insurancePolicyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insurancePolicyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.insurancePolicyDataGridView.DataSource = this.insurancePolicyBindingSource;
            this.insurancePolicyDataGridView.Location = new System.Drawing.Point(6, 142);
            this.insurancePolicyDataGridView.MultiSelect = false;
            this.insurancePolicyDataGridView.Name = "insurancePolicyDataGridView";
            this.insurancePolicyDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.insurancePolicyDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.insurancePolicyDataGridView.RowHeadersVisible = false;
            this.insurancePolicyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.insurancePolicyDataGridView.Size = new System.Drawing.Size(609, 239);
            this.insurancePolicyDataGridView.TabIndex = 0;
            this.insurancePolicyDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.insurancePolicyDataGridView_CellEnter);
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Серия";
            this.dataGridViewTextBoxColumn4.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // insurancePolicyBindingSource
            // 
            this.insurancePolicyBindingSource.DataMember = "InsurancePolicy";
            this.insurancePolicyBindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // tpDiagnosis
            // 
            this.tpDiagnosis.Controls.Add(this.btnChangeDiagnosis);
            this.tpDiagnosis.Controls.Add(this.txtDiagnosis_);
            this.tpDiagnosis.Controls.Add(this.lblDiagnosis_);
            this.tpDiagnosis.Controls.Add(this.fillToolStrip1);
            this.tpDiagnosis.Controls.Add(this.diagnosisDataGridView);
            this.tpDiagnosis.Location = new System.Drawing.Point(4, 22);
            this.tpDiagnosis.Name = "tpDiagnosis";
            this.tpDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tpDiagnosis.Size = new System.Drawing.Size(621, 389);
            this.tpDiagnosis.TabIndex = 2;
            this.tpDiagnosis.Text = "Изменение диагноза пациента";
            this.tpDiagnosis.UseVisualStyleBackColor = true;
            // 
            // btnChangeDiagnosis
            // 
            this.btnChangeDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeDiagnosis.Location = new System.Drawing.Point(431, 84);
            this.btnChangeDiagnosis.Name = "btnChangeDiagnosis";
            this.btnChangeDiagnosis.Size = new System.Drawing.Size(105, 35);
            this.btnChangeDiagnosis.TabIndex = 9;
            this.btnChangeDiagnosis.Text = "Изменить";
            this.btnChangeDiagnosis.UseVisualStyleBackColor = true;
            this.btnChangeDiagnosis.Click += new System.EventHandler(this.btnChangeDiagnosis_Click);
            // 
            // txtDiagnosis_
            // 
            this.txtDiagnosis_.Location = new System.Drawing.Point(443, 18);
            this.txtDiagnosis_.Name = "txtDiagnosis_";
            this.txtDiagnosis_.Size = new System.Drawing.Size(156, 20);
            this.txtDiagnosis_.TabIndex = 8;
            this.txtDiagnosis_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiagnosis_
            // 
            this.lblDiagnosis_.AutoSize = true;
            this.lblDiagnosis_.Location = new System.Drawing.Point(385, 21);
            this.lblDiagnosis_.Name = "lblDiagnosis_";
            this.lblDiagnosis_.Size = new System.Drawing.Size(51, 13);
            this.lblDiagnosis_.TabIndex = 7;
            this.lblDiagnosis_.Text = "Диагноз";
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastNameToolStripLabel1,
            this.lastNameToolStripTextBox1,
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(6, 94);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(212, 25);
            this.fillToolStrip1.TabIndex = 1;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // lastNameToolStripLabel1
            // 
            this.lastNameToolStripLabel1.Name = "lastNameToolStripLabel1";
            this.lastNameToolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.lastNameToolStripLabel1.Text = "Фамилия:";
            // 
            // lastNameToolStripTextBox1
            // 
            this.lastNameToolStripTextBox1.Name = "lastNameToolStripTextBox1";
            this.lastNameToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.fillToolStripButton1.Text = "Поиск";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // diagnosisDataGridView
            // 
            this.diagnosisDataGridView.AllowUserToAddRows = false;
            this.diagnosisDataGridView.AllowUserToDeleteRows = false;
            this.diagnosisDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagnosisDataGridView.AutoGenerateColumns = false;
            this.diagnosisDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diagnosisDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.diagnosisDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosisDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.diagnosisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.diagnosisDataGridView.DataSource = this.diagnosisBindingSource;
            this.diagnosisDataGridView.Location = new System.Drawing.Point(6, 142);
            this.diagnosisDataGridView.MultiSelect = false;
            this.diagnosisDataGridView.Name = "diagnosisDataGridView";
            this.diagnosisDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosisDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.diagnosisDataGridView.RowHeadersVisible = false;
            this.diagnosisDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.diagnosisDataGridView.Size = new System.Drawing.Size(609, 239);
            this.diagnosisDataGridView.TabIndex = 0;
            this.diagnosisDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.diagnosisDataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn6.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn7.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn8.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Диагноз";
            this.dataGridViewTextBoxColumn9.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "Diagnosis";
            this.diagnosisBindingSource.DataSource = this.ведение_карточек_пациентов_в_больницеDataSet;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // диагнозTableAdapter
            // 
            this.диагнозTableAdapter.ClearBeforeFill = true;
            // 
            // физическое_лицоTableAdapter
            // 
            this.физическое_лицоTableAdapter.ClearBeforeFill = true;
            // 
            // палатаTableAdapter
            // 
            this.палатаTableAdapter.ClearBeforeFill = true;
            // 
            // карточка_пациентаTableAdapter
            // 
            this.карточка_пациентаTableAdapter.ClearBeforeFill = true;
            // 
            // insurancePolicyTableAdapter
            // 
            this.insurancePolicyTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Hospital.Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДиагнозTableAdapter = this.диагнозTableAdapter;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.Запись_в_карточке_пациентаTableAdapter = null;
            this.tableAdapterManager.Карточка_пациентаTableAdapter = this.карточка_пациентаTableAdapter;
            this.tableAdapterManager.ПалатаTableAdapter = this.палатаTableAdapter;
            this.tableAdapterManager.ПациентTableAdapter = this.пациентTableAdapter;
            this.tableAdapterManager.Страховой_медицинский_полисTableAdapter = null;
            this.tableAdapterManager.Трудовой_договорTableAdapter = null;
            this.tableAdapterManager.Физическое_лицоTableAdapter = this.физическое_лицоTableAdapter;
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 415);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 400);
            this.Name = "FormPatients";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с данными пациентов";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tpAddRecord.ResumeLayout(false);
            this.tpAddRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.карточкаПациентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведение_карточек_пациентов_в_больницеDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическоеЛицоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingSource)).EndInit();
            this.tpInsurancePolicy.ResumeLayout(false);
            this.tpInsurancePolicy.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insurancePolicyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancePolicyBindingSource)).EndInit();
            this.tpDiagnosis.ResumeLayout(false);
            this.tpDiagnosis.PerformLayout();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpAddRecord;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ComboBox cbChamber;
        private System.Windows.Forms.Label lblChamber;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cbPatient;
        public System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cbDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TabPage tpInsurancePolicy;
        private Ведение_карточек_пациентов_в_больницеDataSet ведение_карточек_пациентов_в_больницеDataSet;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private System.Windows.Forms.BindingSource диагнозBindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.ДиагнозTableAdapter диагнозTableAdapter;
        private System.Windows.Forms.BindingSource физическоеЛицоBindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.Физическое_лицоTableAdapter физическое_лицоTableAdapter;
        private System.Windows.Forms.BindingSource палатаBindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.ПалатаTableAdapter палатаTableAdapter;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cbCardNumber;
        public System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.BindingSource карточкаПациентаBindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.Карточка_пациентаTableAdapter карточка_пациентаTableAdapter;
        private System.Windows.Forms.BindingSource insurancePolicyBindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.InsurancePolicyTableAdapter insurancePolicyTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripTextBox lastNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView insurancePolicyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtNumberPolicy;
        private System.Windows.Forms.Label lblNumberPolicy;
        private System.Windows.Forms.Button btnChangePolicy;
        private System.Windows.Forms.TextBox txtSeriesPolicy;
        private System.Windows.Forms.Label lblSeriesPolicy;
        private System.Windows.Forms.ToolStripLabel lastNameToolStripLabel;
        private System.Windows.Forms.TabPage tpDiagnosis;
        private System.Windows.Forms.BindingSource диагнозBindingSource1;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.DiagnosisTableAdapter diagnosisTableAdapter;
        private Ведение_карточек_пациентов_в_больницеDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel lastNameToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox lastNameToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
        private System.Windows.Forms.DataGridView diagnosisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnChangeDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis_;
        private System.Windows.Forms.Label lblDiagnosis_;
    }
}

