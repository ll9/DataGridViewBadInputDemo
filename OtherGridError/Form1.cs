using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtherGridError
{
    public partial class Form1 : Form
    {
        private DataTable Table;

        public Form1()
        {
            InitializeComponent();

            Table = new DataTable();
            Table.Columns.Add(new DataColumn("text", typeof(string)));
            Table.Columns.Add(new DataColumn("int", typeof(int)));
            Table.Columns.Add(new DataColumn("double", typeof(double)));
            Table.Columns.Add(new DataColumn("date", typeof(DateTime)));

            dataGridView1.DataSource = Table;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Table.Rows[e.RowIndex][e.ColumnIndex] = DBNull.Value;
            e.Cancel = false;
        }
    }
}
