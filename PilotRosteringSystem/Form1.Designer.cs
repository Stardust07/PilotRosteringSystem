namespace PilotRosteringSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.totalPage = new System.Windows.Forms.Label();
            this.pageBox = new System.Windows.Forms.TextBox();
            this.pageContainer = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.未完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipLabel = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.D1Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开算例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开排班表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调整计划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pageContainer.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.colorPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 45;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(10, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 100;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(800, 500);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Tag = "";
            this.dataGridView.VirtualMode = true;
            this.dataGridView.DataSourceChanged += new System.EventHandler(this.dataGridView_DataSourceChanged);
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            this.dataGridView.SizeChanged += new System.EventHandler(this.dataGridView_SizeChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(10, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 26);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "上一页";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(137, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 26);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "下一页";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // totalPage
            // 
            this.totalPage.AutoSize = true;
            this.totalPage.Location = new System.Drawing.Point(246, 10);
            this.totalPage.Name = "totalPage";
            this.totalPage.Size = new System.Drawing.Size(45, 15);
            this.totalPage.TabIndex = 4;
            this.totalPage.Text = "共 页";
            // 
            // pageBox
            // 
            this.pageBox.Location = new System.Drawing.Point(93, 3);
            this.pageBox.MaxLength = 2;
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(38, 25);
            this.pageBox.TabIndex = 5;
            this.pageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageBox_KeyDown);
            this.pageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            // 
            // pageContainer
            // 
            this.pageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pageContainer.Controls.Add(this.nextButton);
            this.pageContainer.Controls.Add(this.pageBox);
            this.pageContainer.Controls.Add(this.previousButton);
            this.pageContainer.Controls.Add(this.totalPage);
            this.pageContainer.Enabled = false;
            this.pageContainer.Location = new System.Drawing.Point(516, 581);
            this.pageContainer.Name = "pageContainer";
            this.pageContainer.Size = new System.Drawing.Size(294, 41);
            this.pageContainer.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.未完成ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 28);
            // 
            // 未完成ToolStripMenuItem
            // 
            this.未完成ToolStripMenuItem.Name = "未完成ToolStripMenuItem";
            this.未完成ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.未完成ToolStripMenuItem.Text = "未完成";
            this.未完成ToolStripMenuItem.Click += new System.EventHandler(this.未完成ToolStripMenuItem_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tipLabel.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipLabel.Location = new System.Drawing.Point(10, 65);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipLabel.Size = new System.Drawing.Size(800, 500);
            this.tipLabel.TabIndex = 0;
            this.tipLabel.Text = "无排班计划";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.Controls.Add(this.label5);
            this.colorPanel.Controls.Add(this.label4);
            this.colorPanel.Controls.Add(this.label3);
            this.colorPanel.Controls.Add(this.D1Label);
            this.colorPanel.Location = new System.Drawing.Point(647, 21);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(163, 38);
            this.colorPanel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(127, 12);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "N1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(86, 12);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "D3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Location = new System.Drawing.Point(43, 12);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "D2";
            // 
            // D1Label
            // 
            this.D1Label.AutoSize = true;
            this.D1Label.BackColor = System.Drawing.Color.LightPink;
            this.D1Label.Location = new System.Drawing.Point(3, 12);
            this.D1Label.Name = "D1Label";
            this.D1Label.Padding = new System.Windows.Forms.Padding(5);
            this.D1Label.Size = new System.Drawing.Size(33, 25);
            this.D1Label.TabIndex = 0;
            this.D1Label.Text = "D1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开算例ToolStripMenuItem,
            this.打开排班表ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开算例ToolStripMenuItem
            // 
            this.打开算例ToolStripMenuItem.Name = "打开算例ToolStripMenuItem";
            this.打开算例ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.打开算例ToolStripMenuItem.Text = "打开算例";
            this.打开算例ToolStripMenuItem.Click += new System.EventHandler(this.打开算例ToolStripMenuItem_Click);
            // 
            // 打开排班表ToolStripMenuItem
            // 
            this.打开排班表ToolStripMenuItem.Name = "打开排班表ToolStripMenuItem";
            this.打开排班表ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.打开排班表ToolStripMenuItem.Text = "打开排班表";
            this.打开排班表ToolStripMenuItem.Click += new System.EventHandler(this.打开排班表ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.调整计划ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Enabled = false;
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 调整计划ToolStripMenuItem
            // 
            this.调整计划ToolStripMenuItem.Enabled = false;
            this.调整计划ToolStripMenuItem.Name = "调整计划ToolStripMenuItem";
            this.调整计划ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.调整计划ToolStripMenuItem.Text = "调整计划";
            this.调整计划ToolStripMenuItem.Click += new System.EventHandler(this.调整计划ToolStripMenuItem_Click);
            // 
            // columnBox
            // 
            this.columnBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.columnBox.Location = new System.Drawing.Point(584, 34);
            this.columnBox.MaxLength = 2;
            this.columnBox.Name = "columnBox";
            this.columnBox.Size = new System.Drawing.Size(41, 25);
            this.columnBox.TabIndex = 14;
            this.columnBox.Text = "7";
            this.columnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.columnBox_KeyDown);
            this.columnBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "每页列数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.pageContainer);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(840, 47);
            this.Name = "Form1";
            this.Text = "飞行员训练排班系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pageContainer.ResumeLayout(false);
            this.pageContainer.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label totalPage;
        private System.Windows.Forms.TextBox pageBox;
        private System.Windows.Forms.Panel pageContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 未完成ToolStripMenuItem;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label D1Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开算例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开排班表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调整计划ToolStripMenuItem;
        private System.Windows.Forms.TextBox columnBox;
        private System.Windows.Forms.Label label1;
    }
}

