﻿namespace EventManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.calNextMonth = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.l_month = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.calPrevMonth = new System.Windows.Forms.ToolStripButton();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.eventList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabCalendar);
            this.tabControl.Controls.Add(this.tabEvents);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 101);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(986, 403);
            this.tabControl.TabIndex = 4;
            // 
            // tabCalendar
            // 
            this.tabCalendar.Controls.Add(this.panel1);
            this.tabCalendar.Location = new System.Drawing.Point(4, 4);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalendar.Size = new System.Drawing.Size(978, 377);
            this.tabCalendar.TabIndex = 0;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.calendar);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 371);
            this.panel1.TabIndex = 4;
            // 
            // calendar
            // 
            this.calendar.AllowItemEdit = false;
            this.calendar.AllowItemResize = false;
            this.calendar.AllowNew = false;
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[0];
            this.calendar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.calendar.Location = new System.Drawing.Point(0, 0);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(972, 346);
            this.calendar.TabIndex = 1;
            this.calendar.Text = "Calendar";
            this.calendar.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calNextMonth,
            this.toolStripSeparator2,
            this.l_month,
            this.toolStripSeparator1,
            this.calPrevMonth});
            this.toolStrip2.Location = new System.Drawing.Point(0, 346);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(972, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // calNextMonth
            // 
            this.calNextMonth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.calNextMonth.AutoSize = false;
            this.calNextMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.calNextMonth.Image = ((System.Drawing.Image)(resources.GetObject("calNextMonth.Image")));
            this.calNextMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calNextMonth.Name = "calNextMonth";
            this.calNextMonth.Size = new System.Drawing.Size(70, 22);
            this.calNextMonth.Text = "Next >";
            this.calNextMonth.Click += new System.EventHandler(this.calNextMonth_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // l_month
            // 
            this.l_month.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.l_month.Name = "l_month";
            this.l_month.Size = new System.Drawing.Size(86, 22);
            this.l_month.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // calPrevMonth
            // 
            this.calPrevMonth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.calPrevMonth.AutoSize = false;
            this.calPrevMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.calPrevMonth.Image = ((System.Drawing.Image)(resources.GetObject("calPrevMonth.Image")));
            this.calPrevMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calPrevMonth.Name = "calPrevMonth";
            this.calPrevMonth.Size = new System.Drawing.Size(70, 22);
            this.calPrevMonth.Text = "< Previous";
            this.calPrevMonth.Click += new System.EventHandler(this.calPrevMonth_Click_1);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.eventList);
            this.tabEvents.Location = new System.Drawing.Point(4, 4);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(978, 377);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Panels.Add(this.ribbonPanel1);
            this.ribbonTab3.Text = "ribbonTab3";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Text = null;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbVisible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(986, 101);
            this.ribbon1.TabIndex = 5;
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Panels.Add(this.ribbonPanel3);
            this.ribbonTab4.Text = "";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton2);
            this.ribbonPanel3.Items.Add(this.ribbonButton3);
            this.ribbonPanel3.Text = null;
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Calendar";
            this.ribbonButton2.ToolTip = "";
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Events";
            this.ribbonButton3.Click += new System.EventHandler(this.ribbonButton3_Click);
            // 
            // eventList
            // 
            this.eventList.AllColumns.Add(this.olvColumn1);
            this.eventList.AllColumns.Add(this.olvColumn2);
            this.eventList.AllColumns.Add(this.olvColumn3);
            this.eventList.AllColumns.Add(this.olvColumn4);
            this.eventList.AllColumns.Add(this.olvColumn5);
            this.eventList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.eventList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventList.EmptyListMsg = "None";
            this.eventList.FullRowSelect = true;
            this.eventList.GridLines = true;
            this.eventList.Location = new System.Drawing.Point(3, 3);
            this.eventList.MultiSelect = false;
            this.eventList.Name = "eventList";
            this.eventList.RowHeight = 24;
            this.eventList.SelectAllOnControlA = false;
            this.eventList.ShowGroups = false;
            this.eventList.Size = new System.Drawing.Size(972, 371);
            this.eventList.TabIndex = 0;
            this.eventList.UseCompatibleStateImageBehavior = false;
            this.eventList.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.Text = "Name";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Location";
            this.olvColumn2.Text = "Location";
            this.olvColumn2.Width = 160;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Description";
            this.olvColumn3.Text = "Description";
            this.olvColumn3.Width = 262;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "DateStart";
            this.olvColumn4.Text = "Start date";
            this.olvColumn4.Width = 167;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "DateEnd";
            this.olvColumn5.Text = "End date";
            this.olvColumn5.Width = 184;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 504);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbon1);
            this.Name = "frmMain";
            this.Text = "Event Manager";
            this.tabControl.ResumeLayout(false);
            this.tabCalendar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Calendar.Calendar calendar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton calNextMonth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel l_month;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton calPrevMonth;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private BrightIdeasSoftware.ObjectListView eventList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;


    }
}

