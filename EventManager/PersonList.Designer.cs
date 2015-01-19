namespace EventManager
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
            ((System.ComponentModel.ISupportInitialize)(this.ePersons)).BeginInit();
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
            this.ePersons.Size = new System.Drawing.Size(603, 475);
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
            // PersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 475);
            this.Controls.Add(this.ePersons);
            this.Name = "PersonList";
            this.Text = "Person list";
            ((System.ComponentModel.ISupportInitialize)(this.ePersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView ePersons;
        private BrightIdeasSoftware.OLVColumn colType;
        private BrightIdeasSoftware.OLVColumn colSurname;
        private BrightIdeasSoftware.OLVColumn colName;
        private BrightIdeasSoftware.OLVColumn colPhone;
        private BrightIdeasSoftware.OLVColumn colEmail;
    }
}