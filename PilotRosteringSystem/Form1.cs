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

namespace PilotRosteringSystem
{
    public partial class Form1 : Form
    {
        //[DllImport("PilotRosteringSolver.dll", EntryPoint = "run", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //public static extern void run(int argc, string argv);

        [DllImport("PilotRosteringSolver.dll", EntryPoint = "createRoster")]
        public static extern void createRoster(string instanceFilePath, string rosterFilePath, string unfinishedIemsFilePath, bool ifRecovery);

        private const int PER_PAGE = 7;
        private const String HEADER = "  ";
        private DataTable sourceData;
        private int currentPage = 1;
        private int year;
        private int pageCount = 0;
        public Form1()
        {
            InitializeComponent();
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            createRosterAndLoad(false);
        }
        private void createRosterAndLoad(bool ifRecovery)
        {
            String fileName = "roster";
            createRoster("instance_1.txt", "roster.csv", "unfinished.txt", ifRecovery);
            if (ifRecovery)
            {
                fileName += "20150101";
            }
            fileName += ".csv";
            loadRoster(fileName);
        }
        private void loadRoster(String fileName)
        {
            sourceData = getData(fileName);
            int day = dateTimePicker.Value.DayOfYear;
            currentPage = (day - 1) / 7 + 1;
            dataGridView.DataSource = getDataByPage(currentPage);

            //dataGridView.Rows[0].Cells[0].Selected = false;
            //int rowCount = dataGridView.Rows.Count;
            //int currentIndex = day - (currentPage - 1) * 7 - 1;
            //for (int i = 0; i < rowCount; i++)
            //{
            //    dataGridView.Rows[i].Cells[currentIndex].Selected = true;
            //}

            label1.Text = "共" + pageCount.ToString() + "页";
            setPage();
        }
        private void setPage()
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
            int spareDay;
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
                year = Convert.ToInt32(tableHead[1].Substring(0, 4));
                dt = gc.ToDateTime(year, 1, 1, 0, 0, 0, 0);
                spareDay = Convert.ToInt32(dt.DayOfWeek) - 1;

                for (int i = spareDay - 1; i >= 0 ; i--)
                {
                    dataColumn = new DataColumn((year - 1).ToString() + "12" + (31 - i).ToString());
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
                    dataRow[j + spareDay] = aryLine[j];
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
            for (int i = 0; i + desData.Columns.Count <= PER_PAGE; i++)
            {
                DataColumn dataColumn = new DataColumn((year + 1).ToString() + "010" + (1 + i).ToString());
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
            int futurePage = (dateTimePicker.Value.DayOfYear - 1) / 7 + 1;
            if (currentPage == futurePage)
            {
                return;
            }
            currentPage = futurePage;
            dataGridView.DataSource = getDataByPage(currentPage);
            setPage();
        }


        private void previousButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getDataByPage(--currentPage);
            setPage();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getDataByPage(++currentPage);
            setPage();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createRosterAndLoad(true);
        }

    }
}
