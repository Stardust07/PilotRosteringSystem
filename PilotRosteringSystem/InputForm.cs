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

            if (Convert.ToInt32(maxHour7.Text) < 0)
            {
                MessageBox.Show("请输入正确的每7天最大训练时长！");
                return false;
            }

            if (Convert.ToInt32(maxHour30.Text) < 0)
            {
                MessageBox.Show("请输入正确的每30天最大训练时长！");
                return false;
            }

            int i;
            String startDate, endDate;
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);

            startDate = formatDate(startDatePicker.Value.Year.ToString(), startDatePicker.Value.Month.ToString(), startDatePicker.Value.Day.ToString());
            endDate = formatDate(endDatePicker.Value.Year.ToString(), endDatePicker.Value.Month.ToString(), endDatePicker.Value.Day.ToString());

            streamWriter.Write("SCHEDULING_PERIOD\r\n");
            streamWriter.Write(startDate + " " + endDate + "\r\n");   //训练周期

            streamWriter.Write("\r\nDAY_SHIFT\r\n");
            streamWriter.Write("D" + dayShift.Text + " " + "N" + nightShift.Text + "\r\n");   //时间段配置

            streamWriter.Write("\r\nMAX_DAY\r\n");
            streamWriter.Write(maxDays.Text + "\r\n");   //最大连续训练天数配置

            streamWriter.Write("\r\nMAX_HOUR_PER_SEVEN_DAYS\r\n");
            streamWriter.Write(maxHour7.Text + "\r\n");   //每周最大训练时长

            streamWriter.Write("\r\nMAX_HOUR_PER_THIRTY_DAYS\r\n");
            streamWriter.Write(maxHour30.Text + "\r\n");   //每月最大训练时长

            streamWriter.Write("\r\nTACTICAL_TIME\r\n"); //战术科目
            for (i = 0; i < subjectTable.RowCount - 1; i++)
            {
                if ((bool)subjectTable.Rows[i].Cells[7].FormattedValue)
                {
                    String[] strs = subjectTable.Rows[i].Cells[8].Value.ToString().Split(' ')[0].Split('/');
                    startDate = formatDate(strs[0], strs[1], strs[2]);
                    strs = subjectTable.Rows[i].Cells[9].Value.ToString().Split(' ')[0].Split('/');
                    endDate = formatDate(strs[0], strs[1], strs[2]);
                    streamWriter.Write(subjectTable.Rows[i].Cells[0].Value + " " + startDate + " " + endDate);
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
            //CalendarColumn col = new CalendarColumn();
            //DataGridViewColumn col = new DataGridViewColumn();
            //col.HeaderText = "开始时间";
            //subjectTable.Columns.Add(col);
            //col = new CalendarColumn();
            //col.HeaderText = "结束时间";
            //subjectTable.Columns.Add(col);

            
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
                if (contentStrings.Length  - 1 != table.ColumnCount)
                {
                    MessageBox.Show("文件格式错误");
                    return;
                }
                int index = table.Rows.Add();
                for (int i = 0; i < contentStrings.Length && i < table.ColumnCount; i++)
                {
                    if (String.IsNullOrEmpty(contentStrings[i]))
                    {
                        table.Rows[index].Cells[i].ReadOnly = true;
                    }
                    else
                    {
                        //table.Rows[index].Cells[i].ReadOnly = false;
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
                        streamWriter.Write(cell.FormattedValue.ToString() + ",");
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
            String fileName = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "表格文件 (*.csv)|*.csv|文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            fileDialog.InitialDirectory = Application.StartupPath + "\\Temp\\";
            DialogResult result = fileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            else
            {
                fileName = fileDialog.FileName;
            }
            if (subjectTable.Visible == true)
            {
                subjectTable.Rows.Clear();
                readTable(subjectTable, fileName, true);
            }
            else if (pilotTable.Visible == true)
            {
                pilotTable.Rows.Clear();
                readTable(pilotTable, fileName, true);
            } 
            
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            String fileName = "";
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "表格文件 (*.csv)|*.csv|文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            fileDialog.InitialDirectory = Application.StartupPath + "\\Temp\\";
            DialogResult result = fileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            else
            {
                fileName = fileDialog.FileName;
            }
            if (subjectTable.Visible == true)
            {
                writeTable(subjectTable, fileName);
            }
            else if (pilotTable.Visible == true)
            {
                writeTable(pilotTable, fileName);
            } 
        }

        private void subjectTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 7)    //如果是战术科目，允许输入开始时间
            {
                for (int i = 0; i < subjectTable.RowCount; i++)
                {
                    if (i != e.RowIndex)
                    {
                        subjectTable.Rows[i].Cells[7].Value = false;
                        subjectTable.Rows[i].Cells[8].Value = "";
                        subjectTable.Rows[i].Cells[8].ReadOnly = true;
                        subjectTable.Rows[i].Cells[9].Value = "";
                        subjectTable.Rows[i].Cells[9].ReadOnly = true;
                    }
                }

                if ((bool)subjectTable.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue)
                {
                    subjectTable.Rows[e.RowIndex].Cells[8].Value = startDatePicker.Value;
                    subjectTable.Rows[e.RowIndex].Cells[9].Value = endDatePicker.Value;
                    //subjectTable.Rows[e.RowIndex].Cells[8].Value = formatDate(startDatePicker.Value.Year.ToString(), startDatePicker.Value.Month.ToString(), startDatePicker.Value.Day.ToString());
                    //subjectTable.Rows[e.RowIndex].Cells[9].Value = formatDate(endDatePicker.Value.Year.ToString(), endDatePicker.Value.Month.ToString(), endDatePicker.Value.Day.ToString());
                }
                else
                {
                    subjectTable.Rows[e.RowIndex].Cells[8].Value = "";
                    subjectTable.Rows[e.RowIndex].Cells[9].Value = "";
                }
   
                subjectTable.Rows[e.RowIndex].Cells[8].ReadOnly = !(bool)subjectTable.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                subjectTable.Rows[e.RowIndex].Cells[9].ReadOnly = !(bool)subjectTable.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            }
        }

        private void subjectTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)    //如果先序科目数不为零，允许输入序列
            {
                if (!subjectTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals("0"))
                {
                    //subjectTable.Rows[e.RowIndex].Cells[6].ReadOnly = false;
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
            subjectTable.Rows[e.RowIndex].Cells[5].ReadOnly = true;
            subjectTable.Rows[e.RowIndex].Cells[6].ReadOnly = true;
            subjectTable.Rows[e.RowIndex].Cells[8].ReadOnly = true;
            subjectTable.Rows[e.RowIndex].Cells[9].ReadOnly = true;
        }

        public class CalendarColumn : DataGridViewColumn
        {
            public CalendarColumn()
                : base(new CalendarCell())
            {
            }

            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    // Ensure that the cell used for the template is a CalendarCell.
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                    {
                        throw new InvalidCastException("Must be a CalendarCell");
                    }
                    base.CellTemplate = value;
                }
            }
        }
        public class CalendarCell : DataGridViewTextBoxCell
        {

            public CalendarCell()
                : base()
            {
                // Use the short date format.
                this.Style.Format = "d";
            }

            public override void InitializeEditingControl(int rowIndex, object
                initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                CalendarEditingControl ctl =
                    DataGridView.EditingControl as CalendarEditingControl;
                if (this.ValueType == typeof(String))
                {
                    String[] strs = this.Value.ToString().Split(' ')[0].Split('/');
                    int year = Convert.ToInt32(strs[0]);
                    int month = Convert.ToInt32(strs[1]);
                    int day = Convert.ToInt32(strs[2]);
                    ctl.Value = new DateTime(year, month, day);
                }
                else
                {
                    ctl.Value = (DateTime)this.Value;
                }
            }

            public override Type EditType
            {
                get
                {
                    // Return the type of the editing contol that CalendarCell uses.
                    return typeof(CalendarEditingControl);
                }
            }

            public override Type ValueType
            {
                get
                {
                    // Return the type of the value that CalendarCell contains.
                    return typeof(String);
                }
            }

            public override object DefaultNewRowValue
            {
                get
                {
                    // Use the current date and time as the default value.
                    //return DateTime.Now;
                    return null;
                }
            }
        }

        class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
        {
            DataGridView dataGridView;
            private bool valueChanged = false;
            int rowIndex;

            public CalendarEditingControl()
            {
                this.Format = DateTimePickerFormat.Short;
            }

            // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
            // property.
            public object EditingControlFormattedValue
            {
                get
                {
                    return this.Value.ToShortDateString();
                }
                set
                {
                    String newValue = value as String;
                    if (newValue != null)
                    {
                        this.Value = DateTime.Parse(newValue);
                    }
                }
            }

            // Implements the 
            // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
            public object GetEditingControlFormattedValue(
                DataGridViewDataErrorContexts context)
            {
                return EditingControlFormattedValue;
            }

            // Implements the 
            // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
            public void ApplyCellStyleToEditingControl(
                DataGridViewCellStyle dataGridViewCellStyle)
            {
                this.Font = dataGridViewCellStyle.Font;
                this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
                this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
            }

            // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
            // property.
            public int EditingControlRowIndex
            {
                get
                {
                    return rowIndex;
                }
                set
                {
                    rowIndex = value;
                }
            }

            // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
            // method.
            public bool EditingControlWantsInputKey(
                Keys key, bool dataGridViewWantsInputKey)
            {
                // Let the DateTimePicker handle the keys listed.
                switch (key & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                        return true;
                    default:
                        return false;
                }
            }

            // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
            // method.
            public void PrepareEditingControlForEdit(bool selectAll)
            {
                // No preparation needs to be done.
            }

            // Implements the IDataGridViewEditingControl
            // .RepositionEditingControlOnValueChange property.
            public bool RepositionEditingControlOnValueChange
            {
                get
                {
                    return false;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlDataGridView property.
            public DataGridView EditingControlDataGridView
            {
                get
                {
                    return dataGridView;
                }
                set
                {
                    dataGridView = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlValueChanged property.
            public bool EditingControlValueChanged
            {
                get
                {
                    return valueChanged;
                }
                set
                {
                    valueChanged = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingPanelCursor property.
            public Cursor EditingPanelCursor
            {
                get
                {
                    return base.Cursor;
                }
            }

            protected override void OnValueChanged(EventArgs eventargs)
            {
                // Notify the DataGridView that the contents of the cell
                // have changed.
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnValueChanged(eventargs);
            }
        }

        private void subjectTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 5)    //如果是先序科目序列
            {
                subjectTable.Rows[e.RowIndex].Selected = true;

                SelectSubjects form = new SelectSubjects(subjectTable, null);
                form.Show();
            }
        }

        private void pilotTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)    //如果是科目序列
            {
                pilotTable.Rows[e.RowIndex].Selected = true;
                SelectSubjects form = new SelectSubjects(subjectTable, pilotTable);
                form.Show();
            }
        }
    }
}
