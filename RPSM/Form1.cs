﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RPSM.Utilities;
using WebFormsHelpers =  RPSM.Utilities.WebFormsHelpers;

namespace RPSM
{
    public partial class Form1 : Form
    {
        internal Utils Utils { get; set; }
        public Form1()
        {
            InitializeComponent();
            Utils = new Utils
            {
                WebFormsHelpers = new WebFormsHelpers()
            };
        }

        private void Input_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Input_data.Rows[Input_data.Rows.Count - 2].Cells[0].Value = e.RowIndex;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Utils.WebFormsHelpers.CopyAll(Input_data, CalculateGrid);
            CalculateH_I(Input_data, CalculateGrid);
            CalculateJ_K(Input_data, CalculateGrid);
            CalculateES_I_J(Input_data, CalculateGrid);
            CalculateEF_I_J(Input_data, CalculateGrid);
            CalculateLF_I_J(Input_data, CalculateGrid);
            CalculateLS_I_J(Input_data, CalculateGrid);
            CalculateR_I_J(Input_data, CalculateGrid);
            Calculate_Krutuchnui_Shljah(Input_data, CalculateGrid);
        }

        #region Calculations
        
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

        private void CalculateES_I_J(DataGridView gridView, DataGridView to)
        {
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                if (dgvr.Cells.Count <= 1 || dgvr.Cells[1].Value == null) continue;
                string iValue = dgvr.Cells[1].Value.ToString();

                List<decimal> valueList = new List<decimal> { 0 };
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

        private decimal EF_MAX;

        private void CalculateEF_I_J(DataGridView gridView, DataGridView to)
        {
            var maxArray = new List<decimal>();
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                to.Rows[dgvr.Index].Cells[8].Value = Utils.ConvertToDecimal(to.Rows[dgvr.Index].Cells[3].Value) +
                                                     Utils.ConvertToDecimal(to.Rows[dgvr.Index].Cells[7].Value);
                maxArray.Add(Utils.ConvertToDecimal(to.Rows[dgvr.Index].Cells[8].Value));
            }
            EF_MAX = maxArray.Max();
        }

        private void CalculateLF_I_J(DataGridView gridView, DataGridView to)
        {
            int rowsCount = 0;
            if (gridView.RowCount > 2 && Utils.ConvertToDecimal(to.Rows[gridView.RowCount - 2].Cells[1].Value) > 0)
            {
                to.Rows[gridView.RowCount - 2].Cells[10].Value = EF_MAX;
                rowsCount = gridView.RowCount - 2;
            }
            else
            {
                to.Rows[gridView.RowCount - 1].Cells[10].Value = EF_MAX;
                rowsCount = gridView.RowCount - 1;
            }
            for (int index = rowsCount - 1; index >= 0; index--)
            {
                List<decimal> list = new List<decimal>();

                string jValue = to.Rows[index].Cells[2].Value.ToString();

                foreach (DataGridViewRow innerDgvr in to.Rows)
                {
                    if (innerDgvr.Cells.Count <= 1 || innerDgvr.Cells[1].Value == null) continue;
                    string iValue = innerDgvr.Cells[1].Value.ToString();
                    if (iValue == jValue)
                    {
                        list.Add(Utils.ConvertToDecimal(innerDgvr.Cells[10].Value) -
                                 Utils.ConvertToDecimal(innerDgvr.Cells[3].Value));
                    }
                }

                to.Rows[index].Cells[10].Value = list.Any() ? list.Min() : EF_MAX;

            }
        }

        private void CalculateLS_I_J(DataGridView gridView, DataGridView to)
        {
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                to.Rows[dgvr.Index].Cells[9].Value = Utils.ConvertToDecimal(to.Rows[dgvr.Index].Cells[10].Value) -
                                                     Utils.ConvertToDecimal(to.Rows[dgvr.Index].Cells[3].Value);
            }
        }

        private void CalculateR_I_J(DataGridView gridView, DataGridView to)
        {
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                to.Rows[dgvr.Index].Cells[11].Value = Utils.ConvertToDecimal(to.Rows[dgvr.Index].Cells[9].Value) -
                                                     Utils.ConvertToDecimal(to.Rows[dgvr.Index].Cells[7].Value);
            }
        }

        private void Calculate_Krutuchnui_Shljah(DataGridView gridView, DataGridView to)
        {
            foreach (DataGridViewRow dgvr in gridView.Rows)
            {
                if (Utils.ConvertToDecimal(to.Rows[dgvr.Index].Cells[11].Value) == 0)
                {
                    Critical.Text += to.Rows[dgvr.Index].Cells[4].Value + @"; ";
                }
            }
        }

        #endregion
    }
}
