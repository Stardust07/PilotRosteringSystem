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
        //[DllImport("PilotRosteringSolver.dll", EntryPoint = "run", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //public static extern void run(int argc, string argv);

        [DllImport("PilotRosteringSolver.dll", EntryPoint = "createRoster")]
        public static extern void createRoster(string instanceFilePath, string rosterFilePath, string unfinishedIemsFilePath, bool ifRecovery);

        private const int PER_PAGE = 7;
        private const String HEADER = " ";
        private DataTable sourceData;
        private int currentPage, pageCount, currentYear, weekOfFirstDay;
        private String instanceFile, lastRoster, unfinishedFile, unfinishedDate;
        private Hashtable colorTable, durationTable;
        private String[] durations = { "D1", "D2", "D3", "N1" };
        private Color[] colors = { Color.LightPink, Color.LightSalmon, Color.IndianRed, Color.SlateGray };

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

            colorTable = new Hashtable();
            durationTable = new Hashtable();

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
            currentPage = (day + weekOfFirstDay - 2) / 7 + 1;

            loadRosterByPage(currentPage);
            
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
            GregorianCalendar gc = new GregorianCalendar();
            DateTime dt;
            FileStream fileStream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.ASCII);
            string strLine = "";
            //记录每行记录中的各字段内容
            string[] aryLine = null;
            string[] tableHead = null;
            int columnCount = 0;
            //读取表头
            if ((strLine = streamReader.ReadLine()) != null)
            {
                DataColumn dataColumn = new DataColumn(HEADER);
                dataTable.Columns.Add(dataColumn);
                tableHead = strLine.Split(',');
                columnCount = tableHead.Length - 1;
                currentYear = Convert.ToInt32(tableHead[1].Substring(0, 4));
                dt = gc.ToDateTime(currentYear, 1, 1, 0, 0, 0, 0);
                weekOfFirstDay = Convert.ToInt32(dt.DayOfWeek);

                for (int i = weekOfFirstDay - 2; i >= 0; i--)
                {
                    dataColumn = new DataColumn((currentYear - 1).ToString() + "12" + (31 - i).ToString());
                    dataTable.Columns.Add(dataColumn);
                }
                for (int i = 1; i <= columnCount; i++)
                {
                    dataColumn = new DataColumn(tableHead[i]);
                    dataTable.Columns.Add(dataColumn);
                }
            }
            else
            {
                return null;
            }
            while ((strLine = streamReader.ReadLine()) != null)
            {
                aryLine = strLine.Split(',');
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = aryLine[0];
                for (int j = 1; j < columnCount; j++)
                {
                    dataRow[j + weekOfFirstDay - 1] = aryLine[j];
                }
                dataTable.Rows.Add(dataRow);
            }

            streamReader.Close();
            fileStream.Close();
            pageCount = (dataTable.Columns.Count - 2) / PER_PAGE + 1;
            return dataTable;
        }
        private DataTable getDataByPage(int pageIndex)
        {
            pageIndex--;
            DataTable desData = new DataTable();
            int columnsCount = sourceData.Columns.Count;
            desData.Columns.Add(new DataColumn(HEADER));
            for (int i = 0; i < PER_PAGE && i + pageIndex * 7 + 1 < columnsCount; i++)
            {
                DataColumn dataColumn = new DataColumn(sourceData.Columns[i + pageIndex * 7 + 1].ColumnName);
                desData.Columns.Add(dataColumn);
            }
            for (int i = 0; desData.Columns.Count <= PER_PAGE; i++)
            {
                DataColumn dataColumn = new DataColumn((currentYear + 1).ToString() + "010" + (1 + i).ToString());
                desData.Columns.Add(dataColumn);
            }
            int rowsCount = sourceData.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                DataRow dataRow = desData.NewRow();
                dataRow[0] = sourceData.Rows[i][0].ToString();
                for (int j = 1; j <= PER_PAGE && j + pageIndex * 7 < columnsCount; j++)
                {
                    dataRow[j] = sourceData.Rows[i][j + pageIndex * 7].ToString();
                }
                desData.Rows.Add(dataRow);
            }

            return desData;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int futurePage = (dateTimePicker.Value.DayOfYear + weekOfFirstDay - 2) / 7 + 1;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (reRosterBtn.Text == "排班")
            {
                createRosterAndLoad(false);
                reRosterBtn.Text = "重新排班";
            }
            else
            {
                createRosterAndLoad(true);
            }
            reRosterBtn.Enabled = false;
        }

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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
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
            writeUnfinished(dataGridView.Columns[columnIndex].HeaderText, selectedCells);
            foreach (DataGridViewCell cell in selectedCells)
            {
                cell.Value = "";
            }
            dataGridView.ClearSelection();
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            setCellBackColor();
        }

        private void writeUnfinished(String date, DataGridViewSelectedCellCollection cells)
        {
            FileStream fileStream = new FileStream(unfinishedFile, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);
            unfinishedDate = date;
            streamWriter.Write(date + " ");
            streamWriter.Write(cells.Count.ToString() + "\r\n");
            for (int i = 0; i < cells.Count; i++)
            {
                if (cells[i].Value != "")
                {
                    streamWriter.Write(dataGridView.Rows[cells[i].RowIndex].Cells[0].Value + " ");
                    streamWriter.Write(cells[i].Value + " ");
                    streamWriter.Write(durationTable[cells[i].Style.BackColor] + "\r\n");
                }
            }
            
            streamWriter.Close();
            fileStream.Close();
            reRosterBtn.Enabled = true;
            return;
        }

    }
}
