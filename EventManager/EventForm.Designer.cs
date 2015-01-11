﻿namespace EventManager
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
            ((System.ComponentModel.ISupportInitialize)(this.cPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHired)).BeginInit();
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
            this.cDescription.Location = new System.Drawing.Point(15, 192);
            this.cDescription.Multiline = true;
            this.cDescription.Name = "cDescription";
            this.cDescription.Size = new System.Drawing.Size(273, 98);
            this.cDescription.TabIndex = 4;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(16, 176);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(60, 13);
            this.lDescription.TabIndex = 5;
            this.lDescription.Text = "Description";
            // 
            // lComment
            // 
            this.lComment.AutoSize = true;
            this.lComment.Location = new System.Drawing.Point(17, 297);
            this.lComment.Name = "lComment";
            this.lComment.Size = new System.Drawing.Size(56, 13);
            this.lComment.TabIndex = 7;
            this.lComment.Text = "Comments";
            // 
            // cComments
            // 
            this.cComments.Location = new System.Drawing.Point(16, 313);
            this.cComments.Multiline = true;
            this.cComments.Name = "cComments";
            this.cComments.Size = new System.Drawing.Size(272, 98);
            this.cComments.TabIndex = 6;
            // 
            // cDate
            // 
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
            this.cPrice.Location = new System.Drawing.Point(81, 90);
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
            this.lPrice.Location = new System.Drawing.Point(12, 92);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(61, 13);
            this.lPrice.TabIndex = 11;
            this.lPrice.Text = "Price [PLN]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CV";
            // 
            // cCv
            // 
            this.cCv.Location = new System.Drawing.Point(81, 116);
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
            this.cCv.Size = new System.Drawing.Size(207, 20);
            this.cCv.TabIndex = 12;
            this.cCv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hired";
            // 
            // cHired
            // 
            this.cHired.Location = new System.Drawing.Point(81, 142);
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
            this.cHired.Size = new System.Drawing.Size(207, 20);
            this.cHired.TabIndex = 14;
            this.cHired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(132, 417);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(213, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 448);
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
    }
}