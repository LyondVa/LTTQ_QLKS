namespace Hotel.All_user_control
{
    partial class UC_Service
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btExport = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvServiceInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dịch Vụ";
            // 
            // btExport
            // 
            this.btExport.BorderRadius = 10;
            this.btExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExport.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btExport.ForeColor = System.Drawing.Color.White;
            this.btExport.Location = new System.Drawing.Point(1085, 34);
            this.btExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(154, 49);
            this.btExport.TabIndex = 6;
            this.btExport.Text = "Xuất File Excel";
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Location = new System.Drawing.Point(52, 52);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Tìm Kiếm";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(254, 31);
            this.tbSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgvServiceInfo
            // 
            this.dgvServiceInfo.AllowUserToAddRows = false;
            this.dgvServiceInfo.AllowUserToDeleteRows = false;
            this.dgvServiceInfo.AllowUserToResizeColumns = false;
            this.dgvServiceInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvServiceInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServiceInfo.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServiceInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvServiceInfo.Location = new System.Drawing.Point(52, 107);
            this.dgvServiceInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServiceInfo.Name = "dgvServiceInfo";
            this.dgvServiceInfo.ReadOnly = true;
            this.dgvServiceInfo.RowHeadersVisible = false;
            this.dgvServiceInfo.RowHeadersWidth = 62;
            this.dgvServiceInfo.RowTemplate.Height = 28;
            this.dgvServiceInfo.Size = new System.Drawing.Size(1187, 362);
            this.dgvServiceInfo.TabIndex = 4;
            this.dgvServiceInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvServiceInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvServiceInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvServiceInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvServiceInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvServiceInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvServiceInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvServiceInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvServiceInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServiceInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvServiceInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvServiceInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServiceInfo.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvServiceInfo.ThemeStyle.ReadOnly = true;
            this.dgvServiceInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvServiceInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServiceInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvServiceInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvServiceInfo.ThemeStyle.RowsStyle.Height = 28;
            this.dgvServiceInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvServiceInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvServiceInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceInfo_CellContentClick);
            // 
            // btAdd
            // 
            this.btAdd.BorderRadius = 10;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.SlateBlue;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(1045, 485);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(194, 50);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Thêm Dịch Vụ";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvServiceInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Service";
            this.Size = new System.Drawing.Size(1673, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btExport;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvServiceInfo;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
