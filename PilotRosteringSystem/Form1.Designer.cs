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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageBox = new System.Windows.Forms.TextBox();
            this.pageContainer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pageContainer.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeight = 45;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(10, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(900, 500);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.VirtualMode = true;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(13, 23);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "共 页";
            // 
            // pageBox
            // 
            this.pageBox.Location = new System.Drawing.Point(93, 3);
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(38, 25);
            this.pageBox.TabIndex = 5;
            this.pageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageContainer
            // 
            this.pageContainer.Controls.Add(this.nextButton);
            this.pageContainer.Controls.Add(this.pageBox);
            this.pageContainer.Controls.Add(this.previousButton);
            this.pageContainer.Controls.Add(this.label1);
            this.pageContainer.Location = new System.Drawing.Point(616, 581);
            this.pageContainer.Name = "pageContainer";
            this.pageContainer.Size = new System.Drawing.Size(294, 41);
            this.pageContainer.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(835, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 30);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tipLabel.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipLabel.Location = new System.Drawing.Point(355, 287);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipLabel.Size = new System.Drawing.Size(190, 34);
            this.tipLabel.TabIndex = 8;
            this.tipLabel.Text = "无排班计划";
            this.tipLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 631);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pageContainer);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "飞行员训练排班系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pageContainer.ResumeLayout(false);
            this.pageContainer.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pageBox;
        private System.Windows.Forms.Panel pageContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Label tipLabel;
    }
}

