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
            streamWriter.Write(startDate + " " + endDate + "\r\n");   //训练周期

            streamWriter.Write("\r\nTACTICAL_TIME\r\n"); //战术科目
            for (int i = 0; i < subjectTable.RowCount - 1; i++)
            {
                if ((bool)subjectTable.Rows[i].Cells[7].FormattedValue)
                {
                    streamWriter.Write(subjectTable.Rows[i].Cells[0].Value + " " + subjectTable.Rows[i].Cells[8].Value);
                    streamWriter.Write("\r\n");
                    break;
                }
            }

            streamWriter.Write("\r\nSUBJECTS " + (subjectTable.RowCount - 1) + "\r\n");//科目信息
            for (int i = 0; i < subjectTable.RowCount - 1; i++)
            {
                DataGridViewRow row = subjectTable.Rows[i];
                for (int j = 0; j < 5; j++)
                {
                    streamWriter.Write(row.Cells[j].Value + " ");
                }
                streamWriter.Write("\r\n");
            }

            streamWriter.Write("\r\nSUBJECT_DEPENDENCIES\r\n");  //科目依赖关系
            for (int i = 0; i < subjectTable.RowCount - 1; i++)
            {
                DataGridViewRow row = subjectTable.Rows[i];
                streamWriter.Write(row.Cells[0].Value + " " + row.Cells[5].Value + " " + row.Cells[6].Value);
                streamWriter.Write("\r\n");
            }

            streamWriter.Write("\r\nPILOTS " + (pilotTable.RowCount - 1) + "\r\n"); //飞行员信息
            for (int i = 0; i < pilotTable.RowCount - 1; i++)
            {
                DataGridViewRow row = pilotTable.Rows[i];
                for (int j = 0; j < pilotTable.ColumnCount; j++)
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

        private void InputForm_Load(object sender, EventArgs e)
        {
            
        }

        private void subjectTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)    //如果是战术科目，允许输入开始时间
            {
                MessageBox.Show(subjectTable.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString());
                subjectTable.Rows[e.RowIndex].Cells[8].Value = "";
                subjectTable.Rows[e.RowIndex].Cells[8].ReadOnly = !(bool)subjectTable.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            }
        }
    }
}
