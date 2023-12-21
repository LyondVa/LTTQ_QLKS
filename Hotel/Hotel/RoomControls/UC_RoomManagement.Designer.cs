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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gBSearch = new System.Windows.Forms.GroupBox();
            this.tBSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lBSearch = new System.Windows.Forms.Label();
            this.dGVRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tCNote = new Guna.UI2.WinForms.Guna2TabControl();
            this.tPNote = new System.Windows.Forms.TabPage();
            this.tP_tBNote = new System.Windows.Forms.TextBox();
            this.tP_tBService = new System.Windows.Forms.TabPage();
            this.tBService = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSLAdd = new System.Windows.Forms.ToolStripLabel();
            this.tSLUpdate = new System.Windows.Forms.ToolStripLabel();
            this.tSLDelete = new System.Windows.Forms.ToolStripLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.gBSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRoom)).BeginInit();
            this.tCNote.SuspendLayout();
            this.tPNote.SuspendLayout();
            this.tP_tBService.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gBSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 78);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gBSearch
            // 
            this.gBSearch.Controls.Add(this.tBSearch);
            this.gBSearch.Controls.Add(this.lBSearch);
            this.gBSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSearch.ForeColor = System.Drawing.Color.White;
            this.gBSearch.Location = new System.Drawing.Point(3, 3);
            this.gBSearch.Name = "gBSearch";
            this.gBSearch.Size = new System.Drawing.Size(870, 116);
            this.gBSearch.TabIndex = 0;
            this.gBSearch.TabStop = false;
            this.gBSearch.Text = "Tìm kiếm";
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
            this.tBSearch.Location = new System.Drawing.Point(145, 34);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.PasswordChar = '\0';
            this.tBSearch.PlaceholderText = "";
            this.tBSearch.SelectedText = "";
            this.tBSearch.Size = new System.Drawing.Size(235, 28);
            this.tBSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tBSearch.TabIndex = 2;
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            // 
            // lBSearch
            // 
            this.lBSearch.AutoSize = true;
            this.lBSearch.Location = new System.Drawing.Point(32, 34);
            this.lBSearch.Name = "lBSearch";
            this.lBSearch.Size = new System.Drawing.Size(94, 23);
            this.lBSearch.TabIndex = 1;
            this.lBSearch.Text = "Mã phòng:";
            // 
            // dGVRoom
            // 
            this.dGVRoom.AllowUserToAddRows = false;
            this.dGVRoom.AllowUserToDeleteRows = false;
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
            this.dGVRoom.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVRoom.GridColor = System.Drawing.Color.White;
            this.dGVRoom.Location = new System.Drawing.Point(0, 78);
            this.dGVRoom.Name = "dGVRoom";
            this.dGVRoom.ReadOnly = true;
            this.dGVRoom.RowHeadersVisible = false;
            this.dGVRoom.RowHeadersWidth = 50;
            this.dGVRoom.RowTemplate.Height = 24;
            this.dGVRoom.Size = new System.Drawing.Size(800, 348);
            this.dGVRoom.TabIndex = 4;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGVRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGVRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGVRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVRoom.ThemeStyle.HeaderStyle.Height = 20;
            this.dGVRoom.ThemeStyle.ReadOnly = true;
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
            this.tCNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tCNote.ItemSize = new System.Drawing.Size(180, 40);
            this.tCNote.Location = new System.Drawing.Point(0, 22);
            this.tCNote.Name = "tCNote";
            this.tCNote.SelectedIndex = 0;
            this.tCNote.Size = new System.Drawing.Size(800, 104);
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
            this.tPNote.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tPNote.Size = new System.Drawing.Size(792, 56);
            this.tPNote.TabIndex = 0;
            this.tPNote.Text = "Ghi chú";
            this.tPNote.UseVisualStyleBackColor = true;
            // 
            // tP_tBNote
            // 
            this.tP_tBNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tP_tBNote.Location = new System.Drawing.Point(3, 13);
            this.tP_tBNote.Multiline = true;
            this.tP_tBNote.Name = "tP_tBNote";
            this.tP_tBNote.Size = new System.Drawing.Size(786, 40);
            this.tP_tBNote.TabIndex = 0;
            // 
            // tP_tBService
            // 
            this.tP_tBService.Controls.Add(this.tBService);
            this.tP_tBService.Location = new System.Drawing.Point(4, 44);
            this.tP_tBService.Name = "tP_tBService";
            this.tP_tBService.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tP_tBService.Size = new System.Drawing.Size(792, 56);
            this.tP_tBService.TabIndex = 1;
            this.tP_tBService.Text = "Dịch vụ";
            this.tP_tBService.UseVisualStyleBackColor = true;
            // 
            // tBService
            // 
            this.tBService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBService.Location = new System.Drawing.Point(3, 3);
            this.tBService.Multiline = true;
            this.tBService.Name = "tBService";
            this.tBService.Size = new System.Drawing.Size(786, 50);
            this.tBService.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.tCNote);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 126);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(879, 25);
            this.flowLayoutPanel2.TabIndex = 4;
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
            this.tSLAdd.BackColor = System.Drawing.Color.Peru;
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
            // UC_RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dGVRoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UC_RoomManagement";
            this.Size = new System.Drawing.Size(800, 552);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gBSearch.ResumeLayout(false);
            this.gBSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRoom)).EndInit();
            this.tCNote.ResumeLayout(false);
            this.tPNote.ResumeLayout(false);
            this.tPNote.PerformLayout();
            this.tP_tBService.ResumeLayout(false);
            this.tP_tBService.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gBSearch;
        private System.Windows.Forms.Label lBSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dGVRoom;
        private Guna.UI2.WinForms.Guna2TextBox tBSearch;
        private Guna.UI2.WinForms.Guna2TabControl tCNote;
        private System.Windows.Forms.TabPage tPNote;
        private System.Windows.Forms.TextBox tP_tBNote;
        private System.Windows.Forms.TabPage tP_tBService;
        private System.Windows.Forms.TextBox tBService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tSLAdd;
        private System.Windows.Forms.ToolStripLabel tSLUpdate;
        private System.Windows.Forms.ToolStripLabel tSLDelete;
    }
}
