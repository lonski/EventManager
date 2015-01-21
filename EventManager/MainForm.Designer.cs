namespace EventManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.eventList = new BrightIdeasSoftware.ObjectListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colLoaction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colCV = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHired = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.listSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.personList = new BrightIdeasSoftware.ObjectListView();
            this.colType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colFName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colSName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colCompany = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.panelEvent = new System.Windows.Forms.RibbonPanel();
            this.eventInfo = new System.Windows.Forms.RibbonButton();
            this.eventEdit = new System.Windows.Forms.RibbonButton();
            this.eventAdd = new System.Windows.Forms.RibbonButton();
            this.eventDelete = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.btnPersons = new System.Windows.Forms.RibbonButton();
            this.ribbonTab5 = new System.Windows.Forms.RibbonTab();
            this.ribbon2 = new System.Windows.Forms.Ribbon();
            this.itmReload = new System.Windows.Forms.RibbonOrbMenuItem();
            this.itmSettings = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.itmAbout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.itmExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rtabCalendar = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.etabEvents = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton9 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton10 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton11 = new System.Windows.Forms.RibbonButton();
            this.rtabPersons = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.personInfo = new System.Windows.Forms.RibbonButton();
            this.personEdit = new System.Windows.Forms.RibbonButton();
            this.personAdd = new System.Windows.Forms.RibbonButton();
            this.personDelete = new System.Windows.Forms.RibbonButton();
            this.colApplications = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colTarget = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colDeadline = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabCalendar);
            this.tabControl.Controls.Add(this.tabEvents);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(60, 14);
            this.tabControl.Location = new System.Drawing.Point(0, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(745, 384);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 4;
            // 
            // tabCalendar
            // 
            this.tabCalendar.Controls.Add(this.panel1);
            this.tabCalendar.Location = new System.Drawing.Point(4, 4);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalendar.Size = new System.Drawing.Size(737, 362);
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
            this.panel1.Size = new System.Drawing.Size(731, 356);
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
            this.calendar.Size = new System.Drawing.Size(731, 331);
            this.calendar.TabIndex = 1;
            this.calendar.Text = "Calendar";
            this.calendar.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            this.calendar.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar_LoadItems);
            this.calendar.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar_ItemDoubleClick);
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 331);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(731, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // calNextMonth
            // 
            this.calNextMonth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.calNextMonth.AutoSize = false;
            this.calNextMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
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
            this.tabEvents.Size = new System.Drawing.Size(737, 362);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "List";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // eventList
            // 
            this.eventList.AllColumns.Add(this.colName);
            this.eventList.AllColumns.Add(this.colLoaction);
            this.eventList.AllColumns.Add(this.colDate);
            this.eventList.AllColumns.Add(this.colPrice);
            this.eventList.AllColumns.Add(this.colDeadline);
            this.eventList.AllColumns.Add(this.colTarget);
            this.eventList.AllColumns.Add(this.colApplications);
            this.eventList.AllColumns.Add(this.colCV);
            this.eventList.AllColumns.Add(this.colHired);
            this.eventList.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eventList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colLoaction,
            this.colDate,
            this.colPrice,
            this.colDeadline,
            this.colTarget,
            this.colApplications,
            this.colCV,
            this.colHired});
            this.eventList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventList.EmptyListMsg = "None";
            this.eventList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventList.FullRowSelect = true;
            this.eventList.GridLines = true;
            this.eventList.LargeImageList = this.listSmallIcons;
            this.eventList.Location = new System.Drawing.Point(3, 3);
            this.eventList.MultiSelect = false;
            this.eventList.Name = "eventList";
            this.eventList.PersistentCheckBoxes = false;
            this.eventList.RowHeight = 24;
            this.eventList.SelectAllOnControlA = false;
            this.eventList.ShowGroups = false;
            this.eventList.ShowImagesOnSubItems = true;
            this.eventList.Size = new System.Drawing.Size(731, 356);
            this.eventList.SmallImageList = this.listSmallIcons;
            this.eventList.TabIndex = 0;
            this.eventList.UseAlternatingBackColors = true;
            this.eventList.UseCompatibleStateImageBehavior = false;
            this.eventList.View = System.Windows.Forms.View.Details;
            this.eventList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.eventList_MouseDoubleClick);
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.FillsFreeSpace = true;
            this.colName.Text = "Name";
            // 
            // colLoaction
            // 
            this.colLoaction.AspectName = "Location";
            this.colLoaction.Text = "Location";
            this.colLoaction.Width = 160;
            // 
            // colDate
            // 
            this.colDate.AspectName = "Date";
            this.colDate.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDate.Text = "Date";
            this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDate.Width = 167;
            // 
            // colPrice
            // 
            this.colPrice.AspectName = "Price";
            this.colPrice.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrice.ImageAspectName = "PriceIcon";
            this.colPrice.Text = "Price";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colCV
            // 
            this.colCV.AspectName = "Cv";
            this.colCV.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCV.Text = "CV";
            this.colCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colHired
            // 
            this.colHired.AspectName = "Hired";
            this.colHired.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHired.Text = "Hired";
            this.colHired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listSmallIcons
            // 
            this.listSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listSmallIcons.ImageStream")));
            this.listSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.listSmallIcons.Images.SetKeyName(0, "address-book.png");
            this.listSmallIcons.Images.SetKeyName(1, "address-book-alt.png");
            this.listSmallIcons.Images.SetKeyName(2, "bag.png");
            this.listSmallIcons.Images.SetKeyName(3, "basket.png");
            this.listSmallIcons.Images.SetKeyName(4, "beer.png");
            this.listSmallIcons.Images.SetKeyName(5, "bell.png");
            this.listSmallIcons.Images.SetKeyName(6, "bitcoin.png");
            this.listSmallIcons.Images.SetKeyName(7, "book.png");
            this.listSmallIcons.Images.SetKeyName(8, "book-bookmark.png");
            this.listSmallIcons.Images.SetKeyName(9, "box.png");
            this.listSmallIcons.Images.SetKeyName(10, "box-full.png");
            this.listSmallIcons.Images.SetKeyName(11, "box-in.png");
            this.listSmallIcons.Images.SetKeyName(12, "box-out.png");
            this.listSmallIcons.Images.SetKeyName(13, "brick.png");
            this.listSmallIcons.Images.SetKeyName(14, "brick-alt.png");
            this.listSmallIcons.Images.SetKeyName(15, "bubble.png");
            this.listSmallIcons.Images.SetKeyName(16, "bubbles.png");
            this.listSmallIcons.Images.SetKeyName(17, "bubbles-alt.png");
            this.listSmallIcons.Images.SetKeyName(18, "building.png");
            this.listSmallIcons.Images.SetKeyName(19, "bullhorn.png");
            this.listSmallIcons.Images.SetKeyName(20, "calculator.png");
            this.listSmallIcons.Images.SetKeyName(21, "calendar.png");
            this.listSmallIcons.Images.SetKeyName(22, "calendar-clock.png");
            this.listSmallIcons.Images.SetKeyName(23, "carton.png");
            this.listSmallIcons.Images.SetKeyName(24, "cat.png");
            this.listSmallIcons.Images.SetKeyName(25, "clock.png");
            this.listSmallIcons.Images.SetKeyName(26, "cloud.png");
            this.listSmallIcons.Images.SetKeyName(27, "cloud-down.png");
            this.listSmallIcons.Images.SetKeyName(28, "cloud-sync.png");
            this.listSmallIcons.Images.SetKeyName(29, "cloud-up.png");
            this.listSmallIcons.Images.SetKeyName(30, "cog.png");
            this.listSmallIcons.Images.SetKeyName(31, "cogs.png");
            this.listSmallIcons.Images.SetKeyName(32, "compass.png");
            this.listSmallIcons.Images.SetKeyName(33, "cone.png");
            this.listSmallIcons.Images.SetKeyName(34, "dashboard.png");
            this.listSmallIcons.Images.SetKeyName(35, "dashboard-alt.png");
            this.listSmallIcons.Images.SetKeyName(36, "database.png");
            this.listSmallIcons.Images.SetKeyName(37, "device-camera.png");
            this.listSmallIcons.Images.SetKeyName(38, "device-computer.png");
            this.listSmallIcons.Images.SetKeyName(39, "device-drive.png");
            this.listSmallIcons.Images.SetKeyName(40, "device-laptop.png");
            this.listSmallIcons.Images.SetKeyName(41, "device-mobile-phone.png");
            this.listSmallIcons.Images.SetKeyName(42, "device-tablet.png");
            this.listSmallIcons.Images.SetKeyName(43, "device-tv.png");
            this.listSmallIcons.Images.SetKeyName(44, "disc.png");
            this.listSmallIcons.Images.SetKeyName(45, "disc-vinyl.png");
            this.listSmallIcons.Images.SetKeyName(46, "drop.png");
            this.listSmallIcons.Images.SetKeyName(47, "envelope.png");
            this.listSmallIcons.Images.SetKeyName(48, "envelope-letter.png");
            this.listSmallIcons.Images.SetKeyName(49, "file-bookmark.png");
            this.listSmallIcons.Images.SetKeyName(50, "file-code.png");
            this.listSmallIcons.Images.SetKeyName(51, "file-empty.png");
            this.listSmallIcons.Images.SetKeyName(52, "file-excel.png");
            this.listSmallIcons.Images.SetKeyName(53, "file-exe.png");
            this.listSmallIcons.Images.SetKeyName(54, "file-font.png");
            this.listSmallIcons.Images.SetKeyName(55, "file-illustrator.png");
            this.listSmallIcons.Images.SetKeyName(56, "file-indesign.png");
            this.listSmallIcons.Images.SetKeyName(57, "file-link.png");
            this.listSmallIcons.Images.SetKeyName(58, "file-note.png");
            this.listSmallIcons.Images.SetKeyName(59, "file-pdf.png");
            this.listSmallIcons.Images.SetKeyName(60, "file-photoshop.png");
            this.listSmallIcons.Images.SetKeyName(61, "file-picture.png");
            this.listSmallIcons.Images.SetKeyName(62, "file-powerpoint.png");
            this.listSmallIcons.Images.SetKeyName(63, "file-premiere.png");
            this.listSmallIcons.Images.SetKeyName(64, "file-sound.png");
            this.listSmallIcons.Images.SetKeyName(65, "file-text.png");
            this.listSmallIcons.Images.SetKeyName(66, "file-video.png");
            this.listSmallIcons.Images.SetKeyName(67, "file-word.png");
            this.listSmallIcons.Images.SetKeyName(68, "file-zip.png");
            this.listSmallIcons.Images.SetKeyName(69, "flag.png");
            this.listSmallIcons.Images.SetKeyName(70, "flag-alt.png");
            this.listSmallIcons.Images.SetKeyName(71, "flask.png");
            this.listSmallIcons.Images.SetKeyName(72, "floppy.png");
            this.listSmallIcons.Images.SetKeyName(73, "flower.png");
            this.listSmallIcons.Images.SetKeyName(74, "folder.png");
            this.listSmallIcons.Images.SetKeyName(75, "folder-document.png");
            this.listSmallIcons.Images.SetKeyName(76, "folder-house.png");
            this.listSmallIcons.Images.SetKeyName(77, "folder-music.png");
            this.listSmallIcons.Images.SetKeyName(78, "folder-picture.png");
            this.listSmallIcons.Images.SetKeyName(79, "folder-video.png");
            this.listSmallIcons.Images.SetKeyName(80, "funnel.png");
            this.listSmallIcons.Images.SetKeyName(81, "gamepad.png");
            this.listSmallIcons.Images.SetKeyName(82, "gift.png");
            this.listSmallIcons.Images.SetKeyName(83, "globe.png");
            this.listSmallIcons.Images.SetKeyName(84, "handshake.png");
            this.listSmallIcons.Images.SetKeyName(85, "headphone.png");
            this.listSmallIcons.Images.SetKeyName(86, "heart.png");
            this.listSmallIcons.Images.SetKeyName(87, "house.png");
            this.listSmallIcons.Images.SetKeyName(88, "institution.png");
            this.listSmallIcons.Images.SetKeyName(89, "key.png");
            this.listSmallIcons.Images.SetKeyName(90, "keyring.png");
            this.listSmallIcons.Images.SetKeyName(91, "layers.png");
            this.listSmallIcons.Images.SetKeyName(92, "life-buoy.png");
            this.listSmallIcons.Images.SetKeyName(93, "light-bulb.png");
            this.listSmallIcons.Images.SetKeyName(94, "lightning.png");
            this.listSmallIcons.Images.SetKeyName(95, "lock.png");
            this.listSmallIcons.Images.SetKeyName(96, "lock-open.png");
            this.listSmallIcons.Images.SetKeyName(97, "magnify.png");
            this.listSmallIcons.Images.SetKeyName(98, "magnify-less.png");
            this.listSmallIcons.Images.SetKeyName(99, "map.png");
            this.listSmallIcons.Images.SetKeyName(100, "map-map-marker.png");
            this.listSmallIcons.Images.SetKeyName(101, "map-marker.png");
            this.listSmallIcons.Images.SetKeyName(102, "microphone.png");
            this.listSmallIcons.Images.SetKeyName(103, "mixer.png");
            this.listSmallIcons.Images.SetKeyName(104, "money.png");
            this.listSmallIcons.Images.SetKeyName(105, "monitor.png");
            this.listSmallIcons.Images.SetKeyName(106, "news.png");
            this.listSmallIcons.Images.SetKeyName(107, "notepad.png");
            this.listSmallIcons.Images.SetKeyName(108, "paperclip.png");
            this.listSmallIcons.Images.SetKeyName(109, "paper-plane.png");
            this.listSmallIcons.Images.SetKeyName(110, "pencil.png");
            this.listSmallIcons.Images.SetKeyName(111, "phone.png");
            this.listSmallIcons.Images.SetKeyName(112, "pin.png");
            this.listSmallIcons.Images.SetKeyName(113, "post-it.png");
            this.listSmallIcons.Images.SetKeyName(114, "profile.png");
            this.listSmallIcons.Images.SetKeyName(115, "profile-group.png");
            this.listSmallIcons.Images.SetKeyName(116, "puzzle.png");
            this.listSmallIcons.Images.SetKeyName(117, "radio.png");
            this.listSmallIcons.Images.SetKeyName(118, "rss.png");
            this.listSmallIcons.Images.SetKeyName(119, "safe.png");
            this.listSmallIcons.Images.SetKeyName(120, "search.png");
            this.listSmallIcons.Images.SetKeyName(121, "shield.png");
            this.listSmallIcons.Images.SetKeyName(122, "shield-error.png");
            this.listSmallIcons.Images.SetKeyName(123, "shield-ok.png");
            this.listSmallIcons.Images.SetKeyName(124, "shield-warning.png");
            this.listSmallIcons.Images.SetKeyName(125, "shop.png");
            this.listSmallIcons.Images.SetKeyName(126, "sign-add.png");
            this.listSmallIcons.Images.SetKeyName(127, "sign-ban.png");
            this.listSmallIcons.Images.SetKeyName(128, "sign-check.png");
            this.listSmallIcons.Images.SetKeyName(129, "sign-delete.png");
            this.listSmallIcons.Images.SetKeyName(130, "sign-down.png");
            this.listSmallIcons.Images.SetKeyName(131, "sign-error.png");
            this.listSmallIcons.Images.SetKeyName(132, "sign-info.png");
            this.listSmallIcons.Images.SetKeyName(133, "sign-left.png");
            this.listSmallIcons.Images.SetKeyName(134, "sign-question.png");
            this.listSmallIcons.Images.SetKeyName(135, "sign-right.png");
            this.listSmallIcons.Images.SetKeyName(136, "sign-sync.png");
            this.listSmallIcons.Images.SetKeyName(137, "sign-up.png");
            this.listSmallIcons.Images.SetKeyName(138, "sign-warning.png");
            this.listSmallIcons.Images.SetKeyName(139, "skull.png");
            this.listSmallIcons.Images.SetKeyName(140, "snow-flake.png");
            this.listSmallIcons.Images.SetKeyName(141, "social-facebook.png");
            this.listSmallIcons.Images.SetKeyName(142, "social-google-plus.png");
            this.listSmallIcons.Images.SetKeyName(143, "social-twitter.png");
            this.listSmallIcons.Images.SetKeyName(144, "social-youtube.png");
            this.listSmallIcons.Images.SetKeyName(145, "stamp.png");
            this.listSmallIcons.Images.SetKeyName(146, "star.png");
            this.listSmallIcons.Images.SetKeyName(147, "star-alt.png");
            this.listSmallIcons.Images.SetKeyName(148, "sun.png");
            this.listSmallIcons.Images.SetKeyName(149, "switch-off.png");
            this.listSmallIcons.Images.SetKeyName(150, "switch-on.png");
            this.listSmallIcons.Images.SetKeyName(151, "tag.png");
            this.listSmallIcons.Images.SetKeyName(152, "tag-alt.png");
            this.listSmallIcons.Images.SetKeyName(153, "terminal.png");
            this.listSmallIcons.Images.SetKeyName(154, "thumb-up.png");
            this.listSmallIcons.Images.SetKeyName(155, "trashcan.png");
            this.listSmallIcons.Images.SetKeyName(156, "trashcan-full.png");
            this.listSmallIcons.Images.SetKeyName(157, "user-female.png");
            this.listSmallIcons.Images.SetKeyName(158, "user-female-alt.png");
            this.listSmallIcons.Images.SetKeyName(159, "user-id.png");
            this.listSmallIcons.Images.SetKeyName(160, "user-male.png");
            this.listSmallIcons.Images.SetKeyName(161, "user-male-alt.png");
            this.listSmallIcons.Images.SetKeyName(162, "webcam.png");
            this.listSmallIcons.Images.SetKeyName(163, "window.png");
            this.listSmallIcons.Images.SetKeyName(164, "window-layout.png");
            this.listSmallIcons.Images.SetKeyName(165, "window-system.png");
            this.listSmallIcons.Images.SetKeyName(166, "wine.png");
            this.listSmallIcons.Images.SetKeyName(167, "wrench.png");
            this.listSmallIcons.Images.SetKeyName(168, "wrench-screwdriver.png");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.personList);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(737, 362);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Persons";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // personList
            // 
            this.personList.AllColumns.Add(this.colType);
            this.personList.AllColumns.Add(this.colFName);
            this.personList.AllColumns.Add(this.colSName);
            this.personList.AllColumns.Add(this.colCompany);
            this.personList.AllColumns.Add(this.colPhone);
            this.personList.AllColumns.Add(this.colEmail);
            this.personList.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colType,
            this.colFName,
            this.colSName,
            this.colCompany,
            this.colPhone,
            this.colEmail});
            this.personList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personList.EmptyListMsg = "None";
            this.personList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personList.FullRowSelect = true;
            this.personList.GridLines = true;
            this.personList.LargeImageList = this.listSmallIcons;
            this.personList.Location = new System.Drawing.Point(0, 0);
            this.personList.MultiSelect = false;
            this.personList.Name = "personList";
            this.personList.PersistentCheckBoxes = false;
            this.personList.RowHeight = 24;
            this.personList.SelectAllOnControlA = false;
            this.personList.ShowImagesOnSubItems = true;
            this.personList.Size = new System.Drawing.Size(737, 362);
            this.personList.SmallImageList = this.listSmallIcons;
            this.personList.TabIndex = 1;
            this.personList.UseAlternatingBackColors = true;
            this.personList.UseCompatibleStateImageBehavior = false;
            this.personList.View = System.Windows.Forms.View.Details;
            this.personList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.personList_MouseDoubleClick);
            // 
            // colType
            // 
            this.colType.AspectName = "Type";
            this.colType.Text = "Type";
            // 
            // colFName
            // 
            this.colFName.AspectName = "FName";
            this.colFName.Text = "First name";
            this.colFName.Width = 107;
            // 
            // colSName
            // 
            this.colSName.AspectName = "SName";
            this.colSName.Text = "Surname";
            this.colSName.Width = 109;
            // 
            // colCompany
            // 
            this.colCompany.AspectName = "Company";
            this.colCompany.Text = "Company";
            this.colCompany.Width = 131;
            // 
            // colPhone
            // 
            this.colPhone.AspectName = "Phone";
            this.colPhone.Text = "Phone";
            this.colPhone.Width = 84;
            // 
            // colEmail
            // 
            this.colEmail.AspectName = "Email";
            this.colEmail.FillsFreeSpace = true;
            this.colEmail.Text = "E-mail";
            this.colEmail.Width = 82;
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
            // ribbonTab4
            // 
            this.ribbonTab4.Panels.Add(this.ribbonPanel3);
            this.ribbonTab4.Panels.Add(this.panelEvent);
            this.ribbonTab4.Panels.Add(this.ribbonPanel4);
            this.ribbonTab4.Text = "";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton2);
            this.ribbonPanel3.Items.Add(this.ribbonButton3);
            this.ribbonPanel3.Text = "Views";
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
            this.ribbonButton3.Text = "List";
            this.ribbonButton3.Click += new System.EventHandler(this.ribbonButton3_Click);
            // 
            // panelEvent
            // 
            this.panelEvent.Items.Add(this.eventInfo);
            this.panelEvent.Items.Add(this.eventEdit);
            this.panelEvent.Items.Add(this.eventAdd);
            this.panelEvent.Items.Add(this.eventDelete);
            this.panelEvent.Text = "Event";
            // 
            // eventInfo
            // 
            this.eventInfo.Image = ((System.Drawing.Image)(resources.GetObject("eventInfo.Image")));
            this.eventInfo.SmallImage = ((System.Drawing.Image)(resources.GetObject("eventInfo.SmallImage")));
            this.eventInfo.Text = "Show";
            this.eventInfo.Click += new System.EventHandler(this.eventInfo_Click);
            // 
            // eventEdit
            // 
            this.eventEdit.Image = ((System.Drawing.Image)(resources.GetObject("eventEdit.Image")));
            this.eventEdit.SmallImage = ((System.Drawing.Image)(resources.GetObject("eventEdit.SmallImage")));
            this.eventEdit.Text = "Edit";
            this.eventEdit.Click += new System.EventHandler(this.eventEdit_Click);
            // 
            // eventAdd
            // 
            this.eventAdd.Image = ((System.Drawing.Image)(resources.GetObject("eventAdd.Image")));
            this.eventAdd.SmallImage = ((System.Drawing.Image)(resources.GetObject("eventAdd.SmallImage")));
            this.eventAdd.Text = "Add";
            this.eventAdd.Click += new System.EventHandler(this.eventAdd_Click);
            // 
            // eventDelete
            // 
            this.eventDelete.Image = ((System.Drawing.Image)(resources.GetObject("eventDelete.Image")));
            this.eventDelete.SmallImage = ((System.Drawing.Image)(resources.GetObject("eventDelete.SmallImage")));
            this.eventDelete.Text = "Delete";
            this.eventDelete.Click += new System.EventHandler(this.eventDelete_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.btnPersons);
            this.ribbonPanel4.Text = "";
            // 
            // btnPersons
            // 
            this.btnPersons.Image = ((System.Drawing.Image)(resources.GetObject("btnPersons.Image")));
            this.btnPersons.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPersons.SmallImage")));
            this.btnPersons.Text = "Persons";
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Text = null;
            // 
            // ribbon2
            // 
            this.ribbon2.CaptionBarVisible = false;
            this.ribbon2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon2.Location = new System.Drawing.Point(0, 0);
            this.ribbon2.Minimized = false;
            this.ribbon2.Name = "ribbon2";
            // 
            // 
            // 
            this.ribbon2.OrbDropDown.BorderRoundness = 8;
            this.ribbon2.OrbDropDown.ContentButtonsMinWidth = 200;
            this.ribbon2.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon2.OrbDropDown.MenuItems.Add(this.itmReload);
            this.ribbon2.OrbDropDown.MenuItems.Add(this.itmSettings);
            this.ribbon2.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.ribbon2.OrbDropDown.MenuItems.Add(this.itmAbout);
            this.ribbon2.OrbDropDown.MenuItems.Add(this.itmExit);
            this.ribbon2.OrbDropDown.Name = "";
            this.ribbon2.OrbDropDown.Size = new System.Drawing.Size(212, 251);
            this.ribbon2.OrbDropDown.TabIndex = 0;
            this.ribbon2.OrbImage = null;
            this.ribbon2.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon2.OrbText = "Event Manager";
            this.ribbon2.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon2.Size = new System.Drawing.Size(745, 120);
            this.ribbon2.TabIndex = 6;
            this.ribbon2.Tabs.Add(this.rtabCalendar);
            this.ribbon2.Tabs.Add(this.etabEvents);
            this.ribbon2.Tabs.Add(this.rtabPersons);
            this.ribbon2.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon2.Text = "ribbon2";
            this.ribbon2.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            this.ribbon2.ActiveTabChanged += new System.EventHandler(this.ribbon2_ActiveTabChanged);
            // 
            // itmReload
            // 
            this.itmReload.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.itmReload.Image = global::EventManager.Properties.Resources.sign_sync;
            this.itmReload.SmallImage = global::EventManager.Properties.Resources.sign_sync;
            this.itmReload.Text = "Reload all data";
            this.itmReload.Click += new System.EventHandler(this.itmReload_Click);
            // 
            // itmSettings
            // 
            this.itmSettings.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.itmSettings.Image = global::EventManager.Properties.Resources.wrench_screwdriver;
            this.itmSettings.SmallImage = global::EventManager.Properties.Resources.wrench_screwdriver;
            this.itmSettings.Text = "Settings";
            this.itmSettings.Click += new System.EventHandler(this.itmSettings_Click);
            // 
            // itmAbout
            // 
            this.itmAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.itmAbout.Image = global::EventManager.Properties.Resources.sign_question;
            this.itmAbout.SmallImage = global::EventManager.Properties.Resources.sign_question;
            this.itmAbout.Text = "About";
            this.itmAbout.Click += new System.EventHandler(this.itmAbout_Click);
            // 
            // itmExit
            // 
            this.itmExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.itmExit.Image = global::EventManager.Properties.Resources.exit1;
            this.itmExit.SmallImage = global::EventManager.Properties.Resources.exit1;
            this.itmExit.Text = "Exit";
            this.itmExit.Click += new System.EventHandler(this.itmExit_Click);
            // 
            // rtabCalendar
            // 
            this.rtabCalendar.Panels.Add(this.ribbonPanel5);
            this.rtabCalendar.Text = "Calendar";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.ribbonButton4);
            this.ribbonPanel5.Items.Add(this.ribbonButton5);
            this.ribbonPanel5.Items.Add(this.ribbonButton6);
            this.ribbonPanel5.Items.Add(this.ribbonButton7);
            this.ribbonPanel5.Text = "Event";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = global::EventManager.Properties.Resources.info;
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "Show";
            this.ribbonButton4.Click += new System.EventHandler(this.eventInfo_Click);
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = global::EventManager.Properties.Resources.edit;
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Edit";
            this.ribbonButton5.Click += new System.EventHandler(this.eventEdit_Click);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = global::EventManager.Properties.Resources.add;
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "Add";
            this.ribbonButton6.Click += new System.EventHandler(this.eventAdd_Click);
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = global::EventManager.Properties.Resources.delete;
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "Delete";
            this.ribbonButton7.Click += new System.EventHandler(this.eventDelete_Click);
            // 
            // etabEvents
            // 
            this.etabEvents.Panels.Add(this.ribbonPanel6);
            this.etabEvents.Text = "Events";
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.ribbonButton8);
            this.ribbonPanel6.Items.Add(this.ribbonButton9);
            this.ribbonPanel6.Items.Add(this.ribbonButton10);
            this.ribbonPanel6.Items.Add(this.ribbonButton11);
            this.ribbonPanel6.Text = "Event";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = global::EventManager.Properties.Resources.info;
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "Show";
            this.ribbonButton8.Click += new System.EventHandler(this.eventInfo_Click);
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.Image = global::EventManager.Properties.Resources.edit;
            this.ribbonButton9.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.SmallImage")));
            this.ribbonButton9.Text = "Edit";
            this.ribbonButton9.Click += new System.EventHandler(this.eventEdit_Click);
            // 
            // ribbonButton10
            // 
            this.ribbonButton10.Image = global::EventManager.Properties.Resources.add;
            this.ribbonButton10.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton10.SmallImage")));
            this.ribbonButton10.Text = "Add";
            this.ribbonButton10.Click += new System.EventHandler(this.eventAdd_Click);
            // 
            // ribbonButton11
            // 
            this.ribbonButton11.Image = global::EventManager.Properties.Resources.delete;
            this.ribbonButton11.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton11.SmallImage")));
            this.ribbonButton11.Text = "Delete";
            this.ribbonButton11.Click += new System.EventHandler(this.eventDelete_Click);
            // 
            // rtabPersons
            // 
            this.rtabPersons.Panels.Add(this.ribbonPanel7);
            this.rtabPersons.Text = "Persons";
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.personInfo);
            this.ribbonPanel7.Items.Add(this.personEdit);
            this.ribbonPanel7.Items.Add(this.personAdd);
            this.ribbonPanel7.Items.Add(this.personDelete);
            this.ribbonPanel7.Text = "Person";
            // 
            // personInfo
            // 
            this.personInfo.Image = global::EventManager.Properties.Resources.info;
            this.personInfo.SmallImage = ((System.Drawing.Image)(resources.GetObject("personInfo.SmallImage")));
            this.personInfo.Text = "Show";
            this.personInfo.Click += new System.EventHandler(this.personInfo_Click);
            // 
            // personEdit
            // 
            this.personEdit.Image = global::EventManager.Properties.Resources.edit;
            this.personEdit.SmallImage = ((System.Drawing.Image)(resources.GetObject("personEdit.SmallImage")));
            this.personEdit.Text = "Edit";
            this.personEdit.Click += new System.EventHandler(this.personEdit_Click);
            // 
            // personAdd
            // 
            this.personAdd.Image = global::EventManager.Properties.Resources.add;
            this.personAdd.SmallImage = ((System.Drawing.Image)(resources.GetObject("personAdd.SmallImage")));
            this.personAdd.Text = "Add";
            this.personAdd.Click += new System.EventHandler(this.personAdd_Click);
            // 
            // personDelete
            // 
            this.personDelete.Image = global::EventManager.Properties.Resources.delete;
            this.personDelete.SmallImage = ((System.Drawing.Image)(resources.GetObject("personDelete.SmallImage")));
            this.personDelete.Text = "Delete";
            this.personDelete.Click += new System.EventHandler(this.personDelete_Click);
            // 
            // colApplications
            // 
            this.colApplications.AspectName = "Applications";
            this.colApplications.Text = "Applications";
            // 
            // colTarget
            // 
            this.colTarget.AspectName = "Target";
            this.colTarget.Text = "Taget";
            // 
            // colDeadline
            // 
            this.colDeadline.AspectName = "Deadline";
            this.colDeadline.Text = "Deadline";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 504);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbon2);
            this.Name = "MainForm";
            this.Text = "Event Manager";
            this.tabControl.ResumeLayout(false);
            this.tabCalendar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personList)).EndInit();
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
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private BrightIdeasSoftware.ObjectListView eventList;
        private BrightIdeasSoftware.OLVColumn colName;
        private BrightIdeasSoftware.OLVColumn colLoaction;
        private BrightIdeasSoftware.OLVColumn colDate;
        private BrightIdeasSoftware.OLVColumn colPrice;
        private BrightIdeasSoftware.OLVColumn colCV;
        private BrightIdeasSoftware.OLVColumn colHired;
        private System.Windows.Forms.RibbonPanel panelEvent;
        private System.Windows.Forms.RibbonButton eventAdd;
        private System.Windows.Forms.RibbonButton eventEdit;
        private System.Windows.Forms.RibbonButton eventDelete;
        private System.Windows.Forms.RibbonButton eventInfo;
        private System.Windows.Forms.ImageList listSmallIcons;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton btnPersons;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.ObjectListView personList;
        private BrightIdeasSoftware.OLVColumn colFName;
        private BrightIdeasSoftware.OLVColumn colSName;
        private BrightIdeasSoftware.OLVColumn colCompany;
        private BrightIdeasSoftware.OLVColumn colPhone;
        private BrightIdeasSoftware.OLVColumn colEmail;
        private System.Windows.Forms.RibbonTab ribbonTab5;
        private System.Windows.Forms.Ribbon ribbon2;
        private System.Windows.Forms.RibbonTab rtabCalendar;
        private System.Windows.Forms.RibbonTab etabEvents;
        private System.Windows.Forms.RibbonTab rtabPersons;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonButton ribbonButton8;
        private System.Windows.Forms.RibbonButton ribbonButton9;
        private System.Windows.Forms.RibbonButton ribbonButton10;
        private System.Windows.Forms.RibbonButton ribbonButton11;
        private System.Windows.Forms.RibbonButton personInfo;
        private System.Windows.Forms.RibbonButton personEdit;
        private System.Windows.Forms.RibbonButton personAdd;
        private System.Windows.Forms.RibbonButton personDelete;
        private System.Windows.Forms.RibbonOrbMenuItem itmReload;
        private System.Windows.Forms.RibbonOrbMenuItem itmSettings;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonOrbMenuItem itmExit;
        private System.Windows.Forms.RibbonOrbMenuItem itmAbout;
        private BrightIdeasSoftware.OLVColumn colType;
        private BrightIdeasSoftware.OLVColumn colDeadline;
        private BrightIdeasSoftware.OLVColumn colTarget;
        private BrightIdeasSoftware.OLVColumn colApplications;


    }
}

