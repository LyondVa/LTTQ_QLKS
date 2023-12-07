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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGVService = new System.Windows.Forms.DataGridView();
            this.pBRoomID = new System.Windows.Forms.PictureBox();
            this.pBBookDate = new System.Windows.Forms.PictureBox();
            this.pBBookClient = new System.Windows.Forms.PictureBox();
            this.pBBookEmployee = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBNote = new System.Windows.Forms.TextBox();
            this.lBRoomID = new System.Windows.Forms.Label();
            this.lBBookClient = new System.Windows.Forms.Label();
            this.lBBookEmployee = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dUDRoomStatus = new System.Windows.Forms.DomainUpDown();
            this.btExit = new System.Windows.Forms.Button();
            this.bTBook = new System.Windows.Forms.Button();
            this.bTUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lBBookEmployee);
            this.panel1.Controls.Add(this.lBBookClient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lBRoomID);
            this.panel1.Controls.Add(this.pBBookEmployee);
            this.panel1.Controls.Add(this.pBBookClient);
            this.panel1.Controls.Add(this.pBBookDate);
            this.panel1.Controls.Add(this.pBRoomID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            // 
            // dGVService
            // 
            this.dGVService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVService.Location = new System.Drawing.Point(60, 146);
            this.dGVService.Name = "dGVService";
            this.dGVService.RowHeadersWidth = 51;
            this.dGVService.RowTemplate.Height = 24;
            this.dGVService.Size = new System.Drawing.Size(240, 150);
            this.dGVService.TabIndex = 1;
            // 
            // pBRoomID
            // 
            this.pBRoomID.Location = new System.Drawing.Point(31, 32);
            this.pBRoomID.Name = "pBRoomID";
            this.pBRoomID.Size = new System.Drawing.Size(22, 22);
            this.pBRoomID.TabIndex = 2;
            this.pBRoomID.TabStop = false;
            // 
            // pBBookDate
            // 
            this.pBBookDate.Location = new System.Drawing.Point(213, 32);
            this.pBBookDate.Name = "pBBookDate";
            this.pBBookDate.Size = new System.Drawing.Size(22, 22);
            this.pBBookDate.TabIndex = 4;
            this.pBBookDate.TabStop = false;
            // 
            // pBBookClient
            // 
            this.pBBookClient.BackColor = System.Drawing.SystemColors.Control;
            this.pBBookClient.Location = new System.Drawing.Point(392, 32);
            this.pBBookClient.Name = "pBBookClient";
            this.pBBookClient.Size = new System.Drawing.Size(22, 22);
            this.pBBookClient.TabIndex = 6;
            this.pBBookClient.TabStop = false;
            // 
            // pBBookEmployee
            // 
            this.pBBookEmployee.Location = new System.Drawing.Point(585, 32);
            this.pBBookEmployee.Name = "pBBookEmployee";
            this.pBBookEmployee.Size = new System.Drawing.Size(22, 22);
            this.pBBookEmployee.TabIndex = 8;
            this.pBBookEmployee.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBNote);
            this.panel2.Location = new System.Drawing.Point(452, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 86);
            this.panel2.TabIndex = 2;
            // 
            // tBNote
            // 
            this.tBNote.Location = new System.Drawing.Point(133, 19);
            this.tBNote.Multiline = true;
            this.tBNote.Name = "tBNote";
            this.tBNote.Size = new System.Drawing.Size(100, 48);
            this.tBNote.TabIndex = 0;
            this.tBNote.Text = "Ghi chú";
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
            // lBBookClient
            // 
            this.lBBookClient.AutoSize = true;
            this.lBBookClient.Location = new System.Drawing.Point(437, 38);
            this.lBBookClient.Name = "lBBookClient";
            this.lBBookClient.Size = new System.Drawing.Size(92, 16);
            this.lBBookClient.TabIndex = 11;
            this.lBBookClient.Text = "Tên khách đặt";
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
            // dUDRoomStatus
            // 
            this.dUDRoomStatus.Location = new System.Drawing.Point(491, 188);
            this.dUDRoomStatus.Name = "dUDRoomStatus";
            this.dUDRoomStatus.ReadOnly = true;
            this.dUDRoomStatus.Size = new System.Drawing.Size(168, 22);
            this.dUDRoomStatus.TabIndex = 4;
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
            // bTBook
            // 
            this.bTBook.Location = new System.Drawing.Point(516, 18);
            this.bTBook.Name = "bTBook";
            this.bTBook.Size = new System.Drawing.Size(75, 23);
            this.bTBook.TabIndex = 1;
            this.bTBook.Text = "Đặt";
            this.bTBook.UseVisualStyleBackColor = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trạng thái:";
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
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dUDRoomStatus);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGVService);
            this.Controls.Add(this.panel1);
            this.Name = "RoomInfo";
            this.Text = "RoomInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRoomID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBookEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBRoomID;
        private System.Windows.Forms.DataGridView dGVService;
        private System.Windows.Forms.PictureBox pBBookEmployee;
        private System.Windows.Forms.PictureBox pBBookClient;
        private System.Windows.Forms.PictureBox pBBookDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tBNote;
        private System.Windows.Forms.Label lBBookEmployee;
        private System.Windows.Forms.Label lBBookClient;
        private System.Windows.Forms.Label lBRoomID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DomainUpDown dUDRoomStatus;
        private System.Windows.Forms.Button bTUpdate;
        private System.Windows.Forms.Button bTBook;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}