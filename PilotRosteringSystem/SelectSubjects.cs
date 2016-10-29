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
        public SelectSubjects(DataGridView subjectTable, DataGridView pilotTable)
        {
            this.subjectTable = subjectTable;
            this.pilotTable = pilotTable;
            if (pilotTable != null && pilotTable.SelectedRows[0].Cells[3].Value != null)
            {
                
                cellContent = pilotTable.SelectedRows[0].Cells[3].Value.ToString();
            }
            else if (subjectTable != null && subjectTable.SelectedRows[0].Cells[6].Value != null)
            {
                cellContent = subjectTable.SelectedRows[0].Cells[6].Value.ToString();
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
                if (cellContent.Contains(row.Cells[0].Value.ToString()))
                {
                    checkedListBox.SetItemChecked(i, true); 
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";

            if (checkedListBox.CheckedItems.Count <= 0)
            {
                ;
            }
            else
            {
                for (int i = 0; i < checkedListBox.CheckedItems.Count - 1; i++)
                {
                    str += checkedListBox.CheckedItems[i].ToString() + " ";
                }
                str += checkedListBox.CheckedItems[checkedListBox.CheckedItems.Count - 1].ToString();
            }
            
            if (pilotTable == null)
            {
                if (subjectTable.SelectedRows.Count == 0)
                {
                    int rowIndex = subjectTable.SelectedCells[0].RowIndex;
                    subjectTable.Rows[rowIndex].Cells[5].Value = checkedListBox.CheckedItems.Count;
                    subjectTable.Rows[rowIndex].Cells[6].Value = str;
                }
                else
                {
                    subjectTable.SelectedRows[0].Cells[5].Value = checkedListBox.CheckedItems.Count;
                    subjectTable.SelectedRows[0].Cells[6].Value = str;
                }    
            }
            else
            {
                if (pilotTable.SelectedRows.Count == 0)
                {
                    int rowIndex = pilotTable.SelectedCells[0].RowIndex;
                    pilotTable.Rows[rowIndex].Cells[2].Value = checkedListBox.CheckedItems.Count;
                    pilotTable.Rows[rowIndex].Cells[3].Value = str;
                }
                else
                {
                    pilotTable.SelectedRows[0].Cells[2].Value = checkedListBox.CheckedItems.Count;
                    pilotTable.SelectedRows[0].Cells[3].Value = str;
                }    
            }
            this.Close();
        }
   
    }
  
}
