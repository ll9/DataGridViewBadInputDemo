﻿using DataGridError.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridError
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void someModelDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            someModelDataGridView[e.ColumnIndex, e.RowIndex].Value = string.Empty;
        }
    }
}
