namespace Hotel.RoomControls
{
    partial class RoomGrid
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
            this.uC_RoomUnitAvailable1 = new Hotel.RoomControls.UC_RoomUnitAvailable();
            this.SuspendLayout();
            // 
            // uC_RoomUnitAvailable1
            // 
            this.uC_RoomUnitAvailable1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uC_RoomUnitAvailable1.Location = new System.Drawing.Point(133, 123);
            this.uC_RoomUnitAvailable1.Name = "uC_RoomUnitAvailable1";
            this.uC_RoomUnitAvailable1.Size = new System.Drawing.Size(216, 134);
            this.uC_RoomUnitAvailable1.TabIndex = 0;
            // 
            // RoomGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_RoomUnitAvailable1);
            this.Name = "RoomGrid";
            this.Size = new System.Drawing.Size(720, 466);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_RoomUnitAvailable uC_RoomUnitAvailable1;
    }
}
