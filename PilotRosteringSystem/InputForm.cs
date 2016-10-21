using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilotRosteringSystem
{
    public partial class InputForm : Form
    {
        private Form1 form1;
        private String instanceName = "instance.txt";
        public InputForm(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parameter.Visible = true;
            pilotTable.Visible = false;
            subjectTable.Visible = false;
            importBtn.Enabled = false;
            exportBtn.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subjectTable.Visible = true;
            parameter.Visible = false;
            pilotTable.Visible = false;
            importBtn.Enabled = true;
            exportBtn.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pilotTable.Visible = true;
            subjectTable.Visible = false;
            parameter.Visible = false;
            importBtn.Enabled = true;
            exportBtn.Enabled = true;
        }

        private bool saveInstance(String fileName)
        {
            //if (!Regex.IsMatch(startYear.Text, @"^/d*[.]?/d*$") || !Regex.IsMatch(startMonth.Text, @"^/d*[.]?/d*$") || !Regex.IsMatch(startDay.Text, @"^/d*[.]?/d*$")
            //    || !Regex.IsMatch(endYear.Text, @"^/d*[.]?/d*$") || !Regex.IsMatch(endMonth.Text, @"^/d*[.]?/d*$") || !Regex.IsMatch(endDay.Text, @"^/d*[.]?/d*$")
            //    || !Regex.IsMatch(dayShift.Text, @"^/d*[.]?/d*$") || !Regex.IsMatch(nightShift.Text, @"^/d*[.]?/d*$") || !Regex.IsMatch(maxDays.Text, @"^/d*[.]?/d*$"))
            //{
            //    MessageBox.Show("请输入数字！");
            //    return false;
            //}
            if (Convert.ToInt32(dayShift.Text) > 5 || Convert.ToInt32(dayShift.Text) < 0 || Convert.ToInt32(nightShift.Text) > 2 || Convert.ToInt32(nightShift.Text) < 0)
            {
                MessageBox.Show("请输入正确的时间段配置参数！");
                return false;
            }
            
            if (Convert.ToInt32(maxDays.Text) < 0)
            {
                MessageBox.Show("请输入正确的最大连续训练天数！");
                return false;
            }

            int i;
            String startDate, endDate;
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);

            startDate = formatDate(startYear.Text, startMonth.Text, startDay.Text);
            endDate = formatDate(endYear.Text, endMonth.Text, endDay.Text);

            streamWriter.Write("SCHEDULING_PERIOD\r\n");
            streamWriter.Write(startDate + " " + endDate + "\r\n");   //训练周期

            streamWriter.Write("\r\nDAY_SHIFT\r\n");
            streamWriter.Write("D" + dayShift.Text + " " + "N" + nightShift.Text + "\r\n");   //时间段配置

            streamWriter.Write("\r\nMAX_DAY\r\n");
            streamWriter.Write(maxDays.Text + "\r\n");   //最大连续训练天数配置

            streamWriter.Write("\r\nTACTICAL_TIME\r\n"); //战术科目
            for (i = 0; i < subjectTable.RowCount - 1; i++)
            {
                if ((bool)subjectTable.Rows[i].Cells[7].FormattedValue)
                {
                    streamWriter.Write(subjectTable.Rows[i].Cells[0].Value + " " + subjectTable.Rows[i].Cells[8].Value);
                    streamWriter.Write("\r\n");
                    break;
                }
            }
            if (i == subjectTable.RowCount - 1)
            {
                streamWriter.Write("ID_NONE\r\n");
            }

            streamWriter.Write("\r\nSUBJECTS " + (subjectTable.RowCount - 1) + "\r\n");//科目信息
            for (i = 0; i < subjectTable.RowCount - 1; i++)
            {
                DataGridViewRow row = subjectTable.Rows[i];
                for (int j = 0; j < 5; j++)
                {
                    streamWriter.Write(row.Cells[j].Value + " ");
                }
                streamWriter.Write("\r\n");
            }

            streamWriter.Write("\r\nSUBJECT_DEPENDENCIES\r\n");  //科目依赖关系
            for (i = 0; i < subjectTable.RowCount - 1; i++)
            {
                DataGridViewRow row = subjectTable.Rows[i];
                streamWriter.Write(row.Cells[0].Value + " " + row.Cells[5].Value + " " + row.Cells[6].Value);
                streamWriter.Write("\r\n");
            }

            streamWriter.Write("\r\nPILOTS " + (pilotTable.RowCount - 1) + "\r\n"); //飞行员信息
            for (i = 0; i < pilotTable.RowCount - 1; i++)
            {
                DataGridViewRow row = pilotTable.Rows[i];
                for (int j = 0; j < pilotTable.ColumnCount; j++)
                {
                    streamWriter.Write(row.Cells[j].Value + " ");
                }
                streamWriter.Write("\r\n");
            }
            streamWriter.Close();
            return true;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (saveInstance(instanceName))
            {
                form1.setInstance(instanceName);
                this.Close();

            }
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

        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form1.setInstance(instanceName);
        }

        private void readTable(DataGridView table, String file, bool ifSubjects)
        {
            FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.ASCII);
            int rowCount = 0;
            string strLine = "";

            if ((strLine = streamReader.ReadLine()) != null)
            {
                rowCount = Convert.ToInt32(strLine);
            }
            while ((strLine = streamReader.ReadLine()) != null && table.RowCount <= rowCount)
            {
                string[] contentStrings = strLine.Split(',');
                int index = table.Rows.Add();
                for (int i = 0; i < contentStrings.Length && i < table.ColumnCount; i++)
                {
                    if (String.IsNullOrEmpty(contentStrings[i]))
                    {
                        table.Rows[index].Cells[i].ReadOnly = true;
                    }
                    else
                    {
                        table.Rows[index].Cells[i].ReadOnly = false;
                        table.Rows[index].Cells[i].Value = contentStrings[i];
                    }
                }
            }
            
            streamReader.Close();
        }

        private void writeTable(DataGridView table, String file)
        {
            FileStream fileStream = new FileStream(file, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);
            streamWriter.Write((table.RowCount - 1) + "\r\n");
            foreach(DataGridViewRow row in table.Rows) 
            {
                if (row.Index == table.RowCount - 1)
                {
                    break;
                }
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !String.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        streamWriter.Write(cell.Value.ToString() + ",");
                    }
                    else if(cell.ColumnIndex == 7) //战术科目
                    {
                        streamWriter.Write("0" + ",");
                    }
                    else
                    {
                        streamWriter.Write(",");
                    }
                   
                }
                streamWriter.Write("\r\n");
            }
            streamWriter.Close();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if (subjectTable.Visible == true)
            {
                subjectTable.Rows.Clear();
                readTable(subjectTable, "subjects.txt", true);
            }
            else if (pilotTable.Visible == true)
            {
                pilotTable.Rows.Clear();
                readTable(pilotTable, "pilots.txt", true);
            } 
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (subjectTable.Visible == true)
            {
                writeTable(subjectTable, "subjects.txt");
            }
            else if (pilotTable.Visible == true)
            {
                writeTable(pilotTable, "pilots.txt");
            } 
        }

        private void subjectTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)    //如果是战术科目，允许输入开始时间
            {
                for (int i = 0; i < subjectTable.RowCount; i++)
                {
                    if (i != e.RowIndex)
                    {
                        subjectTable.Rows[i].Cells[7].Value = false;
                        subjectTable.Rows[i].Cells[8].Value = "";
                        subjectTable.Rows[i].Cells[8].ReadOnly = true;
                    }
                }
                
                subjectTable.Rows[e.RowIndex].Cells[8].Value = "";
                subjectTable.Rows[e.RowIndex].Cells[8].ReadOnly = !(bool)subjectTable.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            }
        }

        private void subjectTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void subjectTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)    //如果先序科目数不为零，允许输入序列
            {
                if (!subjectTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals("0"))
                {
                    subjectTable.Rows[e.RowIndex].Cells[6].ReadOnly = false;
                }
                else
                {
                    subjectTable.Rows[e.RowIndex].Cells[6].Value = "";
                    subjectTable.Rows[e.RowIndex].Cells[6].ReadOnly = true;
                }
            }
        }

        private void subjectTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            subjectTable.Rows[e.RowIndex].Cells[8].ReadOnly = true;
        }
    }
}
