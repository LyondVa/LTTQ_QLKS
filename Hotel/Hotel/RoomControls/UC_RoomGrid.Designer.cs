﻿namespace Hotel.RoomControls
{
    partial class UC_RoomGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RoomGrid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBTime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dTPFilter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gBCleanStatusFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rBTCleanStatusAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTUnclean = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTClean = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gBRoomTypeFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rBTRoomTypeAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTEconomy = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTStandard = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTDeluxed = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTVIP = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gBRoomStatusFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rBTRoomStatusAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTMaintenance = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTOccupied = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTEmpty = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBTBooked = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tLPFloors = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fLPFloor4 = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPFloor1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPFloor2 = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPFloor3 = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPFloor5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gBCleanStatusFilter.SuspendLayout();
            this.gBRoomTypeFilter.SuspendLayout();
            this.gBRoomStatusFilter.SuspendLayout();
            this.tLPFloors.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cBTime);
            this.panel1.Controls.Add(this.dTPFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cBTime
            // 
            this.cBTime.BackColor = System.Drawing.Color.Transparent;
            this.cBTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cBTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBTime.ForeColor = System.Drawing.Color.Black;
            this.cBTime.ItemHeight = 30;
            this.cBTime.Items.AddRange(new object[] {
            "Trước 12:00",
            "Sau 14:00"});
            this.cBTime.Location = new System.Drawing.Point(347, 32);
            this.cBTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBTime.Name = "cBTime";
            this.cBTime.Size = new System.Drawing.Size(156, 36);
            this.cBTime.StartIndex = 1;
            this.cBTime.TabIndex = 7;
            this.cBTime.SelectedIndexChanged += new System.EventHandler(this.cBTime_SelectedIndexChanged);
            // 
            // dTPFilter
            // 
            this.dTPFilter.Checked = true;
            this.dTPFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dTPFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dTPFilter.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dTPFilter.Location = new System.Drawing.Point(39, 32);
            this.dTPFilter.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dTPFilter.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dTPFilter.Name = "dTPFilter";
            this.dTPFilter.Size = new System.Drawing.Size(278, 44);
            this.dTPFilter.TabIndex = 6;
            this.dTPFilter.Value = new System.DateTime(2023, 12, 14, 20, 51, 54, 957);
            this.dTPFilter.ValueChanged += new System.EventHandler(this.dTPFilter_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gBCleanStatusFilter);
            this.panel2.Controls.Add(this.gBRoomTypeFilter);
            this.panel2.Controls.Add(this.gBRoomStatusFilter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 581);
            this.panel2.TabIndex = 1;
            // 
            // gBCleanStatusFilter
            // 
            this.gBCleanStatusFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.gBCleanStatusFilter.BorderThickness = 5;
            this.gBCleanStatusFilter.Controls.Add(this.rBTCleanStatusAll);
            this.gBCleanStatusFilter.Controls.Add(this.rBTUnclean);
            this.gBCleanStatusFilter.Controls.Add(this.rBTClean);
            this.gBCleanStatusFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.gBCleanStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBCleanStatusFilter.ForeColor = System.Drawing.Color.White;
            this.gBCleanStatusFilter.Location = new System.Drawing.Point(29, 450);
            this.gBCleanStatusFilter.Name = "gBCleanStatusFilter";
            this.gBCleanStatusFilter.Size = new System.Drawing.Size(211, 214);
            this.gBCleanStatusFilter.TabIndex = 4;
            this.gBCleanStatusFilter.Text = "Dọn dẹp";
            // 
            // rBTCleanStatusAll
            // 
            this.rBTCleanStatusAll.AutoSize = true;
            this.rBTCleanStatusAll.Checked = true;
            this.rBTCleanStatusAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTCleanStatusAll.CheckedState.BorderThickness = 0;
            this.rBTCleanStatusAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTCleanStatusAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTCleanStatusAll.CheckedState.InnerOffset = -4;
            this.rBTCleanStatusAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTCleanStatusAll.ForeColor = System.Drawing.Color.Black;
            this.rBTCleanStatusAll.Location = new System.Drawing.Point(12, 114);
            this.rBTCleanStatusAll.Name = "rBTCleanStatusAll";
            this.rBTCleanStatusAll.Size = new System.Drawing.Size(143, 24);
            this.rBTCleanStatusAll.TabIndex = 6;
            this.rBTCleanStatusAll.TabStop = true;
            this.rBTCleanStatusAll.Text = "Tất cả các phòng";
            this.rBTCleanStatusAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTCleanStatusAll.UncheckedState.BorderThickness = 2;
            this.rBTCleanStatusAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTCleanStatusAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTCleanStatusAll.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTUnclean
            // 
            this.rBTUnclean.AutoSize = true;
            this.rBTUnclean.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTUnclean.CheckedState.BorderThickness = 0;
            this.rBTUnclean.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTUnclean.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTUnclean.CheckedState.InnerOffset = -4;
            this.rBTUnclean.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTUnclean.ForeColor = System.Drawing.Color.Black;
            this.rBTUnclean.Location = new System.Drawing.Point(12, 84);
            this.rBTUnclean.Name = "rBTUnclean";
            this.rBTUnclean.Size = new System.Drawing.Size(138, 24);
            this.rBTUnclean.TabIndex = 5;
            this.rBTUnclean.Text = "Phòng chưa dọn";
            this.rBTUnclean.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTUnclean.UncheckedState.BorderThickness = 2;
            this.rBTUnclean.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTUnclean.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTUnclean.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTClean
            // 
            this.rBTClean.AutoSize = true;
            this.rBTClean.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTClean.CheckedState.BorderThickness = 0;
            this.rBTClean.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTClean.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTClean.CheckedState.InnerOffset = -4;
            this.rBTClean.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTClean.ForeColor = System.Drawing.Color.Black;
            this.rBTClean.Location = new System.Drawing.Point(12, 54);
            this.rBTClean.Name = "rBTClean";
            this.rBTClean.Size = new System.Drawing.Size(123, 24);
            this.rBTClean.TabIndex = 4;
            this.rBTClean.Text = "Phòng đã dọn";
            this.rBTClean.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTClean.UncheckedState.BorderThickness = 2;
            this.rBTClean.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTClean.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTClean.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // gBRoomTypeFilter
            // 
            this.gBRoomTypeFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.gBRoomTypeFilter.BorderThickness = 5;
            this.gBRoomTypeFilter.Controls.Add(this.rBTRoomTypeAll);
            this.gBRoomTypeFilter.Controls.Add(this.rBTEconomy);
            this.gBRoomTypeFilter.Controls.Add(this.rBTStandard);
            this.gBRoomTypeFilter.Controls.Add(this.rBTDeluxed);
            this.gBRoomTypeFilter.Controls.Add(this.rBTVIP);
            this.gBRoomTypeFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.gBRoomTypeFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBRoomTypeFilter.ForeColor = System.Drawing.Color.White;
            this.gBRoomTypeFilter.Location = new System.Drawing.Point(29, 229);
            this.gBRoomTypeFilter.Name = "gBRoomTypeFilter";
            this.gBRoomTypeFilter.Size = new System.Drawing.Size(211, 214);
            this.gBRoomTypeFilter.TabIndex = 3;
            this.gBRoomTypeFilter.Text = "Loại phòng";
            // 
            // rBTRoomTypeAll
            // 
            this.rBTRoomTypeAll.AutoSize = true;
            this.rBTRoomTypeAll.Checked = true;
            this.rBTRoomTypeAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTRoomTypeAll.CheckedState.BorderThickness = 0;
            this.rBTRoomTypeAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTRoomTypeAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTRoomTypeAll.CheckedState.InnerOffset = -4;
            this.rBTRoomTypeAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTRoomTypeAll.ForeColor = System.Drawing.Color.Black;
            this.rBTRoomTypeAll.Location = new System.Drawing.Point(12, 172);
            this.rBTRoomTypeAll.Name = "rBTRoomTypeAll";
            this.rBTRoomTypeAll.Size = new System.Drawing.Size(143, 24);
            this.rBTRoomTypeAll.TabIndex = 7;
            this.rBTRoomTypeAll.TabStop = true;
            this.rBTRoomTypeAll.Text = "Tất cả các phòng";
            this.rBTRoomTypeAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTRoomTypeAll.UncheckedState.BorderThickness = 2;
            this.rBTRoomTypeAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTRoomTypeAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTRoomTypeAll.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTEconomy
            // 
            this.rBTEconomy.AutoSize = true;
            this.rBTEconomy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTEconomy.CheckedState.BorderThickness = 0;
            this.rBTEconomy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTEconomy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTEconomy.CheckedState.InnerOffset = -4;
            this.rBTEconomy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTEconomy.ForeColor = System.Drawing.Color.Black;
            this.rBTEconomy.Location = new System.Drawing.Point(12, 142);
            this.rBTEconomy.Name = "rBTEconomy";
            this.rBTEconomy.Size = new System.Drawing.Size(137, 24);
            this.rBTEconomy.TabIndex = 6;
            this.rBTEconomy.Text = "Phòng Economy";
            this.rBTEconomy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTEconomy.UncheckedState.BorderThickness = 2;
            this.rBTEconomy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTEconomy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTEconomy.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTStandard
            // 
            this.rBTStandard.AutoSize = true;
            this.rBTStandard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTStandard.CheckedState.BorderThickness = 0;
            this.rBTStandard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTStandard.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTStandard.CheckedState.InnerOffset = -4;
            this.rBTStandard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTStandard.ForeColor = System.Drawing.Color.Black;
            this.rBTStandard.Location = new System.Drawing.Point(12, 112);
            this.rBTStandard.Name = "rBTStandard";
            this.rBTStandard.Size = new System.Drawing.Size(136, 24);
            this.rBTStandard.TabIndex = 5;
            this.rBTStandard.Text = "Phòng Standard";
            this.rBTStandard.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTStandard.UncheckedState.BorderThickness = 2;
            this.rBTStandard.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTStandard.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTStandard.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTDeluxed
            // 
            this.rBTDeluxed.AutoSize = true;
            this.rBTDeluxed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTDeluxed.CheckedState.BorderThickness = 0;
            this.rBTDeluxed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTDeluxed.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTDeluxed.CheckedState.InnerOffset = -4;
            this.rBTDeluxed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTDeluxed.ForeColor = System.Drawing.Color.Black;
            this.rBTDeluxed.Location = new System.Drawing.Point(12, 82);
            this.rBTDeluxed.Name = "rBTDeluxed";
            this.rBTDeluxed.Size = new System.Drawing.Size(131, 24);
            this.rBTDeluxed.TabIndex = 4;
            this.rBTDeluxed.Text = "Phòng Deluxed";
            this.rBTDeluxed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTDeluxed.UncheckedState.BorderThickness = 2;
            this.rBTDeluxed.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTDeluxed.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTDeluxed.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTVIP
            // 
            this.rBTVIP.AutoSize = true;
            this.rBTVIP.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTVIP.CheckedState.BorderThickness = 0;
            this.rBTVIP.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTVIP.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTVIP.CheckedState.InnerOffset = -4;
            this.rBTVIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTVIP.ForeColor = System.Drawing.Color.Black;
            this.rBTVIP.Location = new System.Drawing.Point(12, 52);
            this.rBTVIP.Name = "rBTVIP";
            this.rBTVIP.Size = new System.Drawing.Size(97, 24);
            this.rBTVIP.TabIndex = 3;
            this.rBTVIP.Text = "Phòng VIP";
            this.rBTVIP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTVIP.UncheckedState.BorderThickness = 2;
            this.rBTVIP.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTVIP.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTVIP.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // gBRoomStatusFilter
            // 
            this.gBRoomStatusFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.gBRoomStatusFilter.BorderThickness = 5;
            this.gBRoomStatusFilter.Controls.Add(this.rBTRoomStatusAll);
            this.gBRoomStatusFilter.Controls.Add(this.rBTMaintenance);
            this.gBRoomStatusFilter.Controls.Add(this.rBTOccupied);
            this.gBRoomStatusFilter.Controls.Add(this.rBTEmpty);
            this.gBRoomStatusFilter.Controls.Add(this.rBTBooked);
            this.gBRoomStatusFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.gBRoomStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBRoomStatusFilter.ForeColor = System.Drawing.Color.White;
            this.gBRoomStatusFilter.Location = new System.Drawing.Point(29, 6);
            this.gBRoomStatusFilter.Name = "gBRoomStatusFilter";
            this.gBRoomStatusFilter.Size = new System.Drawing.Size(211, 217);
            this.gBRoomStatusFilter.TabIndex = 2;
            this.gBRoomStatusFilter.Text = "Trạng Thái Phòng";
            // 
            // rBTRoomStatusAll
            // 
            this.rBTRoomStatusAll.AutoSize = true;
            this.rBTRoomStatusAll.Checked = true;
            this.rBTRoomStatusAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTRoomStatusAll.CheckedState.BorderThickness = 0;
            this.rBTRoomStatusAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTRoomStatusAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTRoomStatusAll.CheckedState.InnerOffset = -4;
            this.rBTRoomStatusAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTRoomStatusAll.ForeColor = System.Drawing.Color.Black;
            this.rBTRoomStatusAll.Location = new System.Drawing.Point(12, 174);
            this.rBTRoomStatusAll.Name = "rBTRoomStatusAll";
            this.rBTRoomStatusAll.Size = new System.Drawing.Size(143, 24);
            this.rBTRoomStatusAll.TabIndex = 4;
            this.rBTRoomStatusAll.TabStop = true;
            this.rBTRoomStatusAll.Text = "Tất cả các phòng";
            this.rBTRoomStatusAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTRoomStatusAll.UncheckedState.BorderThickness = 2;
            this.rBTRoomStatusAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTRoomStatusAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTRoomStatusAll.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTMaintenance
            // 
            this.rBTMaintenance.AutoSize = true;
            this.rBTMaintenance.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTMaintenance.CheckedState.BorderThickness = 0;
            this.rBTMaintenance.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTMaintenance.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTMaintenance.CheckedState.InnerOffset = -4;
            this.rBTMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTMaintenance.ForeColor = System.Drawing.Color.Black;
            this.rBTMaintenance.Location = new System.Drawing.Point(12, 144);
            this.rBTMaintenance.Name = "rBTMaintenance";
            this.rBTMaintenance.Size = new System.Drawing.Size(173, 24);
            this.rBTMaintenance.TabIndex = 1;
            this.rBTMaintenance.Text = "Phòng đang sửa chữa";
            this.rBTMaintenance.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTMaintenance.UncheckedState.BorderThickness = 2;
            this.rBTMaintenance.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTMaintenance.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTMaintenance.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTOccupied
            // 
            this.rBTOccupied.AutoSize = true;
            this.rBTOccupied.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTOccupied.CheckedState.BorderThickness = 0;
            this.rBTOccupied.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTOccupied.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTOccupied.CheckedState.InnerOffset = -4;
            this.rBTOccupied.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTOccupied.ForeColor = System.Drawing.Color.Black;
            this.rBTOccupied.Location = new System.Drawing.Point(12, 114);
            this.rBTOccupied.Name = "rBTOccupied";
            this.rBTOccupied.Size = new System.Drawing.Size(143, 24);
            this.rBTOccupied.TabIndex = 3;
            this.rBTOccupied.Text = "Phòng đang thuê";
            this.rBTOccupied.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTOccupied.UncheckedState.BorderThickness = 2;
            this.rBTOccupied.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTOccupied.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTOccupied.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTEmpty
            // 
            this.rBTEmpty.AutoSize = true;
            this.rBTEmpty.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTEmpty.CheckedState.BorderThickness = 0;
            this.rBTEmpty.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTEmpty.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTEmpty.CheckedState.InnerOffset = -4;
            this.rBTEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTEmpty.ForeColor = System.Drawing.Color.Black;
            this.rBTEmpty.Location = new System.Drawing.Point(12, 54);
            this.rBTEmpty.Name = "rBTEmpty";
            this.rBTEmpty.Size = new System.Drawing.Size(112, 24);
            this.rBTEmpty.TabIndex = 2;
            this.rBTEmpty.Text = "Phòng trống";
            this.rBTEmpty.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTEmpty.UncheckedState.BorderThickness = 2;
            this.rBTEmpty.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTEmpty.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTEmpty.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // rBTBooked
            // 
            this.rBTBooked.AutoSize = true;
            this.rBTBooked.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTBooked.CheckedState.BorderThickness = 0;
            this.rBTBooked.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBTBooked.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBTBooked.CheckedState.InnerOffset = -4;
            this.rBTBooked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTBooked.ForeColor = System.Drawing.Color.Black;
            this.rBTBooked.Location = new System.Drawing.Point(12, 84);
            this.rBTBooked.Name = "rBTBooked";
            this.rBTBooked.Size = new System.Drawing.Size(119, 24);
            this.rBTBooked.TabIndex = 0;
            this.rBTBooked.Text = "Phòng đã đặt";
            this.rBTBooked.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBTBooked.UncheckedState.BorderThickness = 2;
            this.rBTBooked.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBTBooked.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBTBooked.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // tLPFloors
            // 
            this.tLPFloors.AutoSize = true;
            this.tLPFloors.BackColor = System.Drawing.Color.Transparent;
            this.tLPFloors.ColumnCount = 1;
            this.tLPFloors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPFloors.Controls.Add(this.label5, 0, 8);
            this.tLPFloors.Controls.Add(this.label4, 0, 6);
            this.tLPFloors.Controls.Add(this.label3, 0, 4);
            this.tLPFloors.Controls.Add(this.fLPFloor4, 0, 7);
            this.tLPFloors.Controls.Add(this.fLPFloor1, 0, 1);
            this.tLPFloors.Controls.Add(this.fLPFloor2, 0, 3);
            this.tLPFloors.Controls.Add(this.fLPFloor3, 0, 5);
            this.tLPFloors.Controls.Add(this.fLPFloor5, 0, 9);
            this.tLPFloors.Controls.Add(this.label1, 0, 0);
            this.tLPFloors.Controls.Add(this.label2, 0, 2);
            this.tLPFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPFloors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLPFloors.ForeColor = System.Drawing.Color.White;
            this.tLPFloors.Location = new System.Drawing.Point(245, 100);
            this.tLPFloors.Name = "tLPFloors";
            this.tLPFloors.RowCount = 10;
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPFloors.Size = new System.Drawing.Size(798, 581);
            this.tLPFloors.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tầng 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tầng 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tầng 3";
            // 
            // fLPFloor4
            // 
            this.fLPFloor4.AutoSize = true;
            this.fLPFloor4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPFloor4.Location = new System.Drawing.Point(3, 113);
            this.fLPFloor4.Name = "fLPFloor4";
            this.fLPFloor4.Size = new System.Drawing.Size(792, 1);
            this.fLPFloor4.TabIndex = 4;
            this.fLPFloor4.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelControlAdd);
            // 
            // fLPFloor1
            // 
            this.fLPFloor1.AutoSize = true;
            this.fLPFloor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPFloor1.Location = new System.Drawing.Point(3, 26);
            this.fLPFloor1.Name = "fLPFloor1";
            this.fLPFloor1.Size = new System.Drawing.Size(792, 1);
            this.fLPFloor1.TabIndex = 0;
            this.fLPFloor1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelControlAdd);
            // 
            // fLPFloor2
            // 
            this.fLPFloor2.AutoSize = true;
            this.fLPFloor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPFloor2.Location = new System.Drawing.Point(3, 55);
            this.fLPFloor2.Name = "fLPFloor2";
            this.fLPFloor2.Size = new System.Drawing.Size(792, 1);
            this.fLPFloor2.TabIndex = 1;
            this.fLPFloor2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelControlAdd);
            // 
            // fLPFloor3
            // 
            this.fLPFloor3.AutoSize = true;
            this.fLPFloor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPFloor3.Location = new System.Drawing.Point(3, 84);
            this.fLPFloor3.Name = "fLPFloor3";
            this.fLPFloor3.Size = new System.Drawing.Size(792, 1);
            this.fLPFloor3.TabIndex = 2;
            this.fLPFloor3.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelControlAdd);
            // 
            // fLPFloor5
            // 
            this.fLPFloor5.AutoScroll = true;
            this.fLPFloor5.AutoSize = true;
            this.fLPFloor5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPFloor5.Location = new System.Drawing.Point(3, 142);
            this.fLPFloor5.Name = "fLPFloor5";
            this.fLPFloor5.Size = new System.Drawing.Size(792, 436);
            this.fLPFloor5.TabIndex = 3;
            this.fLPFloor5.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelControlAdd);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tầng 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tầng 2";
            // 
            // UC_RoomGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tLPFloors);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_RoomGrid";
            this.Size = new System.Drawing.Size(1043, 681);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gBCleanStatusFilter.ResumeLayout(false);
            this.gBCleanStatusFilter.PerformLayout();
            this.gBRoomTypeFilter.ResumeLayout(false);
            this.gBRoomTypeFilter.PerformLayout();
            this.gBRoomStatusFilter.ResumeLayout(false);
            this.gBRoomStatusFilter.PerformLayout();
            this.tLPFloors.ResumeLayout(false);
            this.tLPFloors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GroupBox gBRoomStatusFilter;
        private Guna.UI2.WinForms.Guna2GroupBox gBRoomTypeFilter;
        private System.Windows.Forms.TableLayoutPanel tLPFloors;
        private System.Windows.Forms.FlowLayoutPanel fLPFloor4;
        private System.Windows.Forms.FlowLayoutPanel fLPFloor1;
        private System.Windows.Forms.FlowLayoutPanel fLPFloor2;
        private System.Windows.Forms.FlowLayoutPanel fLPFloor3;
        private System.Windows.Forms.FlowLayoutPanel fLPFloor5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2RadioButton rBTEmpty;
        private Guna.UI2.WinForms.Guna2RadioButton rBTMaintenance;
        private Guna.UI2.WinForms.Guna2RadioButton rBTBooked;
        private Guna.UI2.WinForms.Guna2RadioButton rBTOccupied;
        private Guna.UI2.WinForms.Guna2RadioButton rBTEconomy;
        private Guna.UI2.WinForms.Guna2RadioButton rBTStandard;
        private Guna.UI2.WinForms.Guna2RadioButton rBTDeluxed;
        private Guna.UI2.WinForms.Guna2RadioButton rBTVIP;
        private Guna.UI2.WinForms.Guna2GroupBox gBCleanStatusFilter;
        private Guna.UI2.WinForms.Guna2RadioButton rBTUnclean;
        private Guna.UI2.WinForms.Guna2RadioButton rBTClean;
        private Guna.UI2.WinForms.Guna2RadioButton rBTCleanStatusAll;
        private Guna.UI2.WinForms.Guna2RadioButton rBTRoomTypeAll;
        private Guna.UI2.WinForms.Guna2RadioButton rBTRoomStatusAll;
        private Guna.UI2.WinForms.Guna2DateTimePicker dTPFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cBTime;
    }
}
