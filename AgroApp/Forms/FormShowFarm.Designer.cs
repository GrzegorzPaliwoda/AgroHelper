﻿namespace AgroApp.Forms
{
    partial class FormShowFarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewJournal = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notatkęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewGarages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewStorages = new System.Windows.Forms.DataGridView();
            this.idStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewFields = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGarages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorages)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 607);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewJournal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(407, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(470, 444);
            this.panel5.TabIndex = 2;
            // 
            // dataGridViewJournal
            // 
            this.dataGridViewJournal.AllowUserToAddRows = false;
            this.dataGridViewJournal.AllowUserToDeleteRows = false;
            this.dataGridViewJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.identifier,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridViewJournal.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJournal.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewJournal.Name = "dataGridViewJournal";
            this.dataGridViewJournal.ReadOnly = true;
            this.dataGridViewJournal.RowHeadersVisible = false;
            this.dataGridViewJournal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJournal.Size = new System.Drawing.Size(470, 444);
            this.dataGridViewJournal.TabIndex = 0;
            this.dataGridViewJournal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewJournal_MouseClick);
            this.dataGridViewJournal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewJournal_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pracęToolStripMenuItem,
            this.notatkęToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // pracęToolStripMenuItem
            // 
            this.pracęToolStripMenuItem.Name = "pracęToolStripMenuItem";
            this.pracęToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pracęToolStripMenuItem.Text = "Pracę";
            this.pracęToolStripMenuItem.Click += new System.EventHandler(this.pracęToolStripMenuItem_Click);
            // 
            // notatkęToolStripMenuItem
            // 
            this.notatkęToolStripMenuItem.Name = "notatkęToolStripMenuItem";
            this.notatkęToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.notatkęToolStripMenuItem.Text = "Notatkę";
            this.notatkęToolStripMenuItem.Click += new System.EventHandler(this.notatkęToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewGarages);
            this.panel3.Controls.Add(this.dataGridViewStorages);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(407, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 114);
            this.panel3.TabIndex = 1;
            // 
            // dataGridViewGarages
            // 
            this.dataGridViewGarages.AllowUserToAddRows = false;
            this.dataGridViewGarages.AllowUserToDeleteRows = false;
            this.dataGridViewGarages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGarages.ColumnHeadersVisible = false;
            this.dataGridViewGarages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewGarages.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewGarages.Location = new System.Drawing.Point(236, 0);
            this.dataGridViewGarages.Name = "dataGridViewGarages";
            this.dataGridViewGarages.ReadOnly = true;
            this.dataGridViewGarages.RowHeadersVisible = false;
            this.dataGridViewGarages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGarages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGarages.Size = new System.Drawing.Size(234, 114);
            this.dataGridViewGarages.TabIndex = 1;
            this.dataGridViewGarages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGarages_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewStorages
            // 
            this.dataGridViewStorages.AllowUserToAddRows = false;
            this.dataGridViewStorages.AllowUserToDeleteRows = false;
            this.dataGridViewStorages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorages.ColumnHeadersVisible = false;
            this.dataGridViewStorages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStorage,
            this.nameStorage});
            this.dataGridViewStorages.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewStorages.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStorages.Name = "dataGridViewStorages";
            this.dataGridViewStorages.ReadOnly = true;
            this.dataGridViewStorages.RowHeadersVisible = false;
            this.dataGridViewStorages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStorages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStorages.Size = new System.Drawing.Size(232, 114);
            this.dataGridViewStorages.TabIndex = 0;
            this.dataGridViewStorages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStorages_CellDoubleClick);
            // 
            // idStorage
            // 
            this.idStorage.HeaderText = "Column1";
            this.idStorage.Name = "idStorage";
            this.idStorage.ReadOnly = true;
            this.idStorage.Visible = false;
            // 
            // nameStorage
            // 
            this.nameStorage.HeaderText = "Column1";
            this.nameStorage.Name = "nameStorage";
            this.nameStorage.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dataGridViewFields);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 607);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonDelete);
            this.panel4.Controls.Add(this.buttonAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 493);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 114);
            this.panel4.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDelete.Location = new System.Drawing.Point(0, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(407, 57);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "USUŃ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdd.Location = new System.Drawing.Point(0, 57);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(407, 57);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "DODAJ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewFields
            // 
            this.dataGridViewFields.AllowUserToAddRows = false;
            this.dataGridViewFields.AllowUserToDeleteRows = false;
            this.dataGridViewFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFields.ColumnHeadersVisible = false;
            this.dataGridViewFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.ColumnDescription,
            this.Plant});
            this.dataGridViewFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFields.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFields.Name = "dataGridViewFields";
            this.dataGridViewFields.ReadOnly = true;
            this.dataGridViewFields.RowHeadersVisible = false;
            this.dataGridViewFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFields.Size = new System.Drawing.Size(407, 493);
            this.dataGridViewFields.TabIndex = 0;
            this.dataGridViewFields.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Column1";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // Plant
            // 
            this.Plant.HeaderText = "Plant";
            this.Plant.Name = "Plant";
            this.Plant.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "start_date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "finish_date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "field";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "id";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // identifier
            // 
            this.identifier.HeaderText = "identifier";
            this.identifier.Name = "identifier";
            this.identifier.ReadOnly = true;
            this.identifier.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "name";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "start";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "finish";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "field";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // FormShowFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 607);
            this.Controls.Add(this.panel1);
            this.Name = "FormShowFarm";
            this.Text = "FormShowFarm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGarages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorages)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewFields;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plant;
        private System.Windows.Forms.DataGridView dataGridViewGarages;
        private System.Windows.Forms.DataGridView dataGridViewStorages;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView dataGridViewJournal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notatkęToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}