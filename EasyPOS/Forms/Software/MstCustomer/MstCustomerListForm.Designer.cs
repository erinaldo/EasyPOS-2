﻿namespace EasyPOS.Forms.Software.MstCustomer
{
    partial class MstCustomerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MstCustomerListForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCustomerListPageListFirst = new System.Windows.Forms.Button();
            this.buttonCustomerListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonCustomerListPageListNext = new System.Windows.Forms.Button();
            this.buttonCustomerListPageListLast = new System.Windows.Forms.Button();
            this.textBoxCustomerListPageNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomerList = new System.Windows.Forms.DataGridView();
            this.ColumnCustomerListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnCustomerListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnCustomerListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerListCustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerListCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerListContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerListAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerListIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBoxCustomerListFilter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 50);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Customer;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer List";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1016, 10);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 32);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(941, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 32);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridViewCustomerList);
            this.panel2.Controls.Add(this.textBoxCustomerListFilter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 510);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buttonCustomerListPageListFirst);
            this.panel3.Controls.Add(this.buttonCustomerListPageListPrevious);
            this.panel3.Controls.Add(this.buttonCustomerListPageListNext);
            this.panel3.Controls.Add(this.buttonCustomerListPageListLast);
            this.panel3.Controls.Add(this.textBoxCustomerListPageNumber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 468);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 42);
            this.panel3.TabIndex = 21;
            // 
            // buttonCustomerListPageListFirst
            // 
            this.buttonCustomerListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustomerListPageListFirst.Enabled = false;
            this.buttonCustomerListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonCustomerListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCustomerListPageListFirst.Location = new System.Drawing.Point(10, 9);
            this.buttonCustomerListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCustomerListPageListFirst.Name = "buttonCustomerListPageListFirst";
            this.buttonCustomerListPageListFirst.Size = new System.Drawing.Size(66, 26);
            this.buttonCustomerListPageListFirst.TabIndex = 13;
            this.buttonCustomerListPageListFirst.TabStop = false;
            this.buttonCustomerListPageListFirst.Text = "First";
            this.buttonCustomerListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonCustomerListPageListFirst.Click += new System.EventHandler(this.buttonCustomerListPageListFirst_Click);
            // 
            // buttonCustomerListPageListPrevious
            // 
            this.buttonCustomerListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustomerListPageListPrevious.Enabled = false;
            this.buttonCustomerListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonCustomerListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCustomerListPageListPrevious.Location = new System.Drawing.Point(80, 9);
            this.buttonCustomerListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCustomerListPageListPrevious.Name = "buttonCustomerListPageListPrevious";
            this.buttonCustomerListPageListPrevious.Size = new System.Drawing.Size(66, 26);
            this.buttonCustomerListPageListPrevious.TabIndex = 14;
            this.buttonCustomerListPageListPrevious.TabStop = false;
            this.buttonCustomerListPageListPrevious.Text = "Previous";
            this.buttonCustomerListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonCustomerListPageListPrevious.Click += new System.EventHandler(this.buttonCustomerListPageListPrevious_Click);
            // 
            // buttonCustomerListPageListNext
            // 
            this.buttonCustomerListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustomerListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonCustomerListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCustomerListPageListNext.Location = new System.Drawing.Point(210, 9);
            this.buttonCustomerListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCustomerListPageListNext.Name = "buttonCustomerListPageListNext";
            this.buttonCustomerListPageListNext.Size = new System.Drawing.Size(66, 26);
            this.buttonCustomerListPageListNext.TabIndex = 15;
            this.buttonCustomerListPageListNext.TabStop = false;
            this.buttonCustomerListPageListNext.Text = "Next";
            this.buttonCustomerListPageListNext.UseVisualStyleBackColor = false;
            this.buttonCustomerListPageListNext.Click += new System.EventHandler(this.buttonCustomerListPageListNext_Click);
            // 
            // buttonCustomerListPageListLast
            // 
            this.buttonCustomerListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustomerListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonCustomerListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCustomerListPageListLast.Location = new System.Drawing.Point(278, 9);
            this.buttonCustomerListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCustomerListPageListLast.Name = "buttonCustomerListPageListLast";
            this.buttonCustomerListPageListLast.Size = new System.Drawing.Size(66, 26);
            this.buttonCustomerListPageListLast.TabIndex = 16;
            this.buttonCustomerListPageListLast.TabStop = false;
            this.buttonCustomerListPageListLast.Text = "Last";
            this.buttonCustomerListPageListLast.UseVisualStyleBackColor = false;
            this.buttonCustomerListPageListLast.Click += new System.EventHandler(this.buttonCustomerListPageListLast_Click);
            // 
            // textBoxCustomerListPageNumber
            // 
            this.textBoxCustomerListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCustomerListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxCustomerListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomerListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxCustomerListPageNumber.Location = new System.Drawing.Point(150, 13);
            this.textBoxCustomerListPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerListPageNumber.Name = "textBoxCustomerListPageNumber";
            this.textBoxCustomerListPageNumber.ReadOnly = true;
            this.textBoxCustomerListPageNumber.Size = new System.Drawing.Size(55, 16);
            this.textBoxCustomerListPageNumber.TabIndex = 17;
            this.textBoxCustomerListPageNumber.TabStop = false;
            this.textBoxCustomerListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewCustomerList
            // 
            this.dataGridViewCustomerList.AllowUserToAddRows = false;
            this.dataGridViewCustomerList.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerList.AllowUserToResizeRows = false;
            this.dataGridViewCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCustomerListButtonEdit,
            this.ColumnCustomerListButtonDelete,
            this.ColumnCustomerListId,
            this.ColumnCustomerListCustomerCode,
            this.ColumnCustomerListCustomer,
            this.ColumnCustomerListContactNumber,
            this.ColumnCustomerListAddress,
            this.ColumnCustomerListIsLocked});
            this.dataGridViewCustomerList.Location = new System.Drawing.Point(10, 34);
            this.dataGridViewCustomerList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomerList.MultiSelect = false;
            this.dataGridViewCustomerList.Name = "dataGridViewCustomerList";
            this.dataGridViewCustomerList.ReadOnly = true;
            this.dataGridViewCustomerList.RowTemplate.Height = 24;
            this.dataGridViewCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomerList.Size = new System.Drawing.Size(1077, 429);
            this.dataGridViewCustomerList.TabIndex = 20;
            this.dataGridViewCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerList_CellClick);
            // 
            // ColumnCustomerListButtonEdit
            // 
            this.ColumnCustomerListButtonEdit.DataPropertyName = "ColumnCustomerListButtonEdit";
            this.ColumnCustomerListButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnCustomerListButtonEdit.HeaderText = "";
            this.ColumnCustomerListButtonEdit.Name = "ColumnCustomerListButtonEdit";
            this.ColumnCustomerListButtonEdit.ReadOnly = true;
            this.ColumnCustomerListButtonEdit.Width = 70;
            // 
            // ColumnCustomerListButtonDelete
            // 
            this.ColumnCustomerListButtonDelete.DataPropertyName = "ColumnCustomerListButtonDelete";
            this.ColumnCustomerListButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnCustomerListButtonDelete.HeaderText = "";
            this.ColumnCustomerListButtonDelete.Name = "ColumnCustomerListButtonDelete";
            this.ColumnCustomerListButtonDelete.ReadOnly = true;
            this.ColumnCustomerListButtonDelete.Width = 70;
            // 
            // ColumnCustomerListId
            // 
            this.ColumnCustomerListId.DataPropertyName = "ColumnCustomerListId";
            this.ColumnCustomerListId.HeaderText = "Id";
            this.ColumnCustomerListId.Name = "ColumnCustomerListId";
            this.ColumnCustomerListId.ReadOnly = true;
            this.ColumnCustomerListId.Visible = false;
            // 
            // ColumnCustomerListCustomerCode
            // 
            this.ColumnCustomerListCustomerCode.DataPropertyName = "ColumnCustomerListCustomerCode";
            this.ColumnCustomerListCustomerCode.HeaderText = "Code";
            this.ColumnCustomerListCustomerCode.Name = "ColumnCustomerListCustomerCode";
            this.ColumnCustomerListCustomerCode.ReadOnly = true;
            this.ColumnCustomerListCustomerCode.Width = 150;
            // 
            // ColumnCustomerListCustomer
            // 
            this.ColumnCustomerListCustomer.DataPropertyName = "ColumnCustomerListCustomer";
            this.ColumnCustomerListCustomer.HeaderText = "Customer";
            this.ColumnCustomerListCustomer.Name = "ColumnCustomerListCustomer";
            this.ColumnCustomerListCustomer.ReadOnly = true;
            this.ColumnCustomerListCustomer.Width = 250;
            // 
            // ColumnCustomerListContactNumber
            // 
            this.ColumnCustomerListContactNumber.DataPropertyName = "ColumnCustomerListContactNumber";
            this.ColumnCustomerListContactNumber.HeaderText = "Contact No.";
            this.ColumnCustomerListContactNumber.Name = "ColumnCustomerListContactNumber";
            this.ColumnCustomerListContactNumber.ReadOnly = true;
            this.ColumnCustomerListContactNumber.Width = 200;
            // 
            // ColumnCustomerListAddress
            // 
            this.ColumnCustomerListAddress.DataPropertyName = "ColumnCustomerListAddress";
            this.ColumnCustomerListAddress.HeaderText = "Address";
            this.ColumnCustomerListAddress.Name = "ColumnCustomerListAddress";
            this.ColumnCustomerListAddress.ReadOnly = true;
            this.ColumnCustomerListAddress.Width = 250;
            // 
            // ColumnCustomerListIsLocked
            // 
            this.ColumnCustomerListIsLocked.DataPropertyName = "ColumnCustomerListIsLocked";
            this.ColumnCustomerListIsLocked.HeaderText = "L";
            this.ColumnCustomerListIsLocked.Name = "ColumnCustomerListIsLocked";
            this.ColumnCustomerListIsLocked.ReadOnly = true;
            this.ColumnCustomerListIsLocked.Width = 35;
            // 
            // textBoxCustomerListFilter
            // 
            this.textBoxCustomerListFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomerListFilter.Location = new System.Drawing.Point(10, 5);
            this.textBoxCustomerListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerListFilter.Name = "textBoxCustomerListFilter";
            this.textBoxCustomerListFilter.Size = new System.Drawing.Size(1078, 26);
            this.textBoxCustomerListFilter.TabIndex = 19;
            this.textBoxCustomerListFilter.TabStop = false;
            this.textBoxCustomerListFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCustomerListFilter_KeyDown);
            // 
            // MstCustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1096, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MstCustomerListForm";
            this.Text = "MstCustomerListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCustomerListPageListFirst;
        private System.Windows.Forms.Button buttonCustomerListPageListPrevious;
        private System.Windows.Forms.Button buttonCustomerListPageListNext;
        private System.Windows.Forms.Button buttonCustomerListPageListLast;
        private System.Windows.Forms.TextBox textBoxCustomerListPageNumber;
        private System.Windows.Forms.DataGridView dataGridViewCustomerList;
        private System.Windows.Forms.TextBox textBoxCustomerListFilter;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCustomerListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCustomerListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListCustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCustomerListIsLocked;
    }
}