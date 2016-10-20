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
namespace PilotRosteringSystem
{
    public partial class Form1 : Form
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
        //[DllImport("PilotRosteringSolver.dll", EntryPoint = "run", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //public static extern void run(int argc, string argv);

        [DllImport("PilotRosteringSolver.dll", EntryPoint = "createRoster")]
        public static extern void createRoster(string instanceFilePath, string rosterFilePath, string unfinishedIemsFilePath, bool ifRecovery);

        private int numberOfPerPage = 30;
        private const String HEADER = " ";
        private DataTable sourceData;
        private int currentPage, pageCount, currentYear, weekOfFirstDay, currentOffset, userPage;
        private String instanceFile, lastRoster, unfinishedFile, unfinishedDate;
        private Hashtable colorTable, durationTable;
        private String[] durations = { "D1", "D2", "D3", "N1" };
        private Color[] colors = { Color.LightPink, Color.YellowGreen, Color.OrangeRed, Color.SlateGray };
        private String[] weekDays = { "周一", "周二", "周三", "周四", "周五", "周六", "周日" };
        private ArrayList unfinishedList;
        private ArrayList unfinishedActionList;

        private DateTime startDay, endDay;
        public Form1()
        {
            InitializeComponent();
            initialize();
        }
        private void initialize()
        {
            currentPage = 1;
            pageCount = 0;
            currentYear = 2016;
            weekOfFirstDay = 1;
            currentOffset = 0;
            userPage = 0;

            instanceFile = "instance_1.txt";
            lastRoster = "roster.csv";
            unfinishedFile = "unfinished.txt";
            unfinishedDate = "";

            unfinishedList = new ArrayList();
            unfinishedActionList = new ArrayList();
            colorTable = new Hashtable();
            durationTable = new Hashtable();
            columnBox.Text = numberOfPerPage.ToString();

            for (int i = 0; i < durations.Length; i++)
            {
                colorTable.Add(durations[i], colors[i]);
                durationTable.Add(colors[i], durations[i]);
            }

            
        }
        private void createRosterAndLoad(bool ifRecovery)
        {
            String fileName = "roster";
            createRoster(instanceFile, lastRoster, unfinishedFile, ifRecovery);
            if (ifRecovery)
            {
                fileName += unfinishedDate;
            }
            fileName += ".csv";
            lastRoster = fileName;
            loadRoster(fileName, !ifRecovery);
        }
        private void loadRosterByPage(int currentPage)
        {
            setNumberOfPerpage();
            dataGridView.DataSource = null;
            if (currentYear != dateTimePicker.Value.Year)
            {
                dataGridView.DataSource = new DataTable();
                tipLabel.Visible = true;
                pageContainer.Visible = false;
                return;
            }
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
            sourceData = readFromFile(fileName);
            if (isFirstLoad)
            {
                int day = dateTimePicker.Value.DayOfYear;
                int month = dateTimePicker.Value.Month;
                //currentPage = (day - currentOffset - 1) / numberOfPerPage + 1;
                currentPage = month - startDay.Month + 1;
            }
   
            loadRosterByPage(currentPage);
            pageContainer.Enabled = true;
            totalPage.Text = "共" + pageCount.ToString() + "页";
            
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
        private void readInstance()
        {

        }
        private DataTable readFromFile(String filePath)
        {
            DataTable dataTable = new DataTable();
            FileStream fileStream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.ASCII);
            string strLine = "";
            int columnCount = 0;
            //读取表头
            if ((strLine = streamReader.ReadLine()) != null)
            {
                DataColumn dataColumn = new DataColumn(HEADER);
                //dataTable.Columns.Add(dataColumn);
                string[] tableHeader = strLine.Split(',');
                int year, month, day;
                columnCount = tableHeader.Length - 1;
                year = Convert.ToInt32(tableHeader[2].Substring(0, 4));
                month = Convert.ToInt32(tableHeader[2].Substring(4, 2));
                day = Convert.ToInt32(tableHeader[2].Substring(6, 2));
                startDay = new DateTime(year, month, day);
                currentYear = year;
                GregorianCalendar gc = new GregorianCalendar();
                DateTime dt = gc.ToDateTime(currentYear, 1, 1, 0, 0, 0, 0);
                weekOfFirstDay = Convert.ToInt32(dt.DayOfWeek) == 0 ? 7 : Convert.ToInt32(dt.DayOfWeek);
                dataColumn = new DataColumn(tableHeader[0]);
                dataTable.Columns.Add(dataColumn);
                dataColumn = new DataColumn(tableHeader[1]);
                dataTable.Columns.Add(dataColumn);
                for (int i = 2; i <= columnCount; i++)
                {
                    //dataColumn = new DataColumn(tableHeader[i]);
                    dataColumn = new DataColumn(tableHeader[i].Substring(4, 4) + "\r\n" + weekDays[(i + weekOfFirstDay - 3) % 7]);
                    dataTable.Columns.Add(dataColumn);
                }
                year = Convert.ToInt32(tableHeader[columnCount].Substring(0, 4));
                month = Convert.ToInt32(tableHeader[columnCount].Substring(4, 2));
                day = Convert.ToInt32(tableHeader[columnCount].Substring(6, 2));
                endDay = new DateTime(year, month, day);
            }
            else
            {
                return null;
            }
            while ((strLine = streamReader.ReadLine()) != null)
            {
                string[] contentStrings = strLine.Split(',');
                DataRow dataRow = dataTable.NewRow();
                //dataRow[0] = contentStrings[0];
                for (int j = 0; j < columnCount; j++)
                {
                    dataRow[j] = contentStrings[j];
                }
                dataTable.Rows.Add(dataRow);
            }

            streamReader.Close();
            fileStream.Close();
            pageCount = endDay.Month - startDay.Month + 1;
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
            DateTime firstDay = new DateTime(currentYear, pageIndex + startDay.Month - 1, 1);
            int baseOffset;
            DataTable desData = new DataTable();
            int columnsCount = sourceData.Columns.Count;
            desData.Columns.Add(new DataColumn(HEADER));
            if(pageIndex != 1) {
                baseOffset = firstDay.DayOfYear - startDay.DayOfYear;
            } 
            else {
                baseOffset = 0;
            }
            for (int i = 0; i < numberOfPerPage && i + baseOffset + 1 < columnsCount; i++)
            {
                DataColumn dataColumn = new DataColumn(sourceData.Columns[i + baseOffset + 2].ColumnName);
                desData.Columns.Add(dataColumn);
            }

            int rowsCount = sourceData.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                DataRow dataRow = desData.NewRow();
                dataRow[0] = sourceData.Rows[i][1].ToString();
                for (int j = 1; j <= numberOfPerPage && j + baseOffset < columnsCount; j++)
                {
                    dataRow[j] = sourceData.Rows[i][j + baseOffset + 1].ToString();
                }
                desData.Rows.Add(dataRow);
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
                    cell.Style.BackColor = Color.White;
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
                    //dataGridView.Rows[item.getRow()].Cells[0].Value + " ";
                unfinished += item.getSubject() + " ";
                unfinished += durationTable[item.getColor()] + "\r\n";
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
            createRosterAndLoad(true);
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
                createRosterAndLoad(false);
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
        private void loadPageAfterResizing()
        {
            columnBox.Text = numberOfPerPage.ToString();
            if (dataGridView.DataSource != null)
            {
                if (currentYear != dateTimePicker.Value.Year)
                {
                    dataGridView.DataSource = new DataTable();
                    tipLabel.Visible = true;
                    pageContainer.Visible = false;
                    return;
                }
                pageContainer.Visible = true;
                tipLabel.Visible = false;
                if (currentPage != 1)
                {
                    String date = dataGridView.Columns[1].HeaderText.ToString().Substring(0, 8);
                    GregorianCalendar gc = new GregorianCalendar();
                    DateTime dt = gc.ToDateTime(currentYear, Convert.ToInt32(date.Substring(4, 2)), Convert.ToInt32(date.Substring(6, 2)), 0, 0, 0, 0);
                    int day = dt.DayOfYear;
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = getDataByDay(day);
                    currentPage = (day == 1) ? 1 : ((day - 2) / numberOfPerPage + 2);
                    pageCount = currentPage + ((DateTime.IsLeapYear(dt.Year) ? 366 : 365) - dt.DayOfYear) / numberOfPerPage;
                    currentOffset = (day == 1) ? 0 : (day - 1 - (currentPage - 1) * numberOfPerPage); 
                }
                else
                {
                    dataGridView.DataSource = null;
                    if (numberOfPerPage + currentOffset <= 0)
                    {
                        currentOffset = 0;
                    }
                    dataGridView.DataSource = getDataByDay(currentOffset + 1);
                    pageCount = (sourceData.Columns.Count - currentOffset) / numberOfPerPage + 1;
                }
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                
                adjustPage();
                dataGridView.ClearSelection();
            }
        }
        private void resize(int number)
        {
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.WindowState = FormWindowState.Normal;
            //}
                
            //this.Size = new Size(140 + 100 * number, this.Size.Height);
            return;
        }

        private void setNumberOfPerpage()
        {
            int curMonth = currentPage + startDay.Month - 1;
            if (currentPage == 1)
            {
                numberOfPerPage = DateTime.DaysInMonth(currentYear, curMonth) - startDay.Day + 1;
            }
            else if (currentPage == pageCount)
            {
                numberOfPerPage = endDay.Day;
            }
            else
            {
                numberOfPerPage = DateTime.DaysInMonth(currentYear, curMonth);
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
            createRosterAndLoad(false);
        }
    }
}
