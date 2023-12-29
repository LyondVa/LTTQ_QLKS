namespace Hotel.SmallForm
{
    partial class F_Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Receipt));
            this.pnBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.pnReceipt = new Guna.UI2.WinForms.Guna2Panel();
            this.pnFlavorText = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnMisc2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnGratuities = new Guna.UI2.WinForms.Guna2Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnHotelInfo2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnBillingTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lbAfterTaxTotal = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbBillTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnBillingInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvBillingInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnMisc1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnReceiptInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbReceiptDate = new System.Windows.Forms.Label();
            this.lbReservationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnHotelnfo1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btExit = new Guna.UI2.WinForms.Guna2Button();
            this.pnBackground.SuspendLayout();
            this.pnReceipt.SuspendLayout();
            this.pnFlavorText.SuspendLayout();
            this.pnMisc2.SuspendLayout();
            this.pnGratuities.SuspendLayout();
            this.pnHotelInfo2.SuspendLayout();
            this.pnBillingTotal.SuspendLayout();
            this.pnBillingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillingInfo)).BeginInit();
            this.pnMisc1.SuspendLayout();
            this.pnReceiptInfo.SuspendLayout();
            this.pnHotelnfo1.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.AutoSize = true;
            this.pnBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnBackground.BackColor = System.Drawing.SystemColors.Info;
            this.pnBackground.BackgroundImage = global::Hotel.Properties.Resources.BackGround_SmallForm;
            this.pnBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBackground.Controls.Add(this.pnReceipt);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(584, 914);
            this.pnBackground.TabIndex = 0;
            // 
            // pnReceipt
            // 
            this.pnReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnReceipt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnReceipt.Controls.Add(this.pnFlavorText);
            this.pnReceipt.Controls.Add(this.pnMisc2);
            this.pnReceipt.Controls.Add(this.guna2Separator2);
            this.pnReceipt.Controls.Add(this.pnBillingTotal);
            this.pnReceipt.Controls.Add(this.pnBillingInfo);
            this.pnReceipt.Controls.Add(this.guna2Separator1);
            this.pnReceipt.Controls.Add(this.pnMisc1);
            this.pnReceipt.Controls.Add(this.label1);
            this.pnReceipt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnReceipt.Location = new System.Drawing.Point(50, 60);
            this.pnReceipt.Name = "pnReceipt";
            this.pnReceipt.Size = new System.Drawing.Size(484, 734);
            this.pnReceipt.TabIndex = 0;
            // 
            // pnFlavorText
            // 
            this.pnFlavorText.BackColor = System.Drawing.Color.Transparent;
            this.pnFlavorText.Controls.Add(this.label10);
            this.pnFlavorText.Location = new System.Drawing.Point(158, 8);
            this.pnFlavorText.Name = "pnFlavorText";
            this.pnFlavorText.Size = new System.Drawing.Size(200, 100);
            this.pnFlavorText.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(79)))), ((int)(((byte)(239)))));
            this.label10.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 100);
            this.label10.TabIndex = 1;
            this.label10.Text = "The Muse";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMisc2
            // 
            this.pnMisc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMisc2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMisc2.Controls.Add(this.pnGratuities);
            this.pnMisc2.Controls.Add(this.pnHotelInfo2);
            this.pnMisc2.Location = new System.Drawing.Point(10, 578);
            this.pnMisc2.Name = "pnMisc2";
            this.pnMisc2.Size = new System.Drawing.Size(464, 130);
            this.pnMisc2.TabIndex = 6;
            // 
            // pnGratuities
            // 
            this.pnGratuities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGratuities.BackColor = System.Drawing.Color.White;
            this.pnGratuities.Controls.Add(this.label19);
            this.pnGratuities.Controls.Add(this.label20);
            this.pnGratuities.Location = new System.Drawing.Point(250, 0);
            this.pnGratuities.Name = "pnGratuities";
            this.pnGratuities.Size = new System.Drawing.Size(214, 130);
            this.pnGratuities.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(72, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 45);
            this.label19.TabIndex = 5;
            this.label19.Text = "Cảm ơn!";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(205, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "Chúc quý khách một ngày tốt lành";
            // 
            // pnHotelInfo2
            // 
            this.pnHotelInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHotelInfo2.BackColor = System.Drawing.Color.White;
            this.pnHotelInfo2.Controls.Add(this.label21);
            this.pnHotelInfo2.Controls.Add(this.label22);
            this.pnHotelInfo2.Location = new System.Drawing.Point(0, 0);
            this.pnHotelInfo2.Name = "pnHotelInfo2";
            this.pnHotelInfo2.Size = new System.Drawing.Size(234, 130);
            this.pnHotelInfo2.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(174, 23);
            this.label21.TabIndex = 5;
            this.label21.Text = "Thông tin thanh toán";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(123, 34);
            this.label22.TabIndex = 4;
            this.label22.Text = "The Muse\r\nSố tài khoản: xxxxxx\r\n";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(79)))), ((int)(((byte)(239)))));
            this.guna2Separator2.FillThickness = 3;
            this.guna2Separator2.Location = new System.Drawing.Point(10, 562);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(482, 10);
            this.guna2Separator2.TabIndex = 5;
            // 
            // pnBillingTotal
            // 
            this.pnBillingTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBillingTotal.BackColor = System.Drawing.Color.White;
            this.pnBillingTotal.Controls.Add(this.lbAfterTaxTotal);
            this.pnBillingTotal.Controls.Add(this.lbTax);
            this.pnBillingTotal.Controls.Add(this.lbBillTotal);
            this.pnBillingTotal.Controls.Add(this.label15);
            this.pnBillingTotal.Controls.Add(this.label13);
            this.pnBillingTotal.Controls.Add(this.label14);
            this.pnBillingTotal.Location = new System.Drawing.Point(10, 479);
            this.pnBillingTotal.Name = "pnBillingTotal";
            this.pnBillingTotal.Size = new System.Drawing.Size(464, 61);
            this.pnBillingTotal.TabIndex = 4;
            // 
            // lbAfterTaxTotal
            // 
            this.lbAfterTaxTotal.AutoSize = true;
            this.lbAfterTaxTotal.Location = new System.Drawing.Point(380, 45);
            this.lbAfterTaxTotal.Name = "lbAfterTaxTotal";
            this.lbAfterTaxTotal.Size = new System.Drawing.Size(50, 17);
            this.lbAfterTaxTotal.TabIndex = 11;
            this.lbAfterTaxTotal.Text = "label18";
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Location = new System.Drawing.Point(380, 29);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(50, 17);
            this.lbTax.TabIndex = 10;
            this.lbTax.Text = "label17";
            // 
            // lbBillTotal
            // 
            this.lbBillTotal.AutoSize = true;
            this.lbBillTotal.Location = new System.Drawing.Point(380, 13);
            this.lbBillTotal.Name = "lbBillTotal";
            this.lbBillTotal.Size = new System.Drawing.Size(50, 17);
            this.lbBillTotal.TabIndex = 9;
            this.lbBillTotal.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(301, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Thành tiền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(301, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Thuế:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tổng cộng:";
            // 
            // pnBillingInfo
            // 
            this.pnBillingInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnBillingInfo.Controls.Add(this.dgvBillingInfo);
            this.pnBillingInfo.Location = new System.Drawing.Point(10, 296);
            this.pnBillingInfo.Name = "pnBillingInfo";
            this.pnBillingInfo.Size = new System.Drawing.Size(480, 177);
            this.pnBillingInfo.TabIndex = 3;
            // 
            // dgvBillingInfo
            // 
            this.dgvBillingInfo.AllowUserToAddRows = false;
            this.dgvBillingInfo.AllowUserToDeleteRows = false;
            this.dgvBillingInfo.AllowUserToResizeColumns = false;
            this.dgvBillingInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvBillingInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBillingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillingInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillingInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBillingInfo.ColumnHeadersHeight = 29;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillingInfo.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBillingInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvBillingInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvBillingInfo.MultiSelect = false;
            this.dgvBillingInfo.Name = "dgvBillingInfo";
            this.dgvBillingInfo.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillingInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBillingInfo.RowHeadersVisible = false;
            this.dgvBillingInfo.RowHeadersWidth = 51;
            this.dgvBillingInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBillingInfo.RowTemplate.Height = 24;
            this.dgvBillingInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBillingInfo.Size = new System.Drawing.Size(480, 177);
            this.dgvBillingInfo.TabIndex = 0;
            this.dgvBillingInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.dgvBillingInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillingInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillingInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillingInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBillingInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBillingInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillingInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvBillingInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillingInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBillingInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillingInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBillingInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBillingInfo.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvBillingInfo.ThemeStyle.ReadOnly = true;
            this.dgvBillingInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillingInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillingInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillingInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBillingInfo.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBillingInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvBillingInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(79)))), ((int)(((byte)(239)))));
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(10, 280);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(480, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // pnMisc1
            // 
            this.pnMisc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMisc1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMisc1.Controls.Add(this.pnReceiptInfo);
            this.pnMisc1.Controls.Add(this.pnHotelnfo1);
            this.pnMisc1.Location = new System.Drawing.Point(10, 144);
            this.pnMisc1.Name = "pnMisc1";
            this.pnMisc1.Size = new System.Drawing.Size(464, 114);
            this.pnMisc1.TabIndex = 1;
            // 
            // pnReceiptInfo
            // 
            this.pnReceiptInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnReceiptInfo.BackColor = System.Drawing.Color.White;
            this.pnReceiptInfo.Controls.Add(this.lbCustomerName);
            this.pnReceiptInfo.Controls.Add(this.lbReceiptDate);
            this.pnReceiptInfo.Controls.Add(this.lbReservationID);
            this.pnReceiptInfo.Controls.Add(this.label4);
            this.pnReceiptInfo.Controls.Add(this.label3);
            this.pnReceiptInfo.Controls.Add(this.label2);
            this.pnReceiptInfo.Location = new System.Drawing.Point(250, 0);
            this.pnReceiptInfo.Name = "pnReceiptInfo";
            this.pnReceiptInfo.Size = new System.Drawing.Size(214, 114);
            this.pnReceiptInfo.TabIndex = 2;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(6, 89);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(98, 17);
            this.lbCustomerName.TabIndex = 5;
            this.lbCustomerName.Text = "Tên khách hàng";
            // 
            // lbReceiptDate
            // 
            this.lbReceiptDate.AutoSize = true;
            this.lbReceiptDate.Location = new System.Drawing.Point(114, 56);
            this.lbReceiptDate.Name = "lbReceiptDate";
            this.lbReceiptDate.Size = new System.Drawing.Size(89, 17);
            this.lbReceiptDate.TabIndex = 4;
            this.lbReceiptDate.Text = "Ngày xuất HD";
            // 
            // lbReservationID
            // 
            this.lbReservationID.AutoSize = true;
            this.lbReservationID.Location = new System.Drawing.Point(114, 40);
            this.lbReservationID.Name = "lbReservationID";
            this.lbReservationID.Size = new System.Drawing.Size(80, 17);
            this.lbReservationID.TabIndex = 3;
            this.lbReservationID.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày xuất HD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa đơn:";
            // 
            // pnHotelnfo1
            // 
            this.pnHotelnfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHotelnfo1.BackColor = System.Drawing.Color.White;
            this.pnHotelnfo1.Controls.Add(this.label9);
            this.pnHotelnfo1.Controls.Add(this.label8);
            this.pnHotelnfo1.Location = new System.Drawing.Point(0, 0);
            this.pnHotelnfo1.Name = "pnHotelnfo1";
            this.pnHotelnfo1.Size = new System.Drawing.Size(234, 114);
            this.pnHotelnfo1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 85);
            this.label9.TabIndex = 7;
            this.label9.Text = "Khu phố 5, Phường Linh Trung,\r\nTp. Thử Đức, Tp. Hồ Chí Minh\r\n0922834378\r\n2252xxxx" +
    "@gm.uit.edu.vn\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "The Muse";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Niềm tin của bạn - Hạnh phúc của chúng tôi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btPrint);
            this.pnButtons.Controls.Add(this.btExit);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 850);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(584, 64);
            this.pnButtons.TabIndex = 1;
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPrint.BackColor = System.Drawing.Color.Transparent;
            this.btPrint.BorderRadius = 10;
            this.btPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.btPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btPrint.Location = new System.Drawing.Point(215, 7);
            this.btPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(180, 45);
            this.btPrint.TabIndex = 54;
            this.btPrint.Text = "In";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.BorderRadius = 10;
            this.btExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExit.FillColor = System.Drawing.Color.White;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(124)))), ((int)(((byte)(78)))));
            this.btExit.Location = new System.Drawing.Point(401, 7);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(180, 45);
            this.btExit.TabIndex = 53;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // F_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 914);
            this.ControlBox = false;
            this.Controls.Add(this.pnButtons);
            this.Controls.Add(this.pnBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Receipt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnBackground.ResumeLayout(false);
            this.pnReceipt.ResumeLayout(false);
            this.pnFlavorText.ResumeLayout(false);
            this.pnMisc2.ResumeLayout(false);
            this.pnGratuities.ResumeLayout(false);
            this.pnGratuities.PerformLayout();
            this.pnHotelInfo2.ResumeLayout(false);
            this.pnHotelInfo2.PerformLayout();
            this.pnBillingTotal.ResumeLayout(false);
            this.pnBillingTotal.PerformLayout();
            this.pnBillingInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillingInfo)).EndInit();
            this.pnMisc1.ResumeLayout(false);
            this.pnReceiptInfo.ResumeLayout(false);
            this.pnReceiptInfo.PerformLayout();
            this.pnHotelnfo1.ResumeLayout(false);
            this.pnHotelnfo1.PerformLayout();
            this.pnButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnBackground;
        private Guna.UI2.WinForms.Guna2Panel pnReceipt;
        private Guna.UI2.WinForms.Guna2Panel pnFlavorText;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnMisc1;
        private Guna.UI2.WinForms.Guna2Panel pnReceiptInfo;
        private Guna.UI2.WinForms.Guna2Panel pnHotelnfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbReceiptDate;
        private System.Windows.Forms.Label lbReservationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel pnBillingInfo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel pnBillingTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label lbAfterTaxTotal;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label lbBillTotal;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Panel pnMisc2;
        private Guna.UI2.WinForms.Guna2Panel pnGratuities;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2Panel pnHotelInfo2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillingInfo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Panel pnButtons;
        private Guna.UI2.WinForms.Guna2Button btPrint;
        private Guna.UI2.WinForms.Guna2Button btExit;
    }
}