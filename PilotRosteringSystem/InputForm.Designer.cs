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
            this.pilotTable = new System.Windows.Forms.DataGridView();
            this.parameter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.periodGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.endDay = new System.Windows.Forms.TextBox();
            this.endMonth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startDay = new System.Windows.Forms.TextBox();
            this.startMonth = new System.Windows.Forms.TextBox();
            this.endYear = new System.Windows.Forms.TextBox();
            this.startYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Night = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Each = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfTactic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotTable)).BeginInit();
            this.parameter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.periodGroup.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.AutoSize = true;
            this.btn_confirm.Location = new System.Drawing.Point(528, 437);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(56, 22);
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
            this.Time});
            this.subjectTable.Location = new System.Drawing.Point(9, 37);
            this.subjectTable.Margin = new System.Windows.Forms.Padding(2);
            this.subjectTable.MultiSelect = false;
            this.subjectTable.Name = "subjectTable";
            this.subjectTable.RowTemplate.Height = 27;
            this.subjectTable.Size = new System.Drawing.Size(575, 396);
            this.subjectTable.TabIndex = 1;
            this.subjectTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectTable_CellContentClick);
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
            this.pilotTable.Location = new System.Drawing.Point(9, 37);
            this.pilotTable.Margin = new System.Windows.Forms.Padding(2);
            this.pilotTable.MultiSelect = false;
            this.pilotTable.Name = "pilotTable";
            this.pilotTable.RowTemplate.Height = 27;
            this.pilotTable.Size = new System.Drawing.Size(575, 396);
            this.pilotTable.TabIndex = 5;
            // 
            // parameter
            // 
            this.parameter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parameter.Controls.Add(this.periodGroup);
            this.parameter.Controls.Add(this.label3);
            this.parameter.Location = new System.Drawing.Point(9, 37);
            this.parameter.Margin = new System.Windows.Forms.Padding(2);
            this.parameter.Name = "parameter";
            this.parameter.Size = new System.Drawing.Size(575, 396);
            this.parameter.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label7, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.startYear, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.endDay, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.startMonth, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.endMonth, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.startDay, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.endYear, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("宋体", 9F);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 74);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // periodGroup
            // 
            this.periodGroup.Controls.Add(this.tableLayoutPanel2);
            this.periodGroup.Font = new System.Drawing.Font("宋体", 10F);
            this.periodGroup.Location = new System.Drawing.Point(14, 13);
            this.periodGroup.Margin = new System.Windows.Forms.Padding(2);
            this.periodGroup.Name = "periodGroup";
            this.periodGroup.Padding = new System.Windows.Forms.Padding(2);
            this.periodGroup.Size = new System.Drawing.Size(284, 133);
            this.periodGroup.TabIndex = 5;
            this.periodGroup.TabStop = false;
            this.periodGroup.Text = "训练周期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "月";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "年";
            // 
            // endDay
            // 
            this.endDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endDay.Font = new System.Drawing.Font("宋体", 9F);
            this.endDay.Location = new System.Drawing.Point(179, 39);
            this.endDay.Margin = new System.Windows.Forms.Padding(0);
            this.endDay.MaxLength = 2;
            this.endDay.Name = "endDay";
            this.endDay.Size = new System.Drawing.Size(36, 21);
            this.endDay.TabIndex = 14;
            this.endDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endMonth
            // 
            this.endMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endMonth.Font = new System.Drawing.Font("宋体", 9F);
            this.endMonth.Location = new System.Drawing.Point(118, 39);
            this.endMonth.Margin = new System.Windows.Forms.Padding(0);
            this.endMonth.MaxLength = 2;
            this.endMonth.Name = "endMonth";
            this.endMonth.Size = new System.Drawing.Size(36, 21);
            this.endMonth.TabIndex = 13;
            this.endMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "年";
            // 
            // startDay
            // 
            this.startDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startDay.Font = new System.Drawing.Font("宋体", 9F);
            this.startDay.Location = new System.Drawing.Point(179, 0);
            this.startDay.Margin = new System.Windows.Forms.Padding(0);
            this.startDay.MaxLength = 2;
            this.startDay.Name = "startDay";
            this.startDay.Size = new System.Drawing.Size(36, 21);
            this.startDay.TabIndex = 9;
            this.startDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startMonth
            // 
            this.startMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startMonth.Font = new System.Drawing.Font("宋体", 9F);
            this.startMonth.Location = new System.Drawing.Point(118, 0);
            this.startMonth.Margin = new System.Windows.Forms.Padding(0);
            this.startMonth.MaxLength = 2;
            this.startMonth.Name = "startMonth";
            this.startMonth.Size = new System.Drawing.Size(36, 21);
            this.startMonth.TabIndex = 8;
            this.startMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endYear
            // 
            this.endYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endYear.Font = new System.Drawing.Font("宋体", 9F);
            this.endYear.Location = new System.Drawing.Point(57, 39);
            this.endYear.Margin = new System.Windows.Forms.Padding(0);
            this.endYear.MaxLength = 4;
            this.endYear.Name = "endYear";
            this.endYear.Size = new System.Drawing.Size(36, 21);
            this.endYear.TabIndex = 7;
            this.endYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startYear
            // 
            this.startYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startYear.Font = new System.Drawing.Font("宋体", 9F);
            this.startYear.Location = new System.Drawing.Point(57, 0);
            this.startYear.Margin = new System.Windows.Forms.Padding(0);
            this.startYear.MaxLength = 4;
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(36, 21);
            this.startYear.TabIndex = 6;
            this.startYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(2, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "结束日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(11, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "时间段个数";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(69, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "科目信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(136, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 4;
            this.button3.Text = "飞行员信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 22);
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
            this.tabPanel.Location = new System.Drawing.Point(9, 6);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.RowCount = 1;
            this.tabPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabPanel.Size = new System.Drawing.Size(213, 26);
            this.tabPanel.TabIndex = 6;
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
            // Time
            // 
            this.Time.HeaderText = "开始时间";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.ToolTipText = "类似20160101格式";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.parameter);
            this.Controls.Add(this.subjectTable);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.pilotTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotTable)).EndInit();
            this.parameter.ResumeLayout(false);
            this.parameter.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.periodGroup.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.tabPanel.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox periodGroup;
        private System.Windows.Forms.TextBox startYear;
        private System.Windows.Forms.TextBox endYear;
        private System.Windows.Forms.TextBox startDay;
        private System.Windows.Forms.TextBox startMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox endDay;
        private System.Windows.Forms.TextBox endMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tabPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Night;
        private System.Windows.Forms.DataGridViewTextBoxColumn Each;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IfTactic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}