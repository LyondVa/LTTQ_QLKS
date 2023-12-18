namespace Hotel.RoomControls
{
    partial class F_BookRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bTExit = new Guna.UI2.WinForms.Guna2Button();
            this.dTPCheckInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dTPCheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bTAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bTClientRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.dGVAvailableRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dGVSelectedRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tBClientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAvailableRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSelectedRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // bTExit
            // 
            this.bTExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bTExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bTExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bTExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bTExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bTExit.ForeColor = System.Drawing.Color.White;
            this.bTExit.Location = new System.Drawing.Point(384, 355);
            this.bTExit.Name = "bTExit";
            this.bTExit.Size = new System.Drawing.Size(184, 45);
            this.bTExit.TabIndex = 0;
            this.bTExit.Text = "Thoát";
            this.bTExit.Click += new System.EventHandler(this.bTExit_Click);
            // 
            // dTPCheckInDate
            // 
            this.dTPCheckInDate.Checked = true;
            this.dTPCheckInDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dTPCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dTPCheckInDate.Location = new System.Drawing.Point(336, 47);
            this.dTPCheckInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dTPCheckInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dTPCheckInDate.Name = "dTPCheckInDate";
            this.dTPCheckInDate.Size = new System.Drawing.Size(193, 48);
            this.dTPCheckInDate.TabIndex = 3;
            this.dTPCheckInDate.Value = new System.DateTime(2023, 12, 12, 9, 3, 55, 546);
            this.dTPCheckInDate.ValueChanged += new System.EventHandler(this.dTPCheckInDate_ValueChanged);
            // 
            // dTPCheckOutDate
            // 
            this.dTPCheckOutDate.Checked = true;
            this.dTPCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dTPCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dTPCheckOutDate.Location = new System.Drawing.Point(336, 131);
            this.dTPCheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dTPCheckOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dTPCheckOutDate.Name = "dTPCheckOutDate";
            this.dTPCheckOutDate.Size = new System.Drawing.Size(193, 48);
            this.dTPCheckOutDate.TabIndex = 4;
            this.dTPCheckOutDate.Value = new System.DateTime(2023, 12, 12, 9, 3, 55, 546);
            this.dTPCheckOutDate.ValueChanged += new System.EventHandler(this.dTPCheckOutDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày nhận phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày trả phòng:";
            // 
            // bTAdd
            // 
            this.bTAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bTAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bTAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bTAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bTAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bTAdd.ForeColor = System.Drawing.Color.White;
            this.bTAdd.Location = new System.Drawing.Point(195, 355);
            this.bTAdd.Name = "bTAdd";
            this.bTAdd.Size = new System.Drawing.Size(183, 45);
            this.bTAdd.TabIndex = 1;
            this.bTAdd.Text = "Thêm";
            this.bTAdd.Click += new System.EventHandler(this.bTAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phòng đang trống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phòng đã chọn";
            // 
            // tBClientID
            // 
            this.tBClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBClientID.DefaultText = "";
            this.tBClientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tBClientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tBClientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBClientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBClientID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tBClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBClientID.Location = new System.Drawing.Point(15, 48);
            this.tBClientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBClientID.Name = "tBClientID";
            this.tBClientID.PasswordChar = '\0';
            this.tBClientID.PlaceholderText = "";
            this.tBClientID.SelectedText = "";
            this.tBClientID.Size = new System.Drawing.Size(229, 48);
            this.tBClientID.TabIndex = 11;
            this.tBClientID.TextChanged += new System.EventHandler(this.tBClientID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "CCCD:";
            // 
            // bTClientRegistration
            // 
            this.bTClientRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bTClientRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bTClientRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bTClientRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bTClientRegistration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bTClientRegistration.ForeColor = System.Drawing.Color.White;
            this.bTClientRegistration.Location = new System.Drawing.Point(12, 355);
            this.bTClientRegistration.Name = "bTClientRegistration";
            this.bTClientRegistration.Size = new System.Drawing.Size(177, 48);
            this.bTClientRegistration.TabIndex = 13;
            this.bTClientRegistration.Text = "Đăng ký khách hàng";
            this.bTClientRegistration.Click += new System.EventHandler(this.bTClientRegistration_Click);
            // 
            // dGVAvailableRoom
            // 
            this.dGVAvailableRoom.AllowUserToAddRows = false;
            this.dGVAvailableRoom.AllowUserToDeleteRows = false;
            this.dGVAvailableRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGVAvailableRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVAvailableRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVAvailableRoom.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVAvailableRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVAvailableRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVAvailableRoom.Location = new System.Drawing.Point(12, 238);
            this.dGVAvailableRoom.Name = "dGVAvailableRoom";
            this.dGVAvailableRoom.RowHeadersVisible = false;
            this.dGVAvailableRoom.RowHeadersWidth = 51;
            this.dGVAvailableRoom.RowTemplate.Height = 24;
            this.dGVAvailableRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVAvailableRoom.Size = new System.Drawing.Size(275, 111);
            this.dGVAvailableRoom.TabIndex = 15;
            this.dGVAvailableRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVAvailableRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGVAvailableRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGVAvailableRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGVAvailableRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGVAvailableRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGVAvailableRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVAvailableRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGVAvailableRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVAvailableRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVAvailableRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGVAvailableRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVAvailableRoom.ThemeStyle.HeaderStyle.Height = 20;
            this.dGVAvailableRoom.ThemeStyle.ReadOnly = false;
            this.dGVAvailableRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVAvailableRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVAvailableRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVAvailableRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGVAvailableRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dGVAvailableRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVAvailableRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGVAvailableRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAvailableRoom_CellContentClick);
            // 
            // dGVSelectedRoom
            // 
            this.dGVSelectedRoom.AllowUserToAddRows = false;
            this.dGVSelectedRoom.AllowUserToDeleteRows = false;
            this.dGVSelectedRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dGVSelectedRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVSelectedRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVSelectedRoom.ColumnHeadersHeight = 20;
            this.dGVSelectedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVSelectedRoom.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGVSelectedRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVSelectedRoom.Location = new System.Drawing.Point(293, 238);
            this.dGVSelectedRoom.Name = "dGVSelectedRoom";
            this.dGVSelectedRoom.RowHeadersVisible = false;
            this.dGVSelectedRoom.RowHeadersWidth = 51;
            this.dGVSelectedRoom.RowTemplate.Height = 24;
            this.dGVSelectedRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVSelectedRoom.Size = new System.Drawing.Size(275, 111);
            this.dGVSelectedRoom.TabIndex = 16;
            this.dGVSelectedRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVSelectedRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGVSelectedRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGVSelectedRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGVSelectedRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGVSelectedRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGVSelectedRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVSelectedRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGVSelectedRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVSelectedRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVSelectedRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGVSelectedRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGVSelectedRoom.ThemeStyle.HeaderStyle.Height = 20;
            this.dGVSelectedRoom.ThemeStyle.ReadOnly = false;
            this.dGVSelectedRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVSelectedRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVSelectedRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVSelectedRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGVSelectedRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dGVSelectedRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVSelectedRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGVSelectedRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSelectedRoom_CellContentClick);
            // 
            // tBClientName
            // 
            this.tBClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBClientName.DefaultText = "";
            this.tBClientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tBClientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tBClientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBClientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBClientName.Enabled = false;
            this.tBClientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBClientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tBClientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBClientName.Location = new System.Drawing.Point(15, 131);
            this.tBClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBClientName.Name = "tBClientName";
            this.tBClientName.PasswordChar = '\0';
            this.tBClientName.PlaceholderText = "";
            this.tBClientName.ReadOnly = true;
            this.tBClientName.SelectedText = "";
            this.tBClientName.Size = new System.Drawing.Size(229, 48);
            this.tBClientName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên Khách hàng:";
            // 
            // F_BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(580, 416);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBClientName);
            this.Controls.Add(this.dGVSelectedRoom);
            this.Controls.Add(this.dGVAvailableRoom);
            this.Controls.Add(this.bTClientRegistration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBClientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTExit);
            this.Controls.Add(this.dTPCheckOutDate);
            this.Controls.Add(this.dTPCheckInDate);
            this.Controls.Add(this.bTAdd);
            this.Name = "F_BookRoom";
            this.Text = "BookRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dGVAvailableRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSelectedRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bTExit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dTPCheckInDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dTPCheckOutDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button bTAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tBClientID;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button bTClientRegistration;
        private Guna.UI2.WinForms.Guna2DataGridView dGVAvailableRoom;
        private Guna.UI2.WinForms.Guna2DataGridView dGVSelectedRoom;
        private Guna.UI2.WinForms.Guna2TextBox tBClientName;
        private System.Windows.Forms.Label label6;
    }
}