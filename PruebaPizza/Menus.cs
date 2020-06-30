﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPizza
{
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LinqCajero _tablaCajeros = new LinqCajero();
            var cajeros = from cajero in _tablaCajeros.Cajero select cajero;
            _gvCajeros.DataSource = cajeros;
        }
    }
}
