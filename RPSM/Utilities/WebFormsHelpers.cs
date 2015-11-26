using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RPSM.Utilities
{
    public class WebFormsHelpers
    {
        internal void CopyAll(DataGridView from, DataGridView to)
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

        internal void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        internal void Input_data_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckKey(sender, e);
        }

        internal void Input_data_CellValidating(object sender, DataGridViewCellValidatingEventArgs e, DataGridView Input_data)
        {
            string headerText =
            Input_data.Columns[e.ColumnIndex].HeaderText;

            string[] validationColumns = { "i", "j", "t(i-j)" };
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
    }
}
