﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marshall_Banks_Inventory_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void AddPartButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new AddPartForm().Show();
            
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ModifyPartForm().Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProductForm().Show(); 
        }

        private void ModifyProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ModifyProductForm().Show();
        }
    }
}
