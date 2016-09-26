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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pilotTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.parameter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.periodGroup = new System.Windows.Forms.GroupBox();
            this.startYear = new System.Windows.Forms.TextBox();
            this.endYear = new System.Windows.Forms.TextBox();
            this.startMonth = new System.Windows.Forms.TextBox();
            this.startDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.endDay = new System.Windows.Forms.TextBox();
            this.endMonth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotTable)).BeginInit();
            this.parameter.SuspendLayout();
            this.periodGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.Location = new System.Drawing.Point(704, 547);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
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
            this.subjectTable.Location = new System.Drawing.Point(12, 46);
            this.subjectTable.MultiSelect = false;
            this.subjectTable.Name = "subjectTable";
            this.subjectTable.RowTemplate.Height = 27;
            this.subjectTable.Size = new System.Drawing.Size(767, 495);
            this.subjectTable.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "配置时间";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(80, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "科目信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(150, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "飞行员信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pilotTable.Location = new System.Drawing.Point(12, 46);
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "夜间训练次数";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            this.IfTactic.HeaderText = "战术科目";
            this.IfTactic.Name = "IfTactic";
            this.IfTactic.ToolTipText = "是否为战术科目";
            // 
            // Time
            // 
            this.Time.HeaderText = "开始时间";
            this.Time.Name = "Time";
            this.Time.ToolTipText = "战术科目的开始时间";
            this.Time.Visible = false;
            // 
            // parameter
            // 
            this.parameter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameter.Controls.Add(this.periodGroup);
            this.parameter.Controls.Add(this.label3);
            this.parameter.Location = new System.Drawing.Point(12, 46);
            this.parameter.Name = "parameter";
            this.parameter.Size = new System.Drawing.Size(767, 495);
            this.parameter.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "结束日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(15, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "时间段个数";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // periodGroup
            // 
            this.periodGroup.Controls.Add(this.label7);
            this.periodGroup.Controls.Add(this.label8);
            this.periodGroup.Controls.Add(this.label9);
            this.periodGroup.Controls.Add(this.endDay);
            this.periodGroup.Controls.Add(this.endMonth);
            this.periodGroup.Controls.Add(this.label6);
            this.periodGroup.Controls.Add(this.label5);
            this.periodGroup.Controls.Add(this.label4);
            this.periodGroup.Controls.Add(this.startDay);
            this.periodGroup.Controls.Add(this.startMonth);
            this.periodGroup.Controls.Add(this.endYear);
            this.periodGroup.Controls.Add(this.startYear);
            this.periodGroup.Controls.Add(this.label1);
            this.periodGroup.Controls.Add(this.label2);
            this.periodGroup.Font = new System.Drawing.Font("宋体", 10F);
            this.periodGroup.Location = new System.Drawing.Point(18, 16);
            this.periodGroup.Name = "periodGroup";
            this.periodGroup.Size = new System.Drawing.Size(359, 128);
            this.periodGroup.TabIndex = 5;
            this.periodGroup.TabStop = false;
            this.periodGroup.Text = "训练周期";
            // 
            // startYear
            // 
            this.startYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startYear.Font = new System.Drawing.Font("宋体", 9F);
            this.startYear.Location = new System.Drawing.Point(111, 35);
            this.startYear.Margin = new System.Windows.Forms.Padding(0);
            this.startYear.MaxLength = 4;
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(47, 25);
            this.startYear.TabIndex = 6;
            this.startYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endYear
            // 
            this.endYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endYear.Font = new System.Drawing.Font("宋体", 9F);
            this.endYear.Location = new System.Drawing.Point(111, 80);
            this.endYear.Margin = new System.Windows.Forms.Padding(0);
            this.endYear.MaxLength = 4;
            this.endYear.Name = "endYear";
            this.endYear.Size = new System.Drawing.Size(47, 25);
            this.endYear.TabIndex = 7;
            this.endYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startMonth
            // 
            this.startMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startMonth.Font = new System.Drawing.Font("宋体", 9F);
            this.startMonth.Location = new System.Drawing.Point(183, 35);
            this.startMonth.Margin = new System.Windows.Forms.Padding(0);
            this.startMonth.MaxLength = 2;
            this.startMonth.Name = "startMonth";
            this.startMonth.Size = new System.Drawing.Size(47, 25);
            this.startMonth.TabIndex = 8;
            this.startMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startDay
            // 
            this.startDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startDay.Font = new System.Drawing.Font("宋体", 9F);
            this.startDay.Location = new System.Drawing.Point(259, 35);
            this.startDay.Margin = new System.Windows.Forms.Padding(0);
            this.startDay.MaxLength = 2;
            this.startDay.Name = "startDay";
            this.startDay.Size = new System.Drawing.Size(47, 25);
            this.startDay.TabIndex = 9;
            this.startDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "年";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "月";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "年";
            // 
            // endDay
            // 
            this.endDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endDay.Font = new System.Drawing.Font("宋体", 9F);
            this.endDay.Location = new System.Drawing.Point(259, 80);
            this.endDay.Margin = new System.Windows.Forms.Padding(0);
            this.endDay.MaxLength = 2;
            this.endDay.Name = "endDay";
            this.endDay.Size = new System.Drawing.Size(47, 25);
            this.endDay.TabIndex = 14;
            this.endDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endMonth
            // 
            this.endMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endMonth.Font = new System.Drawing.Font("宋体", 9F);
            this.endMonth.Location = new System.Drawing.Point(183, 80);
            this.endMonth.Margin = new System.Windows.Forms.Padding(0);
            this.endMonth.MaxLength = 2;
            this.endMonth.Name = "endMonth";
            this.endMonth.Size = new System.Drawing.Size(47, 25);
            this.endMonth.TabIndex = 13;
            this.endMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 582);
            this.Controls.Add(this.parameter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subjectTable);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.pilotTable);
            this.Name = "InputForm";
            this.Text = "InputForm";
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotTable)).EndInit();
            this.parameter.ResumeLayout(false);
            this.parameter.PerformLayout();
            this.periodGroup.ResumeLayout(false);
            this.periodGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.DataGridView subjectTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView pilotTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
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
    }
}