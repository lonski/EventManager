namespace EventManager
{
    partial class PersonForm
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
            this.lName = new System.Windows.Forms.Label();
            this.cFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cCompany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cEmail = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(55, 13);
            this.lName.TabIndex = 3;
            this.lName.Text = "First name";
            // 
            // cFName
            // 
            this.cFName.Location = new System.Drawing.Point(79, 6);
            this.cFName.Name = "cFName";
            this.cFName.Size = new System.Drawing.Size(207, 20);
            this.cFName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Surname";
            // 
            // cSName
            // 
            this.cSName.Location = new System.Drawing.Point(79, 32);
            this.cSName.Name = "cSName";
            this.cSName.Size = new System.Drawing.Size(207, 20);
            this.cSName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Company";
            // 
            // cCompany
            // 
            this.cCompany.Location = new System.Drawing.Point(79, 58);
            this.cCompany.Name = "cCompany";
            this.cCompany.Size = new System.Drawing.Size(207, 20);
            this.cCompany.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone";
            // 
            // cPhone
            // 
            this.cPhone.Location = new System.Drawing.Point(79, 84);
            this.cPhone.MaxLength = 12;
            this.cPhone.Name = "cPhone";
            this.cPhone.Size = new System.Drawing.Size(207, 20);
            this.cPhone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-mail";
            // 
            // cEmail
            // 
            this.cEmail.Location = new System.Drawing.Point(79, 110);
            this.cEmail.Name = "cEmail";
            this.cEmail.Size = new System.Drawing.Size(207, 20);
            this.cEmail.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(211, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(130, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cType
            // 
            this.cType.FormattingEnabled = true;
            this.cType.Items.AddRange(new object[] {
            "Contact person",
            "Recruitment team",
            "Buissness Line contact"});
            this.cType.Location = new System.Drawing.Point(79, 137);
            this.cType.Name = "cType";
            this.cType.Size = new System.Drawing.Size(206, 21);
            this.cType.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Type";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 176);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 211);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cSName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.cFName);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox cFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cEmail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
    }
}