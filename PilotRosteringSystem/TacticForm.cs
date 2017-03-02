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
    public partial class TacticForm : Form
    {
        private MainForm mainForm;
        public TacticForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            String startDate, endDate, currentDate;

            if (DateTime.Compare(currentDatePicker.Value, startDatePicker.Value) >= 0)
            {
                MessageBox.Show("当前日期需要小于战术科目开始日期");
                return;
            }
            if (DateTime.Compare(startDatePicker.Value, endDatePicker.Value) >= 0)
            {
                MessageBox.Show("战术科目开始日期需要小于结束日期");
                return;
            }

            startDate = InputForm.formatDate(startDatePicker.Value.Year.ToString(), startDatePicker.Value.Month.ToString(), startDatePicker.Value.Day.ToString());
            endDate = InputForm.formatDate(endDatePicker.Value.Year.ToString(), endDatePicker.Value.Month.ToString(), endDatePicker.Value.Day.ToString());
            currentDate = InputForm.formatDate(currentDatePicker.Value.Year.ToString(), currentDatePicker.Value.Month.ToString(), currentDatePicker.Value.Day.ToString());
            mainForm.setTacticTime(currentDate, startDate, endDate);
            this.Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
