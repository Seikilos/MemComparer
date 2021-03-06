﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LISMemoryComparer
{
    public partial class Form1 : Form
    {
        public MemoryDumpDataSet.JoinedMemoryDumpTableDataTable Joined;

        public Form1()
        {
            InitializeComponent();

        
        }

        private void txtSecondDump_TextChanged(object sender, EventArgs e)
        {
            var msInterals = new List<string>
                {
                    "System.",
                    "MS.",
                    "<CppImplementation",
                    "Microsoft",
                    "__type_info_node",
                    "__DynamicallyInvokableAttribute",
                    "<CrtImplementationDetails",
                };
            Func<MemoryDumpDataSet.MemoryDumpTableRow, bool> filter = s =>
                {
                    // This is the early exist
                    if (cbHideSystem.Checked && msInterals.Any(i => s.ClassName.Contains(i)))
                    {
                        return false;
                    }
                    // Use filter, case insensitive
                    if (string.IsNullOrWhiteSpace(textBoxFilter.Text) == false && s.ClassName.IndexOf(textBoxFilter.Text, StringComparison.CurrentCultureIgnoreCase) == -1)
                    {
                        return false;
                    }
                    return true;
                };

            try
            {
                MemoryDumpDataSet.MemoryDumpTableDataTable FirstDump = MemoryComparerManager.ConvertMemoryDump("First", txtFirstDump.Lines,filter );
                MemoryDumpDataSet.MemoryDumpTableDataTable SecondDump = MemoryComparerManager.ConvertMemoryDump("Second", txtSecondDump.Lines, filter);

                Joined = MemoryComparerManager.Join(FirstDump, SecondDump);
                joinedMemoryDumpTableBindingSource.DataSource = Joined;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error occurred");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtFirstDump.Text = Clipboard.GetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtSecondDump.Text = Clipboard.GetText();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn col = dataGridView1.Columns[e.ColumnIndex];
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (col.Name.Equals("count2DataGridViewTextBoxColumn"))
            {
                long Count1 = long.Parse(row.Cells["count1DataGridViewTextBoxColumn"].Value.ToString()); //long.Parse(Joined.Rows[e.RowIndex][1].ToString());
                long Count2 = long.Parse(row.Cells["count2DataGridViewTextBoxColumn"].Value.ToString()); //long.Parse(Joined.Rows[e.RowIndex][5].ToString());

                if (Count2 > Count1)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if(Count1 == Count2)
                {
                    e.CellStyle.BackColor = Color.DarkGray;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Green;
                }
            }
            //e.CellStyle.BackColor
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            // Cause invalidation and re-compare
            txtSecondDump_TextChanged(null, EventArgs.Empty);
        }

        private void cbHideSystem_CheckedChanged(object sender, EventArgs e)
        {
            // Cause invalidation and re-compare
            txtSecondDump_TextChanged(null, EventArgs.Empty);
        }
    }
}
