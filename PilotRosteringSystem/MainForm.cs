using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace PilotRosteringSystem
{
    public partial class MainForm : Form
    {
        class UnfinishedItem
        {
            private int rowIndex, columnIndex;
            private String subject;
            private Color backColor;

            public UnfinishedItem(int x, int y, String subject, Color color)
            {
                this.rowIndex = x;
                this.columnIndex = y;
                this.subject = subject;
                this.backColor = color;
            }

            public int getRow()
            {
                return rowIndex;
            }
            public int getColumn()
            {
                return columnIndex;
            }
            public String getSubject()
            {
                return subject;
            }
            public Color getColor()
            {
                return backColor;
            }
        }

        [DllImport("PilotRosteringSolver.dll", EntryPoint = "createRoster")]
        public static extern void createRoster(string instanceFilePath, string rosterFilePath, string unfinishedIemsFilePath, string tacticTimeFilePath, bool ifRecovery, bool ifTactic);

        private const int maxDayshift = 5;
        private int numberOfPerPage = 30;
        private const String HEADER = " ";
        private DataTable sourceData;
        private int currentPage, pageCount, currentYear, currentMonth, weekOfFirstDay, currentOffset;
        private String instanceFile, lastRoster, tacticTimeFile, unfinishedFile, unfinishedDate;
        private Hashtable colorTable, shiftTable;
        private String[] shifts = { "D1", "D2", "D3", "D4", "D5", "N1", "N2" };
        private Color[] colors = { Color.LightPink, Color.FromArgb(180, 180, 255), Color.DarkSalmon, Color.SkyBlue, Color.LightGreen, Color.SlateGray, Color.IndianRed };
        private String[] weekDays = { "周一", "周二", "周三", "周四", "周五", "周六", "周日" };
        private ArrayList unfinishedList, unfinishedActionList;
        private int dayShifts, nightShifts;
        private Label[] shiftLabels = { };
        private int startOfTactic, endOfTactic;
        private DateTime startDate, endDate;
        private String identifierOfTactic;

        public MainForm()
        {
            InitializeComponent();
            initialize();
        }
        private void initialize()
        {
            currentPage = 1;
            pageCount = 0;
            currentYear = 2016;
            currentMonth = 1;
            weekOfFirstDay = 1;
            currentOffset = 0;
            startOfTactic = 0;
            endOfTactic = 0;
            dayShifts = 3;
            nightShifts = 1;

            instanceFile = "instance_1.txt";
            lastRoster = "roster.csv";
            tacticTimeFile = "tactic.txt";
            unfinishedFile = "unfinished.txt";
            unfinishedDate = "";
            identifierOfTactic = "";

            unfinishedList = new ArrayList();
            unfinishedActionList = new ArrayList();
            colorTable = new Hashtable();
            shiftTable = new Hashtable();
            columnBox.Text = numberOfPerPage.ToString();

            shiftLabels = new Label[shifts.Length];
            for (int i = 0; i < shifts.Length; i++)
            {
                shiftLabels[i] = (Label)this.Controls.Find(shifts[i] + "label", true)[0];
                shiftLabels[i].Visible = false;
            }
        }

        private void setShiftTable()
        {
            colorTable.Clear();
            shiftTable.Clear();
            for (int i = 0; i < shiftLabels.Length; i++)
            {
                shiftLabels[i].Visible = false;
            }
            for (int i = 0; i < dayShifts; i++)
            {
                colorTable.Add(shifts[i], colors[i]);
                shiftTable.Add(colors[i], shifts[i]);
                shiftLabels[i].Visible = true;
            }

            for (int i = 0; i < nightShifts; i++)
            {
                colorTable.Add(shifts[i + maxDayshift], colors[i + maxDayshift]);
                shiftTable.Add(colors[i + maxDayshift], shifts[i + maxDayshift]);
                shiftLabels[i + maxDayshift].Visible = true;
            }
        }

        private void createRosterAndLoad(bool ifRecovery, bool ifTactic)
        {
            String fileName = "roster";
            createRoster(instanceFile, lastRoster, unfinishedFile, tacticTimeFile, ifRecovery, ifTactic);
            if (ifRecovery)
            {
                fileName += unfinishedDate + ".csv"; ;
            } else if (ifTactic)
            {
                fileName = lastRoster;
            }
            else
            {
                fileName += ".csv";
            }
            
            lastRoster = fileName;
            loadRoster(fileName, !(ifRecovery | ifTactic));
        }
        private void loadRosterByPage(int currentPage)
        {
            setNumberOfPerpage(currentPage);
            dataGridView.DataSource = null;

            pageContainer.Visible = true;
            tipLabel.Visible = false;

            //dataGridView.DataSource = getDataByDay(currentOffset + (currentPage - 1) * numberOfPerPage + 1);
            dataGridView.DataSource = getDataByPage(currentPage);
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            adjustPage();
            dataGridView.ClearSelection();
            timeLabel.Text = "";
            timeLabel.Text = currentYear.ToString() + dataGridView.Columns[1].HeaderText.Substring(0, 4) + "--"
                + currentYear.ToString() + dataGridView.Columns[numberOfPerPage].HeaderText.Substring(0, 4);
        }
        private void loadRoster(String fileName, bool isFirstLoad)
        {
            sourceData = readRoster(fileName, isFirstLoad);
            if (sourceData == null)
            {
                return;
            }
            if (isFirstLoad)
            {
                currentPage = 1;
            }

            loadRosterByPage(currentPage);
            pageContainer.Enabled = true;
            totalPage.Text = "共" + pageCount.ToString() + "页";
            统计训练强度ToolStripMenuItem.Enabled = true;
        }

        private void adjustPage()
        {
            pageBox.Text = currentPage.ToString();
            if (currentPage == 1)
            {
                previousButton.Enabled = false;
                nextButton.Enabled = true;
            }
            else if (currentPage == pageCount)
            {
                previousButton.Enabled = true;
                nextButton.Enabled = false;
            }
            else
            {
                previousButton.Enabled = true;
                nextButton.Enabled = true;
            }
            totalPage.Text = "共" + pageCount.ToString() + "页";
        }

        private DataTable readRoster(String filePath, bool isFirstLoad)
        {
            DataTable dataTable = new DataTable();
            FileStream fileStream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.ASCII);
            string strLine = "";
            int columnCount = 0;
            if ((strLine = streamReader.ReadLine()) != null)  //read the instance name
            {
                instanceFile = strLine;
            }
            if ((strLine = streamReader.ReadLine()) != null)  //read the shift setting
            {
                string[] contentStrings = strLine.Split(',');
                if (!Int32.TryParse(contentStrings[0], out dayShifts) || !Int32.TryParse(contentStrings[1], out nightShifts))
                {
                    MessageBox.Show("文件格式错误01");
                    return null;
                }
            }
            if (isFirstLoad)
            {
                setShiftTable();
            }
            if ((strLine = streamReader.ReadLine()) != null)  //read the tactic time
            {
                string[] contentStrings = strLine.Split(',');
                identifierOfTactic = contentStrings[0];
                if (!Int32.TryParse(contentStrings[1], out startOfTactic) || !Int32.TryParse(contentStrings[2], out endOfTactic))
                {
                    MessageBox.Show("文件格式错误02");
                    return null;
                }
            }
            //读取表头
            if ((strLine = streamReader.ReadLine()) != null)
            {
                DataColumn dataColumn;

                string[] tableHeader = strLine.Split(',');
                int year, month, day;
                columnCount = tableHeader.Length - 1;
                year = Convert.ToInt32(tableHeader[2].Substring(0, 4));
                month = Convert.ToInt32(tableHeader[2].Substring(4, 2));
                day = Convert.ToInt32(tableHeader[2].Substring(6, 2));
                startDate = new DateTime(year, month, day);

                currentYear = year;
                currentMonth = month;
                GregorianCalendar gc = new GregorianCalendar();
                DateTime dt = gc.ToDateTime(currentYear, month, day, 0, 0, 0, 0);
                weekOfFirstDay = Convert.ToInt32(dt.DayOfWeek) == 0 ? 7 : Convert.ToInt32(dt.DayOfWeek);
                dataColumn = new DataColumn(tableHeader[0]);
                dataTable.Columns.Add(dataColumn);
                dataColumn = new DataColumn(tableHeader[1]);
                dataTable.Columns.Add(dataColumn);
                for (int i = 2; i <= columnCount; i++)
                {
                    dataColumn = new DataColumn(tableHeader[i] + "\r\n" + weekDays[(i + weekOfFirstDay - 3) % 7]);
                    dataTable.Columns.Add(dataColumn);
                }
                year = Convert.ToInt32(tableHeader[columnCount].Substring(0, 4));
                month = Convert.ToInt32(tableHeader[columnCount].Substring(4, 2));
                day = Convert.ToInt32(tableHeader[columnCount].Substring(6, 2));
                endDate = new DateTime(year, month, day);
            }
            else
            {
                return null;
            }
            while ((strLine = streamReader.ReadLine()) != null)
            {
                string[] contentStrings = strLine.Split(',');
                DataRow dataRow = dataTable.NewRow();
                for (int j = 0; j < columnCount; j++)
                {
                    dataRow[j] = contentStrings[j];
                }
                dataTable.Rows.Add(dataRow);
            }

            streamReader.Close();
            fileStream.Close();
            pageCount = 12 * (endDate.Year - startDate.Year) + endDate.Month - startDate.Month + 1;
            return dataTable;
        }

        private DataTable getDataByDay(int start)
        {

            DataTable desData = new DataTable();
            int columnsCount = sourceData.Columns.Count;
            desData.Columns.Add(new DataColumn(HEADER));
            int i = start;
            for (; i <= 0; i++)
            {
                DataColumn dataColumn = new DataColumn(formatDate(i - 1));
                desData.Columns.Add(dataColumn);
            }
            for (; i - start < numberOfPerPage && i < columnsCount; i++)
            {
                DataColumn dataColumn = new DataColumn(sourceData.Columns[i].ColumnName);
                desData.Columns.Add(dataColumn);
            }
            for (; i - start < numberOfPerPage; i++)
            {
                DataColumn dataColumn = new DataColumn(formatDate(i - columnsCount));
                desData.Columns.Add(dataColumn);
            }

            int rowsCount = sourceData.Rows.Count;
            for (i = 0; i < rowsCount; i++)
            {
                DataRow dataRow = desData.NewRow();
                dataRow[0] = sourceData.Rows[i][0].ToString();
                for (int j = 1; j <= numberOfPerPage && j + start - 1 < columnsCount; j++)
                {
                    if (j + start - 1 >= 1)
                    {
                        dataRow[j] = sourceData.Rows[i][j + start - 1].ToString();
                    }
                }
                desData.Rows.Add(dataRow);
            }

            return desData;
        }

        private DataTable getDataByPage(int pageIndex)  //根据月份计算每页数据
        {
            DateTime firstDay = new DateTime(currentYear, currentMonth, 1);
            int baseOffset = 0;
            DataTable desData = new DataTable();
            int columnsCount = sourceData.Columns.Count;
            desData.Columns.Add(new DataColumn(HEADER));
            if (pageIndex == 1)
            {
                baseOffset = 0;
            }
            else if (currentYear == startDate.Year)
            {
                baseOffset = firstDay.DayOfYear - startDate.DayOfYear;
            }
            else
            {
                baseOffset += DateTime.IsLeapYear(startDate.Year) ? 366 : 365 - startDate.DayOfYear;
                for (int i = startDate.Year + 1; i < currentYear; i++)
                {
                    baseOffset += DateTime.IsLeapYear(i) ? 366 : 365;
                }
                baseOffset += firstDay.DayOfYear;
            }
            for (int i = 0; i < numberOfPerPage && i + baseOffset + 1 < columnsCount; i++)
            {
                DataColumn dataColumn = new DataColumn(sourceData.Columns[i + baseOffset + 2].ColumnName.Substring(4));

                desData.Columns.Add(dataColumn);
            }

            int intensity = 0;
            int rowsCount = sourceData.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                DataRow dataRow = desData.NewRow();
                dataRow[0] = sourceData.Rows[i][1].ToString();
                for (int j = 1; j <= numberOfPerPage && j + baseOffset < columnsCount; j++)
                {
                    dataRow[j] = sourceData.Rows[i][j + baseOffset + 1].ToString();
                    if (!String.IsNullOrEmpty(dataRow[j].ToString()))
                    {
                        intensity++;
                    }
                }
                //dataRow[0] += intensity.ToString();
                desData.Rows.Add(dataRow);
                intensity = 0;
            }

            return desData;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int futurePage = (dateTimePicker.Value.DayOfYear - currentOffset - 1) / numberOfPerPage + 1;
            if (currentPage == futurePage)
            {
                return;
            }
            currentPage = futurePage;
            loadRosterByPage(currentPage);
        }

        private void adjustCalendar()
        {
            //String timeString = dataGridView.Columns[1].HeaderText.ToString();
            //int year = Convert.ToInt32(timeString.Substring(0, 4));
            //int month, day;
            //if (year == currentYear)
            //{
            //    month = Convert.ToInt32(timeString.Substring(4, 2));
            //    day = Convert.ToInt32(timeString.Substring(6, 2));
            //}
            //else if (year < currentYear)
            //{
            //    year = currentYear;
            //    month = 1;
            //    day = 1;
            //}
            //else
            //{
            //    year = currentYear;
            //    month = 12;
            //    day = 31;
            //}
            //dateTimePicker.Value = new DateTime(year, month, day, new GregorianCalendar());
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            loadRosterByPage(--currentPage);
            adjustCalendar();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            loadRosterByPage(++currentPage);
            adjustCalendar();
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex > 0)
                {
                    if (String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    {
                        return;
                    }
                    if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == false)
                    {
                        dataGridView.ClearSelection();
                        dataGridView.CurrentCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void setCellBackColor()
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 1; j < dataGridView.ColumnCount; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value.ToString().Contains('|'))
                    {
                        String[] cellStrings = new String[2];
                        cellStrings = dataGridView.Rows[i].Cells[j].Value.ToString().Split('|');
                        dataGridView.Rows[i].Cells[j].Style.BackColor = (Color)colorTable[cellStrings[1]];
                        dataGridView.Rows[i].Cells[j].Value = cellStrings[0];
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = tipLabel.Width;
            int height = tipLabel.Height;
            dataGridView.ClearSelection();
            dataGridView.Size = new Size(width, height);
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersVisible = true;
        }

        private void 未完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int columnIndex = dataGridView.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView.CurrentCell.RowIndex;

            DataGridViewSelectedCellCollection selectedCells = dataGridView.SelectedCells;
            for (int i = 0; i < selectedCells.Count; i++)
            {
                if (selectedCells[i].ColumnIndex != columnIndex)
                {
                    MessageBox.Show("不允许选择多列");
                    dataGridView.ClearSelection();
                    return;
                }
            }
            if (updateUnfinishedList(dataGridView.Columns[columnIndex].HeaderText, selectedCells))
            {
                foreach (DataGridViewCell cell in selectedCells)
                {
                    cell.Value = "";
                    cell.Style.BackColor = dataGridView.Columns[cell.ColumnIndex].HeaderCell.Style.BackColor;
                }
            }
            else
            {
                MessageBox.Show("请选择" + unfinishedDate.ToString() + "的计划");
            }
            dataGridView.ClearSelection();
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            setCellBackColor();

            for (int i = 1; i < dataGridView.ColumnCount; i++)
            {
                int day = Convert.ToInt32(currentYear.ToString() + dataGridView.Columns[i].HeaderText.Substring(0, 4));
                if (day >= startOfTactic && day <= endOfTactic)
                {
                    dataGridView.Columns[i].HeaderCell.Style.BackColor = Color.Silver;
                    dataGridView.Columns[i].DefaultCellStyle.BackColor = Color.Silver;
                }
            }
        }

        private bool isDateEqual(String date)
        {
            return unfinishedDate.Substring(4, 4).Equals(date.Substring(0, 4));
        }

        private bool updateUnfinishedList(String date, DataGridViewSelectedCellCollection cells)
        {

            if (unfinishedList.Count != 0 && !isDateEqual(date))
            {
                return false;
            }
            if (unfinishedList.Count == 0)
            {
                undoButton.Enabled = true;
                撤销ToolStripMenuItem.Enabled = true;
                调整计划ToolStripMenuItem.Enabled = true;
                unfinishedDate = currentYear + date.Substring(0, 4);
            }
            unfinishedActionList.Add(cells.Count);
            for (int i = 0; i < cells.Count; i++)
            {
                if (!String.IsNullOrEmpty(cells[i].Value.ToString()))
                {
                    unfinishedList.Add(new UnfinishedItem(cells[i].RowIndex, cells[i].ColumnIndex, cells[i].Value.ToString(), cells[i].Style.BackColor));
                }
            }

            return true;
        }

        private void writeUnfinished()
        {
            FileStream fileStream = new FileStream(unfinishedFile, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);

            streamWriter.Write(unfinishedDate + " " + unfinishedList.Count.ToString() + "\r\n");
            for (int i = 0; i < unfinishedList.Count; i++)
            {
                String unfinished = "";
                UnfinishedItem item = (UnfinishedItem)unfinishedList[i];
                unfinished += sourceData.Rows[item.getRow()][0] + " ";
                unfinished += item.getSubject() + " ";
                unfinished += shiftTable[item.getColor()] + "\r\n";
                streamWriter.Write(unfinished);
            }
            streamWriter.Close();
            fileStream.Close();
            unfinishedList.Clear();
            unfinishedActionList.Clear();
        }

        private void dataGridView_SizeChanged(object sender, EventArgs e)
        {
            //if (numberOfPerPage == (dataGridView.Width - 1) / 100)
            //{
            //    return;
            //}
            //if (userPage == 0)
            //{
            //    numberOfPerPage = (dataGridView.Width - 1) / 100 > 7 ? (dataGridView.Width - 1) / 100 : 7;
            //}
            //else
            //{
            //    numberOfPerPage = userPage;
            //    userPage = 0;
            //}
            //loadPageAfterResizing();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int length = unfinishedList.Count;
            for (int i = 0; i < length; i++)
            {
                recoverItem();
            }
            unfinishedActionList.Clear();
        }

        private void 调整计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeUnfinished();
            createRosterAndLoad(true, false);
            undoButton.Enabled = false;
            撤销ToolStripMenuItem.Enabled = false;
            调整计划ToolStripMenuItem.Enabled = false;
        }

        private void 打开算例ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*"; //过滤文件类型
            fileDialog.InitialDirectory = Application.StartupPath + "\\Temp\\";//设定初始目录
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                instanceFile = fileDialog.FileName;
                createRosterAndLoad(false, false);
                return;
            }
        }

        private void 打开排班表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "表格文件 (*.csv)|*.csv|所有文件 (*.*)|*.*";
            fileDialog.InitialDirectory = Application.StartupPath + "\\Temp\\";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                lastRoster = fileDialog.FileName;
                loadRoster(lastRoster, true);
                return;
            }
        }

        private void pageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int page = Convert.ToInt32(pageBox.Text);
                if (page > 0 && page <= pageCount)
                {
                    currentPage = page;
                    loadRosterByPage(currentPage);
                }
                else if (page > pageCount)
                {
                    pageBox.Text = pageCount.ToString();
                    currentPage = pageCount;
                    loadRosterByPage(currentPage);
                }
                else
                {
                    pageBox.Text = 1.ToString();
                    currentPage = 1;
                    loadRosterByPage(currentPage);
                }
                adjustCalendar();
            }
        }

        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void columnBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    userPage = Convert.ToInt32(columnBox.Text);
            //    if (userPage < 7)
            //    {
            //        userPage = 7;
            //        columnBox.Text = userPage.ToString();
            //    }
            //    resize(userPage);
            //    if (numberOfPerPage != Convert.ToInt32(columnBox.Text))
            //    {
            //        numberOfPerPage = Convert.ToInt32(columnBox.Text);
            //        loadPageAfterResizing();
            //    }
            //}
        }

        private void setNumberOfPerpage(int page)
        {
            currentYear = startDate.Year + (startDate.Month + page - 2) / 12;
            currentMonth = (startDate.Month + page - 2) % 12 + 1;
            if (page == 1)
            {
                numberOfPerPage = DateTime.DaysInMonth(startDate.Year, startDate.Month) - startDate.Day + 1;
            }
            else if (page == pageCount)
            {
                numberOfPerPage = endDate.Day;
            }
            else
            {
                numberOfPerPage = DateTime.DaysInMonth(currentYear, currentMonth);
            }
            columnBox.Text = numberOfPerPage.ToString();
        }

        private String formatDate(int offset)
        {
            String date = "";
            DateTime dt;
            if (offset < 0)
            {
                date += (currentYear - 1).ToString();
                dt = new DateTime(currentYear - 1, 12, 31);
                offset++;
            }
            else
            {
                dt = new DateTime(currentYear + 1, 1, 1);
                date += (currentYear + 1).ToString();
            }
            dt = dt.AddDays(offset);
            if (dt.Month < 10)
            {
                date += "0";
            }
            date += dt.Month.ToString();
            if (dt.Day < 10)
            {
                date += "0";
            }
            date += dt.Day.ToString();
            date += "\r\n" + weekDays[(Convert.ToInt32(dt.DayOfWeek) + 6) % 7];
            return date;
        }

        private void undoButton_Click_1(object sender, EventArgs e)
        {
            if (unfinishedList.Count == 0)
            {
                return;
            }
            Object count = unfinishedActionList[unfinishedActionList.Count - 1];
            for (int i = 0; i < (int)count; i++)
            {
                recoverItem();
            }
            unfinishedActionList.Remove(count);

        }

        private void recoverItem()
        {
            UnfinishedItem item = (UnfinishedItem)unfinishedList[unfinishedList.Count - 1];
            int row = item.getRow();
            int column = item.getColumn();
            Color color = item.getColor();
            String value = item.getSubject();
            dataGridView.Rows[row].Cells[column].Value = value;
            dataGridView.Rows[row].Cells[column].Style.BackColor = color;
            unfinishedList.Remove(item);
            if (unfinishedList.Count == 0)
            {
                unfinishedDate = "";
                撤销ToolStripMenuItem.Enabled = false;
                调整计划ToolStripMenuItem.Enabled = false;
            }
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = dataGridView.SelectedCells;
            foreach (DataGridViewCell cell in selectedCells)
            {
                if (String.IsNullOrEmpty(cell.Value.ToString()))
                {
                    cell.Selected = false;
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
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

        private void 新建算例ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm(this);
            input.Show();
        }
        
        public void setInstance(String instance)
        {
            instanceFile = instance;
            createRosterAndLoad(false, false);
        }

        private void 统计训练强度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm(this);
            statistics.Show();
        }

        private int getIntensity(int pilot, int month, int year)  //calculate intensity of each month
        {
            int intensity = 0, range = 0, baseOffset;
            DataRow row = sourceData.Rows[pilot];
            DateTime firstDay = new DateTime(year, month, 1);
            
            if (year == startDate.Year && month == startDate.Month)
            {
                range = DateTime.DaysInMonth(year, month) - startDate.Day + 1;
            }
            else if(year == endDate.Year && month == endDate.Month)
            {
                range = endDate.Day;
            }
            else
            {
                range = DateTime.DaysInMonth(year, month);
            }

            if (year == startDate.Year && month == startDate.Month)
            {
                baseOffset = 0;
            }
            else if (year == startDate.Year)
            {
                baseOffset = firstDay.DayOfYear - startDate.DayOfYear;
            }
            else
            {
                baseOffset = DateTime.IsLeapYear(startDate.Year) ? 366 : 365 - startDate.DayOfYear;
                for (int i = startDate.Year + 1; i < year; i++)
                {
                    baseOffset += DateTime.IsLeapYear(i) ? 366 : 365;
                }
                baseOffset += firstDay.DayOfYear;
            }
            baseOffset++;

            for (int j = 1; j <= range && j + baseOffset <= sourceData.Columns.Count; j++)
            {
                if (!String.IsNullOrEmpty(row[j + baseOffset].ToString()))
                {
                    intensity++;
                }
            }
            return intensity;
        }

        public DataTable getStatistics(String year)
        {
            DataTable result = new DataTable();
            DataRow row = null;
            int startMonth = 1, endMonth = 12;
            DataColumn col = new DataColumn(" ");
            result.Columns.Add(col);

            if (Convert.ToInt32(year) == startDate.Year)
            {
                startMonth = startDate.Month;
            }
            else if (Convert.ToInt32(year) == endDate.Year)
            {
                endMonth = endDate.Month;
            }

            for (int i = startMonth; i <= endMonth; i++)
            {
                col = new DataColumn(i.ToString() + "月");
                col.DataType = Type.GetType("System.Int32");
                result.Columns.Add(col);
            }
            col = new DataColumn("合计");
            col.DataType = Type.GetType("System.Int32");
            result.Columns.Add(col);

            for (int i = 0; i < sourceData.Rows.Count; i++)
            {
                int all = 0;
                row = result.NewRow();
                row[0] = sourceData.Rows[i][1];
                for (int j = startMonth; j <= endMonth; j++)
                {
                    int intensity = getIntensity(i, j, Convert.ToInt32(year));
                    row[j - startMonth + 1] = intensity;
                    all += intensity;
                }
                row[endMonth - startMonth + 2] = all;
                result.Rows.Add(row);
            }
            return result;
        }

        public DataTable getDisplayedYears()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("year");

            for (int i = startDate.Year; i <= endDate.Year; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i.ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void 设置战术时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(identifierOfTactic))
            {
                MessageBox.Show("没有战术科目！");
                return;
            }
            TacticForm form = new TacticForm(this);
            form.Show();
        }

        public void setTacticTime(String currentDate, String startDate, String endDate)
        {
            string con = "";
            FileStream fs = new FileStream(instanceFile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            con = sr.ReadToEnd();
            con = con.Replace("ID_NONE", startDate + " " + endDate);
            sr.Close();
            fs.Close();
            FileStream fs2 = new FileStream(instanceFile, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            sw.WriteLine(con);
            sw.Close();
            fs2.Close();


            FileStream fileStream = new FileStream(tacticTimeFile, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);
            streamWriter.Write(currentDate + "\r\n" + startDate + "\r\n" + endDate + "\r\n");
            streamWriter.Close();
            fileStream.Close();

            createRosterAndLoad(false, true);
        }
    }
}
