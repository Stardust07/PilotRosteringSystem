using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilotRosteringSystem
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parameter.Visible = true;
            pilotTable.Visible = false;
            subjectTable.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subjectTable.Visible = true;
            parameter.Visible = false;
            pilotTable.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pilotTable.Visible = true;
            subjectTable.Visible = false;
            parameter.Visible = false;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            String startDate, endDate;
            startDate = formatDate(startYear.Text, startMonth.Text, startDay.Text);
            endDate = formatDate(endYear.Text, endMonth.Text, endDay.Text);

            FileStream fileStream = new FileStream("instance.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);

            streamWriter.Write("SCHEDULING_PERIOD\r\n");
            streamWriter.Write(startDate + " " + endDate + "\r\n");   //写训练周期
            streamWriter.Write("\r\nTACTICAL_TIME\r\n");
            streamWriter.Write("SUBJECTS " + (subjectTable.RowCount - 1) + "\r\n");
            for (int i = 0; i < subjectTable.RowCount - 1; i++)
            {
                DataGridViewRow row = subjectTable.Rows[i];
                for (int j = 0; j < subjectTable.ColumnCount; j++)
                {
                    streamWriter.Write(row.Cells[j].Value + " ");
                }
                streamWriter.Write("\r\n");
            }
            streamWriter.Close();
        }

        private String formatDate(String year, String month, String day)
        {
            String result = "";
            result += year;
            if (month.Length == 1)
            {
                result += "0";
            }
            result += month;
            if (day.Length == 1)
            {
                result += "0";
            }
            result += day;
            return result;
        }

    }
}
