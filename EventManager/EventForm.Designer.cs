namespace EventManager
{
    partial class EventForm
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
            this.cName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lLocation = new System.Windows.Forms.Label();
            this.cLoaction = new System.Windows.Forms.TextBox();
            this.cDescription = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.lComment = new System.Windows.Forms.Label();
            this.cComments = new System.Windows.Forms.TextBox();
            this.cDate = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.cPrice = new System.Windows.Forms.NumericUpDown();
            this.lPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cCv = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cHired = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ePersons = new BrightIdeasSoftware.ObjectListView();
            this.colType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colSurname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.btnPRemove = new System.Windows.Forms.Button();
            this.btnPEdit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cDeadline = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cTarget = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cApp = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cFeedback = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cApp)).BeginInit();
            this.SuspendLayout();
            // 
            // cName
            // 
            this.cName.Location = new System.Drawing.Point(81, 12);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(207, 20);
            this.cName.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(14, 15);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 1;
            this.lName.Text = "Name";
            // 
            // lLocation
            // 
            this.lLocation.AutoSize = true;
            this.lLocation.Location = new System.Drawing.Point(13, 41);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(48, 13);
            this.lLocation.TabIndex = 3;
            this.lLocation.Text = "Location";
            // 
            // cLoaction
            // 
            this.cLoaction.Location = new System.Drawing.Point(81, 38);
            this.cLoaction.Name = "cLoaction";
            this.cLoaction.Size = new System.Drawing.Size(207, 20);
            this.cLoaction.TabIndex = 2;
            // 
            // cDescription
            // 
            this.cDescription.Location = new System.Drawing.Point(17, 213);
            this.cDescription.Multiline = true;
            this.cDescription.Name = "cDescription";
            this.cDescription.Size = new System.Drawing.Size(273, 98);
            this.cDescription.TabIndex = 4;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(18, 197);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(60, 13);
            this.lDescription.TabIndex = 5;
            this.lDescription.Text = "Description";
            // 
            // lComment
            // 
            this.lComment.AutoSize = true;
            this.lComment.Location = new System.Drawing.Point(17, 315);
            this.lComment.Name = "lComment";
            this.lComment.Size = new System.Drawing.Size(56, 13);
            this.lComment.TabIndex = 7;
            this.lComment.Text = "Comments";
            // 
            // cComments
            // 
            this.cComments.Location = new System.Drawing.Point(16, 331);
            this.cComments.Multiline = true;
            this.cComments.Name = "cComments";
            this.cComments.Size = new System.Drawing.Size(272, 98);
            this.cComments.TabIndex = 6;
            // 
            // cDate
            // 
            this.cDate.CustomFormat = "ddMMMMyyyy,  HH:mm";
            this.cDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cDate.Location = new System.Drawing.Point(81, 64);
            this.cDate.Name = "cDate";
            this.cDate.Size = new System.Drawing.Size(207, 20);
            this.cDate.TabIndex = 8;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(14, 68);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(30, 13);
            this.lDate.TabIndex = 9;
            this.lDate.Text = "Date";
            // 
            // cPrice
            // 
            this.cPrice.DecimalPlaces = 2;
            this.cPrice.Location = new System.Drawing.Point(81, 116);
            this.cPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cPrice.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.cPrice.Name = "cPrice";
            this.cPrice.Size = new System.Drawing.Size(207, 20);
            this.cPrice.TabIndex = 10;
            this.cPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(12, 118);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(61, 13);
            this.lPrice.TabIndex = 11;
            this.lPrice.Text = "Price [PLN]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CV";
            // 
            // cCv
            // 
            this.cCv.Location = new System.Drawing.Point(215, 146);
            this.cCv.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cCv.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.cCv.Name = "cCv";
            this.cCv.Size = new System.Drawing.Size(73, 20);
            this.cCv.TabIndex = 12;
            this.cCv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hired";
            // 
            // cHired
            // 
            this.cHired.Location = new System.Drawing.Point(215, 172);
            this.cHired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cHired.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.cHired.Name = "cHired";
            this.cHired.Size = new System.Drawing.Size(73, 20);
            this.cHired.TabIndex = 14;
            this.cHired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(495, 434);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(576, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.ePersons.FullRowSelect = true;
            this.ePersons.Location = new System.Drawing.Point(309, 54);
            this.ePersons.Name = "ePersons";
            this.ePersons.Size = new System.Drawing.Size(342, 257);
            this.ePersons.TabIndex = 24;
            this.ePersons.UseCompatibleStateImageBehavior = false;
            this.ePersons.View = System.Windows.Forms.View.Details;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Persons";
            // 
            // btnPAdd
            // 
            this.btnPAdd.Location = new System.Drawing.Point(309, 28);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(110, 23);
            this.btnPAdd.TabIndex = 26;
            this.btnPAdd.Text = "Add";
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // btnPRemove
            // 
            this.btnPRemove.Location = new System.Drawing.Point(425, 28);
            this.btnPRemove.Name = "btnPRemove";
            this.btnPRemove.Size = new System.Drawing.Size(110, 23);
            this.btnPRemove.TabIndex = 27;
            this.btnPRemove.Text = "Remove";
            this.btnPRemove.UseVisualStyleBackColor = true;
            this.btnPRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPEdit
            // 
            this.btnPEdit.Location = new System.Drawing.Point(541, 28);
            this.btnPEdit.Name = "btnPEdit";
            this.btnPEdit.Size = new System.Drawing.Size(110, 23);
            this.btnPEdit.TabIndex = 28;
            this.btnPEdit.Text = "Edit";
            this.btnPEdit.UseVisualStyleBackColor = true;
            this.btnPEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 435);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Deadline";
            // 
            // cDeadline
            // 
            this.cDeadline.CustomFormat = "ddMMMMyyyy,  HH:mm";
            this.cDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cDeadline.Location = new System.Drawing.Point(81, 90);
            this.cDeadline.Name = "cDeadline";
            this.cDeadline.Size = new System.Drawing.Size(207, 20);
            this.cDeadline.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Target";
            // 
            // cTarget
            // 
            this.cTarget.Location = new System.Drawing.Point(81, 172);
            this.cTarget.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cTarget.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.cTarget.Name = "cTarget";
            this.cTarget.Size = new System.Drawing.Size(73, 20);
            this.cTarget.TabIndex = 34;
            this.cTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Applications";
            // 
            // cApp
            // 
            this.cApp.Location = new System.Drawing.Point(81, 146);
            this.cApp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cApp.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.cApp.Name = "cApp";
            this.cApp.Size = new System.Drawing.Size(73, 20);
            this.cApp.TabIndex = 32;
            this.cApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Feedback";
            // 
            // cFeedback
            // 
            this.cFeedback.Location = new System.Drawing.Point(309, 330);
            this.cFeedback.Multiline = true;
            this.cFeedback.Name = "cFeedback";
            this.cFeedback.Size = new System.Drawing.Size(342, 98);
            this.cFeedback.TabIndex = 36;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 464);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cFeedback);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cTarget);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cDeadline);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPEdit);
            this.Controls.Add(this.btnPRemove);
            this.Controls.Add(this.btnPAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ePersons);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cHired);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cCv);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.cPrice);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.cDate);
            this.Controls.Add(this.lComment);
            this.Controls.Add(this.cComments);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.cDescription);
            this.Controls.Add(this.lLocation);
            this.Controls.Add(this.cLoaction);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.cName);
            this.Name = "EventForm";
            this.Text = "EventForm";
            ((System.ComponentModel.ISupportInitialize)(this.cPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.TextBox cLoaction;
        private System.Windows.Forms.TextBox cDescription;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lComment;
        private System.Windows.Forms.TextBox cComments;
        private System.Windows.Forms.DateTimePicker cDate;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.NumericUpDown cPrice;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cCv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cHired;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private BrightIdeasSoftware.ObjectListView ePersons;
        private System.Windows.Forms.Label label3;
        private BrightIdeasSoftware.OLVColumn colName;
        private BrightIdeasSoftware.OLVColumn colSurname;
        private BrightIdeasSoftware.OLVColumn colType;
        private BrightIdeasSoftware.OLVColumn colPhone;
        private BrightIdeasSoftware.OLVColumn colEmail;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Button btnPRemove;
        private System.Windows.Forms.Button btnPEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker cDeadline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cTarget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cApp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cFeedback;
    }
}