﻿using AgroApp.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroApp.Forms
{
    public partial class FormAddStorage : Form
    {
        int farmId;
        DBOperator dboperator = new DBOperator();
        public FormAddStorage(int farmId)
        {
            InitializeComponent();
            this.farmId= farmId;
        }

        private void addStorage() 
        {
            if (textBox1.Text == String.Empty)
            { 
                this.Close();
            }
            else
            {
                InsertQuery queryStorage = new InsertQuery("Storages", "name,farm", "'" + textBox1.Text + "'," + farmId);
                if (dboperator.insert(queryStorage) != 0)
                {
                    MessageBox.Show("Dodano pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Zakończono dodawanie gospodarstwa", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            addStorage();
        }
    }
}
