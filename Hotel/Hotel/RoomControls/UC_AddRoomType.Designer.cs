namespace Hotel.All_user_control
{
    partial class UC_AddRoomType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBRoomTypeID = new System.Windows.Forms.TextBox();
            this.tBRoomTypeName = new System.Windows.Forms.TextBox();
            this.tBPricePerNight = new System.Windows.Forms.TextBox();
            this.dUDCapacity = new System.Windows.Forms.DomainUpDown();
            this.bTAdd = new System.Windows.Forms.Button();
            this.bTExit = new System.Windows.Forms.Button();
            this.dUDBedNumber = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá trên đêm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên loại phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số người tối đa:";
            // 
            // tBRoomTypeID
            // 
            this.tBRoomTypeID.Location = new System.Drawing.Point(37, 111);
            this.tBRoomTypeID.Name = "tBRoomTypeID";
            this.tBRoomTypeID.Size = new System.Drawing.Size(174, 22);
            this.tBRoomTypeID.TabIndex = 7;
            // 
            // tBRoomTypeName
            // 
            this.tBRoomTypeName.Location = new System.Drawing.Point(310, 111);
            this.tBRoomTypeName.Name = "tBRoomTypeName";
            this.tBRoomTypeName.Size = new System.Drawing.Size(174, 22);
            this.tBRoomTypeName.TabIndex = 8;
            // 
            // tBPricePerNight
            // 
            this.tBPricePerNight.Location = new System.Drawing.Point(37, 167);
            this.tBPricePerNight.Name = "tBPricePerNight";
            this.tBPricePerNight.Size = new System.Drawing.Size(174, 22);
            this.tBPricePerNight.TabIndex = 9;
            // 
            // dUDCapacity
            // 
            this.dUDCapacity.Items.Add("1");
            this.dUDCapacity.Items.Add("2");
            this.dUDCapacity.Items.Add("3");
            this.dUDCapacity.Items.Add("4");
            this.dUDCapacity.Items.Add("5");
            this.dUDCapacity.Location = new System.Drawing.Point(310, 167);
            this.dUDCapacity.Name = "dUDCapacity";
            this.dUDCapacity.Size = new System.Drawing.Size(174, 22);
            this.dUDCapacity.TabIndex = 10;
            this.dUDCapacity.Text = "domainUpDown1";
            // 
            // bTAdd
            // 
            this.bTAdd.Location = new System.Drawing.Point(252, 259);
            this.bTAdd.Name = "bTAdd";
            this.bTAdd.Size = new System.Drawing.Size(113, 23);
            this.bTAdd.TabIndex = 13;
            this.bTAdd.Text = "Thêm";
            this.bTAdd.UseVisualStyleBackColor = true;
            this.bTAdd.Click += new System.EventHandler(this.bTAdd_Click);
            // 
            // bTExit
            // 
            this.bTExit.Location = new System.Drawing.Point(371, 259);
            this.bTExit.Name = "bTExit";
            this.bTExit.Size = new System.Drawing.Size(113, 23);
            this.bTExit.TabIndex = 14;
            this.bTExit.Text = "Thoát";
            this.bTExit.UseVisualStyleBackColor = true;
            // 
            // dUDBedNumber
            // 
            this.dUDBedNumber.Items.Add("1");
            this.dUDBedNumber.Items.Add("2");
            this.dUDBedNumber.Items.Add("3");
            this.dUDBedNumber.Items.Add("4");
            this.dUDBedNumber.Items.Add("5");
            this.dUDBedNumber.Location = new System.Drawing.Point(37, 227);
            this.dUDBedNumber.Name = "dUDBedNumber";
            this.dUDBedNumber.Size = new System.Drawing.Size(174, 22);
            this.dUDBedNumber.TabIndex = 16;
            this.dUDBedNumber.Text = "domainUpDown1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số giường:";
            // 
            // UC_AddRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dUDBedNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bTExit);
            this.Controls.Add(this.bTAdd);
            this.Controls.Add(this.dUDCapacity);
            this.Controls.Add(this.tBPricePerNight);
            this.Controls.Add(this.tBRoomTypeName);
            this.Controls.Add(this.tBRoomTypeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddRoomType";
            this.Size = new System.Drawing.Size(534, 306);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBRoomTypeID;
        private System.Windows.Forms.TextBox tBRoomTypeName;
        private System.Windows.Forms.TextBox tBPricePerNight;
        private System.Windows.Forms.DomainUpDown dUDCapacity;
        private System.Windows.Forms.Button bTAdd;
        private System.Windows.Forms.Button bTExit;
        private System.Windows.Forms.DomainUpDown dUDBedNumber;
        private System.Windows.Forms.Label label4;
    }
}
