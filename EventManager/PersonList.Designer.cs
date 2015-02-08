﻿namespace EventManager
{
    partial class PersonList
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
            this.ePersons = new BrightIdeasSoftware.ObjectListView();
            this.colType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colSurname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ePersons)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ePersons
            // 
            this.ePersons.AllColumns.Add(this.colType);
            this.ePersons.AllColumns.Add(this.colSurname);
            this.ePersons.AllColumns.Add(this.colName);
            this.ePersons.AllColumns.Add(this.colPhone);
            this.ePersons.AllColumns.Add(this.colEmail);
            this.ePersons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colType,
            this.colSurname,
            this.colName,
            this.colPhone,
            this.colEmail});
            this.ePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ePersons.FullRowSelect = true;
            this.ePersons.Location = new System.Drawing.Point(0, 0);
            this.ePersons.Name = "ePersons";
            this.ePersons.Size = new System.Drawing.Size(603, 447);
            this.ePersons.TabIndex = 25;
            this.ePersons.UseCompatibleStateImageBehavior = false;
            this.ePersons.View = System.Windows.Forms.View.Details;
            this.ePersons.DoubleClick += new System.EventHandler(this.ePersons_DoubleClick);
            // 
            // colType
            // 
            this.colType.AspectName = "Type";
            this.colType.IsVisible = false;
            this.colType.ShowTextInHeader = false;
            this.colType.Text = "Type";
            this.colType.Width = 1;
            // 
            // colSurname
            // 
            this.colSurname.AspectName = "SName";
            this.colSurname.FillsFreeSpace = true;
            this.colSurname.Groupable = false;
            this.colSurname.Text = "Surname";
            // 
            // colName
            // 
            this.colName.AspectName = "FName";
            this.colName.Groupable = false;
            this.colName.Text = "Name";
            // 
            // colPhone
            // 
            this.colPhone.AspectName = "Phone";
            this.colPhone.Groupable = false;
            this.colPhone.Text = "Phone";
            // 
            // colEmail
            // 
            this.colEmail.AspectName = "Email";
            this.colEmail.Groupable = false;
            this.colEmail.Text = "E-mail";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 28);
            this.panel1.TabIndex = 26;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(525, 3);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // PersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 475);
            this.Controls.Add(this.ePersons);
            this.Controls.Add(this.panel1);
            this.Name = "PersonList";
            this.Text = "Person list";
            ((System.ComponentModel.ISupportInitialize)(this.ePersons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView ePersons;
        private BrightIdeasSoftware.OLVColumn colType;
        private BrightIdeasSoftware.OLVColumn colSurname;
        private BrightIdeasSoftware.OLVColumn colName;
        private BrightIdeasSoftware.OLVColumn colPhone;
        private BrightIdeasSoftware.OLVColumn colEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChoose;
    }
}