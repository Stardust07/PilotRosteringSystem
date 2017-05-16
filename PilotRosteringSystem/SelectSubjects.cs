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
    
    public partial class SelectSubjects : Form
    {
        private DataGridView subjectTable, pilotTable;
        private String cellContent;
        private int selectedRow;
        public SelectSubjects(DataGridView subjectTable, DataGridView pilotTable)
        {
            this.subjectTable = subjectTable;
            this.pilotTable = pilotTable;
            if (pilotTable == null)
            {
                if (subjectTable.SelectedRows.Count == 0)
                {
                    this.selectedRow = subjectTable.SelectedCells[0].RowIndex;
                }
                else
                {
                    this.selectedRow = subjectTable.SelectedRows[0].Index;
                }
            }
            else
            {
                if (pilotTable.SelectedRows.Count == 0)
                {
                    this.selectedRow = pilotTable.SelectedCells[0].RowIndex;
                }
                else
                {
                    this.selectedRow = pilotTable.SelectedRows[0].Index;
                }
            }
            if (pilotTable != null && pilotTable.Rows[selectedRow].Cells[3].Value != null)
            {

                cellContent = pilotTable.Rows[selectedRow].Cells[3].Value.ToString();
            }
            else if (subjectTable != null && subjectTable.Rows[selectedRow].Cells[6].Value != null)
            {
                cellContent = subjectTable.Rows[selectedRow].Cells[6].Value.ToString();
            }
            else
            {
                cellContent = "";
            }
            InitializeComponent();
            
            for (int i = 0; i < subjectTable.RowCount - 1; i++)
            {
                DataGridViewRow row = subjectTable.Rows[i];
                checkedListBox.Items.Add(row.Cells[0].Value.ToString());

                DataGridViewRow newRow = new DataGridViewRow();
                DataGridViewCheckBoxCell checkboxCell = new DataGridViewCheckBoxCell();
                checkboxCell.Value = false;
                if (cellContent.Contains(row.Cells[0].Value.ToString()))
                {
                    checkedListBox.SetItemChecked(i, true);
                    checkboxCell.Value = true;
                }
                newRow.Cells.Add(checkboxCell);
                DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
                textCell.Value = row.Cells[0].Value;
                newRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                newRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                newRow.Cells.Add(textCell);
                subjectGrid.Rows.Add(newRow);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            int checkedCount = 0;

            for (int i = 0; i < subjectGrid.Rows.Count - 1; i++)
            {
                DataGridViewRow dataRow = subjectGrid.Rows[i];
                if (dataRow.Cells[0].Value.Equals(true))
                {
                    checkedCount++;
                    str += dataRow.Cells[1].Value.ToString() + " ";
                }
            }
            if (subjectGrid.Rows[subjectGrid.Rows.Count - 1].Cells[0].Value.Equals(true))
            {
                checkedCount++;
                str += subjectGrid.Rows[subjectGrid.Rows.Count - 1].Cells[1].Value.ToString();
            }

            //if (checkedListBox.CheckedItems.Count <= 0)
            //{
            //    ;
            //}
            //else
            //{
            //    for (int i = 0; i < checkedListBox.CheckedItems.Count - 1; i++)
            //    {
            //        str += checkedListBox.CheckedItems[i].ToString() + " ";
            //    }
            //    str += checkedListBox.CheckedItems[checkedListBox.CheckedItems.Count - 1].ToString();
            //}
            
            if (pilotTable == null)
            {
                subjectTable.Rows[selectedRow].Cells[5].Value = checkedCount;
                subjectTable.Rows[selectedRow].Cells[6].Value = str;
            }
            else
            {
                pilotTable.Rows[selectedRow].Cells[2].Value = checkedCount;
                pilotTable.Rows[selectedRow].Cells[3].Value = str;  
            }
            this.Close();
        }
   
    }
  
}
