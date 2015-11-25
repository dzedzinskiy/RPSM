using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Input_data.Rows[Input_data.Rows.Count - 2].Cells[0].Value = e.RowIndex;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CopyAll(Input_data, CalculateGrid);
            CalculateH_I(Input_data, CalculateGrid);
            CalculateJ_K(Input_data, CalculateGrid);
            CalculateES_I_J(Input_data, CalculateGrid);
            CalculateEF_I_J(Input_data, CalculateGrid);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void CalculateH_I(DataGridView gridView, DataGridView to)
        {
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                if (dgvr.Cells.Count <= 1 || dgvr.Cells[1].Value == null) continue;

                string iValue = dgvr.Cells[1].Value.ToString();
                foreach (DataGridViewRow innerDgvr in gridView.Rows)
                {
                    if (innerDgvr.Cells.Count <= 2 || innerDgvr.Cells[2].Value == null) continue;
                    string jValue = innerDgvr.Cells[2].Value.ToString();
                    if (iValue == jValue)
                    {
                        to.Rows[dgvr.Index].Cells[5].Value += innerDgvr.Cells[0].Value.ToString() + ";";
                    }
                }
            }
        }

        private void CalculateJ_K(DataGridView gridView, DataGridView to)
        {
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                if (dgvr.Cells.Count <= 2 || dgvr.Cells[2].Value == null) continue;
                string jValue = dgvr.Cells[2].Value.ToString();
                
                foreach (DataGridViewRow innerDgvr in gridView.Rows)
                {
                    if (innerDgvr.Cells.Count <= 1 || innerDgvr.Cells[1].Value == null) continue;
                    string iValue = innerDgvr.Cells[1].Value.ToString();
                    if (iValue == jValue)
                    {
                        to.Rows[dgvr.Index].Cells[6].Value += innerDgvr.Cells[0].Value.ToString() + ";";
                    }
                }
            }
        }

        private void CalculateEF_I_J(DataGridView gridView, DataGridView to)
        {
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                to.Rows[dgvr.Index].Cells[8].Value = ConvertToDecimal(to.Rows[dgvr.Index].Cells[3].Value) +
                                                     ConvertToDecimal(to.Rows[dgvr.Index].Cells[7].Value);
            }
        }

        private static decimal ConvertToDecimal(object value)
        {
            if (value == null) return 0;

            return Convert.ToDecimal(value);
        }

        private void CalculateES_I_J(DataGridView gridView, DataGridView to)
        {
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                if (dgvr.Cells.Count <= 1 || dgvr.Cells[1].Value == null) continue;
                string iValue = dgvr.Cells[1].Value.ToString();

                List<decimal> valueList = new List<decimal>{0};
                foreach (DataGridViewRow innerDgvr in gridView.Rows)
                {
                    if (innerDgvr.Cells.Count <= 2 || innerDgvr.Cells[2].Value == null) continue;
                    string jValue = innerDgvr.Cells[2].Value.ToString();
                    if (iValue == jValue)
                    {
                        while (true)
                        {
                            if (to.Rows.Count < dgvr.Index)
                                to.Rows.Add();
                            else
                                break;
                        }
                        string val1 = to.Rows[innerDgvr.Index].Cells[3].Value != null ? to.Rows[innerDgvr.Index].Cells[3].Value.ToString() : "0";
                        string val2 = to.Rows[innerDgvr.Index].Cells[7].Value != null ? to.Rows[innerDgvr.Index].Cells[7].Value.ToString() : "0";
                        decimal value = Convert.ToDecimal(val1.Replace(";", "")) +
                                         Convert.ToDecimal(val2.Replace(";", ""));
                        valueList.Add(value);
                    }
                }
                decimal max = valueList.Max();
                to.Rows[dgvr.Index].Cells[7].Value = max;
            }
        }

        private void CopyAll(DataGridView from, DataGridView to)
        {
            if (to.Columns.Count == 0)
            {
                foreach (DataGridViewColumn dgvc in from.Columns)
                {
                    to.Columns.Add(dgvc.Name, dgvc.HeaderText);
                }
            }

            to.Rows.Clear();

            foreach (DataGridViewRow dgvr in from.Rows)
            {
                List<string> cells = new List<string>();

                foreach (DataGridViewCell dgvc in dgvr.Cells)
                {
                    if (dgvc.Value != null)
                    {
                        cells.Add(dgvc.Value.ToString());    
                    }
                }

                //fill in data for "i-j" column
                if (cells.Any() && !String.IsNullOrWhiteSpace(cells[0]) && !String.IsNullOrWhiteSpace(cells[1]))
                {
                    cells.Add(cells[1] + "-" + cells[2]);
                }

                to.Rows.Add(cells.ToArray());
            }
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Input_data_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckKey(sender, e);
        }

        private void Input_data_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
            Input_data.Columns[e.ColumnIndex].HeaderText;

            string[] validationColumns = {"i", "j", "t(i-j)"};
            // Abort validation if cell is not in the CompanyName column.
            if (!validationColumns.Contains(headerText)) return;

            foreach (char c in e.FormattedValue.ToString())
            {
                if (!char.IsControl(c)
                && !char.IsDigit(c)
                && c != '.')
                {
                    e.Cancel = true;
                }
            }
        }

        private void CalculationParameters_Click(object sender, EventArgs e)
        {

        }
    }
}
