namespace Hotel
{
    partial class DTB
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
            this.Th = new System.Windows.Forms.Label();
            this.tbDTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lBFloor = new System.Windows.Forms.Label();
            this.btAccess = new Guna.UI2.WinForms.Guna2Button();
            this.btExit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Th
            // 
            this.Th.AutoSize = true;
            this.Th.BackColor = System.Drawing.Color.Transparent;
            this.Th.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.Th.ForeColor = System.Drawing.Color.White;
            this.Th.Location = new System.Drawing.Point(12, 41);
            this.Th.Name = "Th";
            this.Th.Size = new System.Drawing.Size(266, 50);
            this.Th.TabIndex = 3;
            this.Th.Text = "Cơ Sở Dữ Liệu";
            // 
            // tbDTB
            // 
            this.tbDTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDTB.DefaultText = "";
            this.tbDTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDTB.Location = new System.Drawing.Point(21, 138);
            this.tbDTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDTB.Name = "tbDTB";
            this.tbDTB.PasswordChar = '\0';
            this.tbDTB.PlaceholderText = "Nhập Server";
            this.tbDTB.SelectedText = "";
            this.tbDTB.Size = new System.Drawing.Size(340, 45);
            this.tbDTB.TabIndex = 26;
            // 
            // lBFloor
            // 
            this.lBFloor.AutoSize = true;
            this.lBFloor.BackColor = System.Drawing.Color.Transparent;
            this.lBFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBFloor.ForeColor = System.Drawing.Color.White;
            this.lBFloor.Location = new System.Drawing.Point(16, 106);
            this.lBFloor.Name = "lBFloor";
            this.lBFloor.Size = new System.Drawing.Size(168, 28);
            this.lBFloor.TabIndex = 31;
            this.lBFloor.Text = "Tên Server cục bộ:";
            // 
            // btAccess
            // 
            this.btAccess.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btAccess.BackColor = System.Drawing.Color.Transparent;
            this.btAccess.BorderRadius = 10;
            this.btAccess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAccess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAccess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAccess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAccess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.btAccess.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccess.ForeColor = System.Drawing.Color.White;
            this.btAccess.Location = new System.Drawing.Point(82, 218);
            this.btAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAccess.Name = "btAccess";
            this.btAccess.Size = new System.Drawing.Size(140, 36);
            this.btAccess.TabIndex = 42;
            this.btAccess.Text = "Truy Cập";
            this.btAccess.Click += new System.EventHandler(this.btAccess_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.BorderRadius = 10;
            this.btExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(228, 218);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(140, 36);
            this.btExit.TabIndex = 43;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // DTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources.Background_Form;
            this.ClientSize = new System.Drawing.Size(380, 265);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAccess);
            this.Controls.Add(this.lBFloor);
            this.Controls.Add(this.tbDTB);
            this.Controls.Add(this.Th);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Th;
        private Guna.UI2.WinForms.Guna2TextBox tbDTB;
        private System.Windows.Forms.Label lBFloor;
        private Guna.UI2.WinForms.Guna2Button btAccess;
        private Guna.UI2.WinForms.Guna2Button btExit;
    }
}