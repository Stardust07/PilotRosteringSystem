namespace PilotRosteringSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.N1Label = new System.Windows.Forms.Label();
            this.D4Label = new System.Windows.Forms.Label();
            this.D2Label = new System.Windows.Forms.Label();
            this.D1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建算例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开算例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开排班表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.统计训练强度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调整计划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置战术时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.D5Label = new System.Windows.Forms.Label();
            this.D3Label = new System.Windows.Forms.Label();
            this.N2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pageContainer.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.colorPanel.SuspendLayout();
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
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(8, 56);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MinimumSize = new System.Drawing.Size(600, 400);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(600, 400);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Tag = "";
            this.dataGridView.VirtualMode = true;
            this.dataGridView.DataSourceChanged += new System.EventHandler(this.dataGridView_DataSourceChanged);
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            this.dataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseUp);
            this.dataGridView.SizeChanged += new System.EventHandler(this.dataGridView_SizeChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // previousButton
            // 
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.previousButton.Location = new System.Drawing.Point(9, 2);
            this.previousButton.Margin = new System.Windows.Forms.Padding(2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(56, 21);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "上一页";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nextButton.Location = new System.Drawing.Point(103, 2);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(56, 21);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "下一页";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // totalPage
            // 
            this.totalPage.AutoSize = true;
            this.totalPage.Location = new System.Drawing.Point(184, 8);
            this.totalPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPage.Name = "totalPage";
            this.totalPage.Size = new System.Drawing.Size(35, 12);
            this.totalPage.TabIndex = 4;
            this.totalPage.Text = "共 页";
            // 
            // pageBox
            // 
            this.pageBox.Location = new System.Drawing.Point(70, 2);
            this.pageBox.Margin = new System.Windows.Forms.Padding(2);
            this.pageBox.MaxLength = 2;
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(30, 21);
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
            this.pageContainer.Location = new System.Drawing.Point(389, 468);
            this.pageContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pageContainer.Name = "pageContainer";
            this.pageContainer.Size = new System.Drawing.Size(220, 33);
            this.pageContainer.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.未完成ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // 未完成ToolStripMenuItem
            // 
            this.未完成ToolStripMenuItem.Name = "未完成ToolStripMenuItem";
            this.未完成ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
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
            this.tipLabel.Location = new System.Drawing.Point(8, 56);
            this.tipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipLabel.Size = new System.Drawing.Size(601, 400);
            this.tipLabel.TabIndex = 0;
            this.tipLabel.Text = "无排班计划";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N1Label
            // 
            this.N1Label.AutoSize = true;
            this.N1Label.BackColor = System.Drawing.Color.SlateGray;
            this.N1Label.Location = new System.Drawing.Point(147, 2);
            this.N1Label.Margin = new System.Windows.Forms.Padding(2);
            this.N1Label.Name = "N1Label";
            this.N1Label.Padding = new System.Windows.Forms.Padding(4);
            this.N1Label.Size = new System.Drawing.Size(25, 20);
            this.N1Label.TabIndex = 3;
            this.N1Label.Text = "N1";
            // 
            // D4Label
            // 
            this.D4Label.AutoSize = true;
            this.D4Label.BackColor = System.Drawing.Color.SkyBlue;
            this.D4Label.Location = new System.Drawing.Point(89, 2);
            this.D4Label.Margin = new System.Windows.Forms.Padding(2);
            this.D4Label.Name = "D4Label";
            this.D4Label.Padding = new System.Windows.Forms.Padding(4);
            this.D4Label.Size = new System.Drawing.Size(25, 20);
            this.D4Label.TabIndex = 2;
            this.D4Label.Text = "D4";
            this.D4Label.Visible = false;
            // 
            // D2Label
            // 
            this.D2Label.AutoSize = true;
            this.D2Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.D2Label.Location = new System.Drawing.Point(31, 2);
            this.D2Label.Margin = new System.Windows.Forms.Padding(2);
            this.D2Label.Name = "D2Label";
            this.D2Label.Padding = new System.Windows.Forms.Padding(4);
            this.D2Label.Size = new System.Drawing.Size(25, 20);
            this.D2Label.TabIndex = 1;
            this.D2Label.Text = "D2";
            // 
            // D1Label
            // 
            this.D1Label.AutoSize = true;
            this.D1Label.BackColor = System.Drawing.Color.LightPink;
            this.D1Label.Location = new System.Drawing.Point(2, 2);
            this.D1Label.Margin = new System.Windows.Forms.Padding(2);
            this.D1Label.Name = "D1Label";
            this.D1Label.Padding = new System.Windows.Forms.Padding(4);
            this.D1Label.Size = new System.Drawing.Size(25, 20);
            this.D1Label.TabIndex = 0;
            this.D1Label.Text = "D1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(158, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "每页列数";
            this.label1.Visible = false;
            // 
            // columnBox
            // 
            this.columnBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.columnBox.Location = new System.Drawing.Point(215, 0);
            this.columnBox.Margin = new System.Windows.Forms.Padding(0);
            this.columnBox.MaxLength = 2;
            this.columnBox.Name = "columnBox";
            this.columnBox.Size = new System.Drawing.Size(24, 21);
            this.columnBox.TabIndex = 14;
            this.columnBox.Text = "7";
            this.columnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBox.Visible = false;
            this.columnBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.columnBox_KeyDown);
            this.columnBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.undoButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(618, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建算例ToolStripMenuItem,
            this.打开算例ToolStripMenuItem,
            this.打开排班表ToolStripMenuItem,
            this.toolStripSeparator1,
            this.统计训练强度ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建算例ToolStripMenuItem
            // 
            this.新建算例ToolStripMenuItem.Name = "新建算例ToolStripMenuItem";
            this.新建算例ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新建算例ToolStripMenuItem.Text = "新建算例";
            this.新建算例ToolStripMenuItem.Click += new System.EventHandler(this.新建算例ToolStripMenuItem_Click);
            // 
            // 打开算例ToolStripMenuItem
            // 
            this.打开算例ToolStripMenuItem.Name = "打开算例ToolStripMenuItem";
            this.打开算例ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开算例ToolStripMenuItem.Text = "打开算例";
            this.打开算例ToolStripMenuItem.Visible = false;
            this.打开算例ToolStripMenuItem.Click += new System.EventHandler(this.打开算例ToolStripMenuItem_Click);
            // 
            // 打开排班表ToolStripMenuItem
            // 
            this.打开排班表ToolStripMenuItem.Name = "打开排班表ToolStripMenuItem";
            this.打开排班表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开排班表ToolStripMenuItem.Text = "打开排班表";
            this.打开排班表ToolStripMenuItem.Click += new System.EventHandler(this.打开排班表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 统计训练强度ToolStripMenuItem
            // 
            this.统计训练强度ToolStripMenuItem.Enabled = false;
            this.统计训练强度ToolStripMenuItem.Name = "统计训练强度ToolStripMenuItem";
            this.统计训练强度ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.统计训练强度ToolStripMenuItem.Text = "统计训练强度";
            this.统计训练强度ToolStripMenuItem.Click += new System.EventHandler(this.统计训练强度ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.调整计划ToolStripMenuItem,
            this.设置战术时间ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Enabled = false;
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.撤销ToolStripMenuItem.Text = "撤销全部";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 调整计划ToolStripMenuItem
            // 
            this.调整计划ToolStripMenuItem.Enabled = false;
            this.调整计划ToolStripMenuItem.Name = "调整计划ToolStripMenuItem";
            this.调整计划ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.调整计划ToolStripMenuItem.Text = "调整计划";
            this.调整计划ToolStripMenuItem.Click += new System.EventHandler(this.调整计划ToolStripMenuItem_Click);
            // 
            // 设置战术时间ToolStripMenuItem
            // 
            this.设置战术时间ToolStripMenuItem.Name = "设置战术时间ToolStripMenuItem";
            this.设置战术时间ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设置战术时间ToolStripMenuItem.Text = "设置战术时间";
            this.设置战术时间ToolStripMenuItem.Click += new System.EventHandler(this.设置战术时间ToolStripMenuItem_Click);
            // 
            // undoButton
            // 
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(32, 24);
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.columnBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(8, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 26);
            this.panel1.TabIndex = 16;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(0, 6);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 16);
            this.timeLabel.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(487, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 26);
            this.panel2.TabIndex = 16;
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.AutoSize = true;
            this.colorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorPanel.ColumnCount = 7;
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.colorPanel.Controls.Add(this.D1Label, 0, 0);
            this.colorPanel.Controls.Add(this.D2Label, 1, 0);
            this.colorPanel.Controls.Add(this.D5Label, 4, 0);
            this.colorPanel.Controls.Add(this.D4Label, 3, 0);
            this.colorPanel.Controls.Add(this.D3Label, 2, 0);
            this.colorPanel.Controls.Add(this.N2Label, 6, 0);
            this.colorPanel.Controls.Add(this.N1Label, 5, 0);
            this.colorPanel.Location = new System.Drawing.Point(406, 24);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.RowCount = 1;
            this.colorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.colorPanel.Size = new System.Drawing.Size(203, 24);
            this.colorPanel.TabIndex = 17;
            // 
            // D5Label
            // 
            this.D5Label.AutoSize = true;
            this.D5Label.BackColor = System.Drawing.Color.LightGreen;
            this.D5Label.Location = new System.Drawing.Point(118, 2);
            this.D5Label.Margin = new System.Windows.Forms.Padding(2);
            this.D5Label.Name = "D5Label";
            this.D5Label.Padding = new System.Windows.Forms.Padding(4);
            this.D5Label.Size = new System.Drawing.Size(25, 20);
            this.D5Label.TabIndex = 6;
            this.D5Label.Text = "D5";
            this.D5Label.Visible = false;
            // 
            // D3Label
            // 
            this.D3Label.AutoSize = true;
            this.D3Label.BackColor = System.Drawing.Color.DarkSalmon;
            this.D3Label.Location = new System.Drawing.Point(60, 2);
            this.D3Label.Margin = new System.Windows.Forms.Padding(2);
            this.D3Label.Name = "D3Label";
            this.D3Label.Padding = new System.Windows.Forms.Padding(4);
            this.D3Label.Size = new System.Drawing.Size(25, 20);
            this.D3Label.TabIndex = 4;
            this.D3Label.Text = "D3";
            // 
            // N2Label
            // 
            this.N2Label.AutoSize = true;
            this.N2Label.BackColor = System.Drawing.Color.IndianRed;
            this.N2Label.Location = new System.Drawing.Point(176, 2);
            this.N2Label.Margin = new System.Windows.Forms.Padding(2);
            this.N2Label.Name = "N2Label";
            this.N2Label.Padding = new System.Windows.Forms.Padding(4);
            this.N2Label.Size = new System.Drawing.Size(25, 20);
            this.N2Label.TabIndex = 5;
            this.N2Label.Text = "N2";
            this.N2Label.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 512);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.pageContainer);
            this.Controls.Add(this.dataGridView);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(632, 546);
            this.Name = "MainForm";
            this.Text = "飞行员训练排班智能系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pageContainer.ResumeLayout(false);
            this.pageContainer.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
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
        private System.Windows.Forms.Label D1Label;
        private System.Windows.Forms.Label N1Label;
        private System.Windows.Forms.Label D4Label;
        private System.Windows.Forms.Label D2Label;
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
        private System.Windows.Forms.ToolStripMenuItem undoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ToolStripMenuItem 新建算例ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel colorPanel;
        private System.Windows.Forms.Label N2Label;
        private System.Windows.Forms.Label D3Label;
        private System.Windows.Forms.Label D5Label;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 统计训练强度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置战术时间ToolStripMenuItem;
    }
}

