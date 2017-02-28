using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilotRosteringSystem
{
    public partial class StatisticsForm : Form
    {
        private MainForm mainForm;
        private DataTable sourceData = null; 
        public StatisticsForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private int addUpYear(int year)
        {
            
            return 0;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {      
            yearsBox.DataSource = mainForm.getDisplayedYears();
            yearsBox.DisplayMember = "year";
            yearsBox.ValueMember = "year";

            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sourceData = mainForm.getStatistics(yearsBox.Text);
            dataGridView.DataSource = sourceData;
            dataGridView.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
        }

        private void StatisticsForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void yearsBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sourceData = mainForm.getStatistics(yearsBox.SelectedValue.ToString());
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = null;
            dataGridView.DataSource = sourceData;
        }

    }
}
