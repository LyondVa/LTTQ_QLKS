namespace Hotel.RoomControls
{
    partial class RoomInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lBBookEmployee = new System.Windows.Forms.Label();
            this.lBBookClient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBRoomID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bTUpdate = new System.Windows.Forms.Button();
            this.bTBook = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pBRoomID = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pBBookDate = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pBBookClient = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pBBookEmployee = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cBRoomStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tBNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.dGVService = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pBBookEmployee);
            this.panel1.Controls.Add(this.lBBookEmployee);
            this.panel1.Controls.Add(this.pBBookClient);
            this.panel1.Controls.Add(this.lBBookClient);
            this.panel1.Controls.Add(this.pBBookDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pBRoomID);
            this.panel1.Controls.Add(this.lBRoomID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            // 
            // lBBookEmployee
            // 
            this.lBBookEmployee.AutoSize = true;
            this.lBBookEmployee.Location = new System.Drawing.Point(631, 38);
            this.lBBookEmployee.Name = "lBBookEmployee";
            this.lBBookEmployee.Size = new System.Drawing.Size(91, 16);
            this.lBBookEmployee.TabIndex = 12;
            this.lBBookEmployee.Text = "Tên nhân viên";
            // 
            // lBBookClient
            // 
            this.lBBookClient.AutoSize = true;
            this.lBBookClient.Location = new System.Drawing.Point(437, 38);
            this.lBBookClient.Name = "lBBookClient";
            this.lBBookClient.Size = new System.Drawing.Size(92, 16);
            this.lBBookClient.TabIndex = 11;
            this.lBBookClient.Text = "Tên khách đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày hết hạn đặt";
            // 
            // lBRoomID
            // 
            this.lBRoomID.AutoSize = true;
            this.lBRoomID.Location = new System.Drawing.Point(69, 38);
            this.lBRoomID.Name = "lBRoomID";
            this.lBRoomID.Size = new System.Drawing.Size(68, 16);
            this.lBRoomID.TabIndex = 9;
            this.lBRoomID.Text = "Mã Phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBNote);
            this.panel2.Location = new System.Drawing.Point(452, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 86);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bTUpdate);
            this.panel3.Controls.Add(this.bTBook);
            this.panel3.Controls.Add(this.btExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 58);
            this.panel3.TabIndex = 3;
            // 
            // bTUpdate
            // 
            this.bTUpdate.Location = new System.Drawing.Point(610, 18);
            this.bTUpdate.Name = "bTUpdate";
            this.bTUpdate.Size = new System.Drawing.Size(75, 23);
            this.bTUpdate.TabIndex = 2;
            this.bTUpdate.Text = "Sửa";
            this.bTUpdate.UseVisualStyleBackColor = true;
            // 
            // bTBook
            // 
            this.bTBook.Location = new System.Drawing.Point(516, 18);
            this.bTBook.Name = "bTBook";
            this.bTBook.Size = new System.Drawing.Size(75, 23);
            this.bTBook.TabIndex = 1;
            this.bTBook.Text = "Đặt";
            this.bTBook.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(700, 18);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trạng thái:";
            // 
            // pBRoomID
            // 
            this.pBRoomID.ImageRotate = 0F;
            this.pBRoomID.Location = new System.Drawing.Point(41, 32);
            this.pBRoomID.Name = "pBRoomID";
            this.pBRoomID.Size = new System.Drawing.Size(22, 22);
            this.pBRoomID.TabIndex = 6;
            this.pBRoomID.TabStop = false;
            // 
            // pBBookDate
            // 
            this.pBBookDate.ImageRotate = 0F;
            this.pBBookDate.Location = new System.Drawing.Point(228, 32);
            this.pBBookDate.Name = "pBBookDate";
            this.pBBookDate.Size = new System.Drawing.Size(22, 22);
            this.pBBookDate.TabIndex = 7;
            this.pBBookDate.TabStop = false;
            // 
            // pBBookClient
            // 
            this.pBBookClient.ImageRotate = 0F;
            this.pBBookClient.Location = new System.Drawing.Point(409, 32);
            this.pBBookClient.Name = "pBBookClient";
            this.pBBookClient.Size = new System.Drawing.Size(22, 22);
            this.pBBookClient.TabIndex = 8;
            this.pBBookClient.TabStop = false;
            // 
            // pBBookEmployee
            // 
            this.pBBookEmployee.ImageRotate = 0F;
            this.pBBookEmployee.Location = new System.Drawing.Point(603, 32);
            this.pBBookEmployee.Name = "pBBookEmployee";
            this.pBBookEmployee.Size = new System.Drawing.Size(22, 22);
            this.pBBookEmployee.TabIndex = 9;
            this.pBBookEmployee.TabStop = false;
            // 
            // cBRoomStatus
            // 
            this.cBRoomStatus.BackColor = System.Drawing.Color.Transparent;
            this.cBRoomStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRoomStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBRoomStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cBRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBRoomStatus.ItemHeight = 30;
            this.cBRoomStatus.Location = new System.Drawing.Point(491, 177);
            this.cBRoomStatus.Name = "cBRoomStatus";
            this.cBRoomStatus.Size = new System.Drawing.Size(140, 36);
            this.cBRoomStatus.TabIndex = 6;
            // 
            // tBNote
            // 
            this.tBNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBNote.DefaultText = "";
            this.tBNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tBNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tBNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tBNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBNote.Location = new System.Drawing.Point(121, 4);
            this.tBNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBNote.Name = "tBNote";
            this.tBNote.PasswordChar = '\0';
            this.tBNote.PlaceholderText = "";
            this.tBNote.SelectedText = "";
            this.tBNote.Size = new System.Drawing.Size(137, 78);
            this.tBNote.TabIndex = 0;
            // 
            // dGVService
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGVService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVService.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVService.Location = new System.Drawing.Point(72, 177);
            this.dGVService.Name = "dGVService";
            this.dGVService.RowHeadersVisible = false;
            this.dGVService.RowHeadersWidth = 51;
            this.dGVService.RowTemplate.Height = 24;
            this.dGVService.Size = new System.Drawing.Size(138, 119);
            this.dGVService.TabIndex = 7;
            this.dGVService.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVService.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGVService.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGVService.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGVService.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGVService.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGVService.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVService.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGVService.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVService.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVService.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGVService.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVService.ThemeStyle.HeaderStyle.Height = 4;
            this.dGVService.ThemeStyle.ReadOnly = false;
            this.dGVService.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVService.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVService.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVService.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGVService.ThemeStyle.RowsStyle.Height = 24;
            this.dGVService.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVService.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVService);
            this.Controls.Add(this.cBRoomStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RoomInfo";
            this.Text = "RoomInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lBBookEmployee;
        private System.Windows.Forms.Label lBBookClient;
        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bTUpdate;
        private System.Windows.Forms.Button bTBook;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox pBBookEmployee;
        private Guna.UI2.WinForms.Guna2PictureBox pBBookClient;
        private Guna.UI2.WinForms.Guna2PictureBox pBBookDate;
        private Guna.UI2.WinForms.Guna2PictureBox pBRoomID;
        private Guna.UI2.WinForms.Guna2TextBox tBNote;
        private Guna.UI2.WinForms.Guna2ComboBox cBRoomStatus;
        private Guna.UI2.WinForms.Guna2DataGridView dGVService;
    }
}