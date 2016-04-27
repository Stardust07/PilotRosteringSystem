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

        private int numberOfPerPage = 7;
        private const String HEADER = " ";
        private DataTable sourceData;
        private int currentPage, pageCount, currentYear, weekOfFirstDay;
        private String instanceFile, lastRoster, unfinishedFile, unfinishedDate;
        private Hashtable colorTable, durationTable;
        private String[] durations = { "D1", "D2", "D3", "N1" };
        private Color[] colors = { Color.LightPink, Color.LightSalmon, Color.IndianRed, Color.SlateGray };
        private String[] weekDays = {"星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期日"};
        private ArrayList unfinishedList;
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

            instanceFile = "instance_1.txt";
            lastRoster = "roster.csv";
            unfinishedFile = "unfinished.txt";
            unfinishedDate = "";

            unfinishedList = new ArrayList();
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
            loadRoster(fileName);
        }
        private void loadRosterByPage(int currentPage)
        {
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
            dataGridView.DataSource = getDataByPage(currentPage);
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //dataGridView.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            adjustPage();
            dataGridView.ClearSelection();
            
        }
        private void loadRoster(String fileName)
        {
            sourceData = getData(fileName);
            int day = dateTimePicker.Value.DayOfYear;
            currentPage = (day + weekOfFirstDay - 2) / numberOfPerPage + 1;

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
        }
        private DataTable getData(String filePath)
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
                dataTable.Columns.Add(dataColumn);
                string[] tableHeader = strLine.Split(',');
                columnCount = tableHeader.Length - 1;
                currentYear = Convert.ToInt32(tableHeader[1].Substring(0, 4));
                GregorianCalendar gc = new GregorianCalendar();
                DateTime dt = gc.ToDateTime(currentYear, 1, 1, 0, 0, 0, 0);
                weekOfFirstDay = Convert.ToInt32(dt.DayOfWeek);

                for (int i = weekOfFirstDay - 2; i >= 0; i--)
                {
                    String header = (currentYear - 1).ToString() + "12" + (31 - i).ToString() + "\r\n" + weekDays[weekOfFirstDay - 2 - i];
                    dataColumn = new DataColumn(header);
                    dataTable.Columns.Add(dataColumn);
                }
                for (int i = 1; i <= columnCount; i++)
                {
                    dataColumn = new DataColumn(tableHeader[i] + "\r\n" + weekDays[(i + weekOfFirstDay - 2) % 7]);
                    dataTable.Columns.Add(dataColumn);
                }
            }
            else
            {
                return null;
            }
            while ((strLine = streamReader.ReadLine()) != null)
            {
                string[] contentStrings = strLine.Split(',');
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = contentStrings[0];
                for (int j = 1; j < columnCount; j++)
                {
                    dataRow[j + weekOfFirstDay - 1] = contentStrings[j];
                }
                dataTable.Rows.Add(dataRow);
            }

            streamReader.Close();
            fileStream.Close();
            pageCount = (dataTable.Columns.Count - 2) / numberOfPerPage + 1;
            return dataTable;
        }
        private DataTable getDataByPage(int pageIndex)
        {
            pageIndex--;
            DataTable desData = new DataTable();
            int columnsCount = sourceData.Columns.Count;
            desData.Columns.Add(new DataColumn(HEADER));
            for (int i = 0; i < numberOfPerPage && i + pageIndex * numberOfPerPage + 1 < columnsCount; i++)
            {
                DataColumn dataColumn = new DataColumn(sourceData.Columns[i + pageIndex * numberOfPerPage + 1].ColumnName);
                desData.Columns.Add(dataColumn);
            }
            //for (int i = 0; desData.Columns.Count <= numberOfPerPage; i++)
            //{
            //    DataColumn dataColumn = new DataColumn((currentYear + 1).ToString() + "010" + (1 + i).ToString());
            //    desData.Columns.Add(dataColumn);
            //}
            int rowsCount = sourceData.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                DataRow dataRow = desData.NewRow();
                dataRow[0] = sourceData.Rows[i][0].ToString();
                for (int j = 1; j <= numberOfPerPage && j + pageIndex * numberOfPerPage < columnsCount; j++)
                {
                    dataRow[j] = sourceData.Rows[i][j + pageIndex * numberOfPerPage].ToString();
                }
                desData.Rows.Add(dataRow);
            }

            return desData;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int futurePage = (dateTimePicker.Value.DayOfYear + weekOfFirstDay - 2) / numberOfPerPage + 1;
            if (currentPage == futurePage)
            {
                return;
            }
            currentPage = futurePage;
            loadRosterByPage(currentPage);
        }

        private void adjustCalendar()
        {
            String timeString = dataGridView.Columns[1].HeaderText.ToString();
            int year = Convert.ToInt32(timeString.Substring(0, 4));
            int month, day;
            if (year == currentYear)
            {
                month = Convert.ToInt32(timeString.Substring(4, 2));
                day = Convert.ToInt32(timeString.Substring(6, 2));
            }
            else if (year < currentYear)
            {
                year = currentYear;
                month = 1;
                day = 1;
            }
            else
            {
                year = currentYear;
                month = 12;
                day = 31;
            }
            dateTimePicker.Value = new DateTime(year, month, day, new GregorianCalendar());
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (reRosterBtn.Text == "排班")
        //    {
        //        createRosterAndLoad(false);
        //        reRosterBtn.Text = "重新排班";
        //    }
        //    else
        //    {
        //        writeUnfinished();
        //        createRosterAndLoad(true);
        //        撤销ToolStripMenuItem.Enabled = false;
        //    }
        //    reRosterBtn.Enabled = false;
        //}

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex > 0)
                {
                    if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals(""))
                    {
                        return;
                    }
                    if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == false)
                    {
                        dataGridView.ClearSelection();
                        dataGridView.CurrentCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        //dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                        
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
            dataGridView.ClearSelection();
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void 未完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int columnIndex = dataGridView.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView.CurrentCell.RowIndex;

            DataGridViewSelectedCellCollection selectedCells = dataGridView.SelectedCells;
            for (int i = 1; i < selectedCells.Count; i++)
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

        private bool updateUnfinishedList(String date, DataGridViewSelectedCellCollection cells)
        {

            if (unfinishedList.Count != 0 && String.Compare(unfinishedDate, date.Substring(0, 8)) != 0)
            {
                return false;
            }
            if (unfinishedList.Count == 0)
            {
                撤销ToolStripMenuItem.Enabled = true;
                调整计划ToolStripMenuItem.Enabled = true;
                unfinishedDate = date.Substring(0, 8);
            }
           
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
                unfinished += dataGridView.Rows[item.getRow()].Cells[0].Value + " ";
                unfinished += item.getSubject() + " ";
                unfinished += durationTable[item.getColor()] + "\r\n";
                streamWriter.Write(unfinished);
            }
            streamWriter.Close();
            fileStream.Close();
            unfinishedList.Clear();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (unfinishedList.Count == 0)
            {
                return;
            }
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
            }
        }

        private void dataGridView_SizeChanged(object sender, EventArgs e)
        {    
            if (numberOfPerPage == (dataGridView.Width - 1) / 100)
            {
               
                return;
            }
            numberOfPerPage = (dataGridView.Width - 1) / 100 > 0 ? (dataGridView.Width - 1) / 100 : 1;

            loadPageAfterResizing();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unfinishedList.Count == 0)
            {
                return;
            }
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

        private void 调整计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeUnfinished();
            createRosterAndLoad(true);
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
                loadRoster(lastRoster);
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
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(columnBox.Text) < 7)
                {
                    numberOfPerPage = 7;
                }
                else
                {
                    numberOfPerPage = Convert.ToInt32(columnBox.Text);
                }
                loadPageAfterResizing();
            }
        }
        private void loadPageAfterResizing()
        {
            columnBox.Text = numberOfPerPage.ToString();
            if (dataGridView.DataSource != null)
            {
                //pageCount = (sourceData.Columns.Count - 2) / numberOfPerPage + 1;
                //totalPage.Text = "共" + pageCount.ToString() + "页";
                //currentPage = (dateTimePicker.Value.DayOfYear + weekOfFirstDay - 2) / numberOfPerPage + 1;
                //loadRosterByPage(currentPage);
            }
        }
    }
}
