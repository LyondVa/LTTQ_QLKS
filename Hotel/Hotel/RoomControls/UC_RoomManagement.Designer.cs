namespace Hotel.All_user_control
{
    partial class UC_RoomManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RoomManagement));
            this.tBSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dGVRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bTAdd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.Color.Transparent;
            this.tBSearch.BorderRadius = 30;
            this.tBSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBSearch.DefaultText = "";
            this.tBSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tBSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tBSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tBSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBSearch.Location = new System.Drawing.Point(30, 170);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.PasswordChar = '\0';
            this.tBSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tBSearch.PlaceholderText = "Nhập Mã Phòng";
            this.tBSearch.SelectedText = "";
            this.tBSearch.Size = new System.Drawing.Size(340, 40);
            this.tBSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tBSearch.TabIndex = 2;
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            // 
            // dGVRoom
            // 
            this.dGVRoom.AllowUserToAddRows = false;
            this.dGVRoom.AllowUserToDeleteRows = false;
            this.dGVRoom.AllowUserToResizeColumns = false;
            this.dGVRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dGVRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVRoom.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dGVRoom.Location = new System.Drawing.Point(30, 250);
            this.dGVRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVRoom.Name = "dGVRoom";
            this.dGVRoom.ReadOnly = true;
            this.dGVRoom.RowHeadersVisible = false;
            this.dGVRoom.RowHeadersWidth = 60;
            this.dGVRoom.RowTemplate.Height = 24;
            this.dGVRoom.Size = new System.Drawing.Size(740, 250);
            this.dGVRoom.TabIndex = 4;
            this.dGVRoom.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dGVRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dGVRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVRoom.ThemeStyle.HeaderStyle.Height = 35;
            this.dGVRoom.ThemeStyle.ReadOnly = true;
            this.dGVRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dGVRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dGVRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dGVRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dGVRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dGVRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVRoom_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách phòng";
            // 
            // bTAdd
            // 
            this.bTAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTAdd.BackColor = System.Drawing.Color.Transparent;
            this.bTAdd.BorderRadius = 10;
            this.bTAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bTAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bTAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bTAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bTAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.bTAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.bTAdd.ForeColor = System.Drawing.Color.White;
            this.bTAdd.Location = new System.Drawing.Point(590, 510);
            this.bTAdd.Name = "bTAdd";
            this.bTAdd.Size = new System.Drawing.Size(180, 45);
            this.bTAdd.TabIndex = 8;
            this.bTAdd.Text = "Thêm Phòng";
            this.bTAdd.Visible = false;
            this.bTAdd.Click += new System.EventHandler(this.bTAdd_Click);
            // 
            // UC_RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bTAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.dGVRoom);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_RoomManagement";
            this.Size = new System.Drawing.Size(800, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dGVRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dGVRoom;
        private Guna.UI2.WinForms.Guna2TextBox tBSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button bTAdd;
    }
}
