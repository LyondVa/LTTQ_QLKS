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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gBSearch = new System.Windows.Forms.GroupBox();
            this.lBSearch = new System.Windows.Forms.Label();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSLAdd = new System.Windows.Forms.ToolStripLabel();
            this.tSLUpdate = new System.Windows.Forms.ToolStripLabel();
            this.tSLDelete = new System.Windows.Forms.ToolStripLabel();
            this.dGVRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tCNote = new Guna.UI2.WinForms.Guna2TabControl();
            this.tPNote = new System.Windows.Forms.TabPage();
            this.tP_tBService = new System.Windows.Forms.TabPage();
            this.tP_tBNote = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.gBSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRoom)).BeginInit();
            this.tCNote.SuspendLayout();
            this.tPNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gBSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(879, 78);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gBSearch
            // 
            this.gBSearch.Controls.Add(this.lBSearch);
            this.gBSearch.Controls.Add(this.tBSearch);
            this.gBSearch.Location = new System.Drawing.Point(3, 3);
            this.gBSearch.Name = "gBSearch";
            this.gBSearch.Size = new System.Drawing.Size(872, 75);
            this.gBSearch.TabIndex = 0;
            this.gBSearch.TabStop = false;
            this.gBSearch.Text = "Tìm kiếm";
            // 
            // lBSearch
            // 
            this.lBSearch.AutoSize = true;
            this.lBSearch.Location = new System.Drawing.Point(32, 34);
            this.lBSearch.Name = "lBSearch";
            this.lBSearch.Size = new System.Drawing.Size(70, 16);
            this.lBSearch.TabIndex = 1;
            this.lBSearch.Text = "Mã phòng:";
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(102, 31);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(100, 22);
            this.tBSearch.TabIndex = 0;
            this.tBSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tCNote);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 94);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 478);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(879, 25);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLAdd,
            this.tSLUpdate,
            this.tSLDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(162, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSLAdd
            // 
            this.tSLAdd.Name = "tSLAdd";
            this.tSLAdd.Size = new System.Drawing.Size(46, 22);
            this.tSLAdd.Text = "Thêm";
            this.tSLAdd.Click += new System.EventHandler(this.tSLAdd_Click);
            // 
            // tSLUpdate
            // 
            this.tSLUpdate.Name = "tSLUpdate";
            this.tSLUpdate.Size = new System.Drawing.Size(68, 22);
            this.tSLUpdate.Text = "Cập nhật";
            this.tSLUpdate.Click += new System.EventHandler(this.tSLUpdate_Click);
            // 
            // tSLDelete
            // 
            this.tSLDelete.Name = "tSLDelete";
            this.tSLDelete.Size = new System.Drawing.Size(35, 22);
            this.tSLDelete.Text = "Xóa";
            this.tSLDelete.Click += new System.EventHandler(this.tSLDelete_Click);
            // 
            // dGVRoom
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGVRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVRoom.Location = new System.Drawing.Point(0, 78);
            this.dGVRoom.Name = "dGVRoom";
            this.dGVRoom.RowHeadersVisible = false;
            this.dGVRoom.RowHeadersWidth = 51;
            this.dGVRoom.RowTemplate.Height = 24;
            this.dGVRoom.Size = new System.Drawing.Size(879, 400);
            this.dGVRoom.TabIndex = 4;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGVRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRoom.ThemeStyle.HeaderStyle.Height = 4;
            this.dGVRoom.ThemeStyle.ReadOnly = false;
            this.dGVRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGVRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dGVRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tCNote
            // 
            this.tCNote.Controls.Add(this.tPNote);
            this.tCNote.Controls.Add(this.tP_tBService);
            this.tCNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCNote.ItemSize = new System.Drawing.Size(180, 40);
            this.tCNote.Location = new System.Drawing.Point(0, 0);
            this.tCNote.Name = "tCNote";
            this.tCNote.SelectedIndex = 0;
            this.tCNote.Size = new System.Drawing.Size(879, 94);
            this.tCNote.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tCNote.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tCNote.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tCNote.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tCNote.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tCNote.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tCNote.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tCNote.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tCNote.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tCNote.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tCNote.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tCNote.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tCNote.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tCNote.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tCNote.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tCNote.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tCNote.TabIndex = 0;
            this.tCNote.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tCNote.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tPNote
            // 
            this.tPNote.Controls.Add(this.tP_tBNote);
            this.tPNote.Location = new System.Drawing.Point(4, 44);
            this.tPNote.Name = "tPNote";
            this.tPNote.Padding = new System.Windows.Forms.Padding(3);
            this.tPNote.Size = new System.Drawing.Size(871, 46);
            this.tPNote.TabIndex = 0;
            this.tPNote.Text = "Ghi chú";
            this.tPNote.UseVisualStyleBackColor = true;
            // 
            // tP_tBService
            // 
            this.tP_tBService.Location = new System.Drawing.Point(4, 44);
            this.tP_tBService.Name = "tP_tBService";
            this.tP_tBService.Padding = new System.Windows.Forms.Padding(3);
            this.tP_tBService.Size = new System.Drawing.Size(871, 46);
            this.tP_tBService.TabIndex = 1;
            this.tP_tBService.Text = "Dịch vụ";
            this.tP_tBService.UseVisualStyleBackColor = true;
            // 
            // tP_tBNote
            // 
            this.tP_tBNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tP_tBNote.Location = new System.Drawing.Point(3, 3);
            this.tP_tBNote.Multiline = true;
            this.tP_tBNote.Name = "tP_tBNote";
            this.tP_tBNote.Size = new System.Drawing.Size(865, 40);
            this.tP_tBNote.TabIndex = 0;
            // 
            // UC_RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVRoom);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_RoomManagement";
            this.Size = new System.Drawing.Size(879, 597);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gBSearch.ResumeLayout(false);
            this.gBSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRoom)).EndInit();
            this.tCNote.ResumeLayout(false);
            this.tPNote.ResumeLayout(false);
            this.tPNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gBSearch;
        private System.Windows.Forms.Label lBSearch;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tSLAdd;
        private System.Windows.Forms.ToolStripLabel tSLUpdate;
        private System.Windows.Forms.ToolStripLabel tSLDelete;
        private Guna.UI2.WinForms.Guna2DataGridView dGVRoom;
        private Guna.UI2.WinForms.Guna2TabControl tCNote;
        private System.Windows.Forms.TabPage tPNote;
        private System.Windows.Forms.TabPage tP_tBService;
        private System.Windows.Forms.TextBox tP_tBNote;
    }
}
