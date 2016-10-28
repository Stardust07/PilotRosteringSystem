namespace PilotRosteringSystem
{
    partial class InputForm
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
            this.btn_confirm = new System.Windows.Forms.Button();
            this.subjectTable = new System.Windows.Forms.DataGridView();
            this.Identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Night = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Each = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfTactic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilotTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.maxDays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nightShift = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dayShift = new System.Windows.Forms.ComboBox();
            this.periodGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.TableLayoutPanel();
            this.importBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxHour7 = new System.Windows.Forms.TextBox();
            this.maxHour30 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotTable)).BeginInit();
            this.parameter.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.periodGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.AutoSize = true;
            this.btn_confirm.Location = new System.Drawing.Point(687, 546);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(92, 28);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // subjectTable
            // 
            this.subjectTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identifier,
            this.Day,
            this.Night,
            this.Each,
            this.Max,
            this.Number,
            this.Subjects,
            this.IfTactic,
            this.startTime,
            this.endTime});
            this.subjectTable.Location = new System.Drawing.Point(12, 46);
            this.subjectTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectTable.MultiSelect = false;
            this.subjectTable.Name = "subjectTable";
            this.subjectTable.RowTemplate.Height = 27;
            this.subjectTable.Size = new System.Drawing.Size(767, 495);
            this.subjectTable.TabIndex = 1;
            this.subjectTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectTable_CellContentClick);
            this.subjectTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectTable_CellEndEdit);
            this.subjectTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.subjectTable_RowsAdded);
            // 
            // Identifier
            // 
            this.Identifier.HeaderText = "科目编号";
            this.Identifier.Name = "Identifier";
            // 
            // Day
            // 
            this.Day.HeaderText = "白天训练次数";
            this.Day.Name = "Day";
            // 
            // Night
            // 
            this.Night.HeaderText = "夜间训练次数";
            this.Night.Name = "Night";
            // 
            // Each
            // 
            this.Each.HeaderText = "一次训练小时数";
            this.Each.Name = "Each";
            // 
            // Max
            // 
            this.Max.HeaderText = "同时段最多训练人数";
            this.Max.Name = "Max";
            // 
            // Number
            // 
            this.Number.HeaderText = "先序科目数";
            this.Number.Name = "Number";
            // 
            // Subjects
            // 
            this.Subjects.HeaderText = "先序科目编号序列";
            this.Subjects.Name = "Subjects";
            this.Subjects.ReadOnly = true;
            // 
            // IfTactic
            // 
            this.IfTactic.FalseValue = "0";
            this.IfTactic.HeaderText = "战术科目";
            this.IfTactic.IndeterminateValue = "0";
            this.IfTactic.Name = "IfTactic";
            this.IfTactic.ToolTipText = "是否为战术科目";
            this.IfTactic.TrueValue = "1";
            // 
            // startTime
            // 
            this.startTime.HeaderText = "开始时间";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.ToolTipText = "类似20160101格式";
            // 
            // endTime
            // 
            this.endTime.HeaderText = "结束时间";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            this.endTime.ToolTipText = "类似20160101格式";
            // 
            // pilotTable
            // 
            this.pilotTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pilotTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pilotTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilotTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pilotTable.Location = new System.Drawing.Point(12, 46);
            this.pilotTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pilotTable.MultiSelect = false;
            this.pilotTable.Name = "pilotTable";
            this.pilotTable.RowTemplate.Height = 27;
            this.pilotTable.Size = new System.Drawing.Size(767, 495);
            this.pilotTable.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "飞行员编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "飞行员姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "需训练科目数";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "需训练科目编号序列";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // parameter
            // 
            this.parameter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parameter.Controls.Add(this.groupBox2);
            this.parameter.Controls.Add(this.groupBox1);
            this.parameter.Controls.Add(this.periodGroup);
            this.parameter.Location = new System.Drawing.Point(12, 46);
            this.parameter.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.parameter.Name = "parameter";
            this.parameter.Size = new System.Drawing.Size(767, 495);
            this.parameter.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.maxHour30, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.maxHour7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.maxDays, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("宋体", 9F);
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(25, 48);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(237, 123);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // maxDays
            // 
            this.maxDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxDays.Font = new System.Drawing.Font("宋体", 9F);
            this.maxDays.Location = new System.Drawing.Point(183, 8);
            this.maxDays.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.maxDays.MaxLength = 4;
            this.maxDays.Name = "maxDays";
            this.maxDays.Size = new System.Drawing.Size(47, 25);
            this.maxDays.TabIndex = 6;
            this.maxDays.Text = "4";
            this.maxDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10F);
            this.label10.Location = new System.Drawing.Point(7, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 11, 7, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "最大连续训练天数";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.Location = new System.Drawing.Point(19, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(365, 166);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间段配置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.nightShift, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayShift, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 9F);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 48);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 70);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // nightShift
            // 
            this.nightShift.FormattingEnabled = true;
            this.nightShift.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.nightShift.Location = new System.Drawing.Point(130, 43);
            this.nightShift.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.nightShift.Name = "nightShift";
            this.nightShift.Size = new System.Drawing.Size(95, 23);
            this.nightShift.TabIndex = 10;
            this.nightShift.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(234, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 11, 7, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "（0~2）";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F);
            this.label11.Location = new System.Drawing.Point(7, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 11, 7, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "白天时间段个数";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F);
            this.label13.Location = new System.Drawing.Point(7, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 11, 7, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "夜间时间段个数";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(234, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 11, 7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "（0~5）";
            // 
            // dayShift
            // 
            this.dayShift.FormattingEnabled = true;
            this.dayShift.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.dayShift.Location = new System.Drawing.Point(130, 8);
            this.dayShift.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.dayShift.Name = "dayShift";
            this.dayShift.Size = new System.Drawing.Size(95, 23);
            this.dayShift.Sorted = true;
            this.dayShift.TabIndex = 7;
            this.dayShift.Text = "3";
            // 
            // periodGroup
            // 
            this.periodGroup.Controls.Add(this.tableLayoutPanel2);
            this.periodGroup.Font = new System.Drawing.Font("宋体", 10F);
            this.periodGroup.Location = new System.Drawing.Point(19, 16);
            this.periodGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.periodGroup.Name = "periodGroup";
            this.periodGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.periodGroup.Size = new System.Drawing.Size(365, 196);
            this.periodGroup.TabIndex = 5;
            this.periodGroup.TabStop = false;
            this.periodGroup.Text = "训练周期";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.endDatePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.startDatePicker, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("宋体", 9F);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 48);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 70);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(85, 41);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(205, 25);
            this.endDatePicker.TabIndex = 12;
            this.endDatePicker.Value = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(85, 6);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(205, 25);
            this.startDatePicker.TabIndex = 11;
            this.startDatePicker.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 10, 7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "结束日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 10, 7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(112, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "科目信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(221, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "飞行员信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "配置时间";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPanel
            // 
            this.tabPanel.AutoSize = true;
            this.tabPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tabPanel.ColumnCount = 3;
            this.tabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabPanel.Controls.Add(this.button1, 0, 0);
            this.tabPanel.Controls.Add(this.button3, 2, 0);
            this.tabPanel.Controls.Add(this.button2, 1, 0);
            this.tabPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tabPanel.Location = new System.Drawing.Point(12, 8);
            this.tabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.RowCount = 1;
            this.tabPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabPanel.Size = new System.Drawing.Size(347, 32);
            this.tabPanel.TabIndex = 6;
            // 
            // importBtn
            // 
            this.importBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importBtn.AutoSize = true;
            this.importBtn.Enabled = false;
            this.importBtn.Location = new System.Drawing.Point(619, 15);
            this.importBtn.Margin = new System.Windows.Forms.Padding(5);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 28);
            this.importBtn.TabIndex = 7;
            this.importBtn.Text = "导入";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBtn.AutoSize = true;
            this.exportBtn.Enabled = false;
            this.exportBtn.Location = new System.Drawing.Point(704, 15);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 28);
            this.exportBtn.TabIndex = 8;
            this.exportBtn.Text = "导出";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(401, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(347, 196);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "训练时长配置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 11, 7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "每7天最大训练时长";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(7, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 11, 7, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "每30天最大训练时长";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxHour7
            // 
            this.maxHour7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxHour7.Font = new System.Drawing.Font("宋体", 9F);
            this.maxHour7.Location = new System.Drawing.Point(183, 49);
            this.maxHour7.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.maxHour7.MaxLength = 4;
            this.maxHour7.Name = "maxHour7";
            this.maxHour7.Size = new System.Drawing.Size(47, 25);
            this.maxHour7.TabIndex = 9;
            this.maxHour7.Text = "9";
            this.maxHour7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxHour30
            // 
            this.maxHour30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxHour30.Font = new System.Drawing.Font("宋体", 9F);
            this.maxHour30.Location = new System.Drawing.Point(183, 90);
            this.maxHour30.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.maxHour30.MaxLength = 4;
            this.maxHour30.Name = "maxHour30";
            this.maxHour30.Size = new System.Drawing.Size(47, 25);
            this.maxHour30.TabIndex = 10;
            this.maxHour30.Text = "36";
            this.maxHour30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 582);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.parameter);
            this.Controls.Add(this.subjectTable);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.pilotTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputForm";
            this.Text = "输入算例";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputForm_FormClosed);
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotTable)).EndInit();
            this.parameter.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.periodGroup.ResumeLayout(false);
            this.periodGroup.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.tabPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.DataGridView subjectTable;
        private System.Windows.Forms.DataGridView pilotTable;
        private System.Windows.Forms.Panel parameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox periodGroup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tabPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox maxDays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.ComboBox dayShift;
        private System.Windows.Forms.ComboBox nightShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Night;
        private System.Windows.Forms.DataGridViewTextBoxColumn Each;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IfTactic;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox maxHour30;
        private System.Windows.Forms.TextBox maxHour7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}