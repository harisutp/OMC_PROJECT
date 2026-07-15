namespace OMC_PROJECT
{
    partial class formreceipt
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.lblNameD = new System.Windows.Forms.Label();
            this.lblCarD = new System.Windows.Forms.Label();
            this.lblPlateD = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnmeProf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnRide = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblReceipt);
            this.pnlMain.Controls.Add(this.lblNameD);
            this.pnlMain.Controls.Add(this.lblCarD);
            this.pnlMain.Controls.Add(this.lblPlateD);
            this.pnlMain.Controls.Add(this.lblFees);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(247, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(830, 613);
            this.pnlMain.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECEIPT :";
            // 
            // lblReceipt
            // 
            this.lblReceipt.BackColor = System.Drawing.Color.LightGray;
            this.lblReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceipt.Location = new System.Drawing.Point(204, 100);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(358, 417);
            this.lblReceipt.TabIndex = 0;
            this.lblReceipt.Click += new System.EventHandler(this.lblReceipt_Click);
            // 
            // lblNameD
            // 
            this.lblNameD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameD.Location = new System.Drawing.Point(10, 10);
            this.lblNameD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameD.Name = "lblNameD";
            this.lblNameD.Size = new System.Drawing.Size(10, 10);
            this.lblNameD.TabIndex = 2;
            this.lblNameD.Visible = false;
            // 
            // lblCarD
            // 
            this.lblCarD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarD.Location = new System.Drawing.Point(10, 26);
            this.lblCarD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarD.Name = "lblCarD";
            this.lblCarD.Size = new System.Drawing.Size(10, 10);
            this.lblCarD.TabIndex = 3;
            this.lblCarD.Visible = false;
            // 
            // lblPlateD
            // 
            this.lblPlateD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlateD.Location = new System.Drawing.Point(10, 42);
            this.lblPlateD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlateD.Name = "lblPlateD";
            this.lblPlateD.Size = new System.Drawing.Size(10, 10);
            this.lblPlateD.TabIndex = 4;
            this.lblPlateD.Visible = false;
            // 
            // lblFees
            // 
            this.lblFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFees.Location = new System.Drawing.Point(10, 58);
            this.lblFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(10, 10);
            this.lblFees.TabIndex = 5;
            this.lblFees.Visible = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightGray;
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.btnProfile);
            this.pnlSidebar.Controls.Add(this.btnBalance);
            this.pnlSidebar.Controls.Add(this.btnRide);
            this.pnlSidebar.Controls.Add(this.lblName);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(247, 613);
            this.pnlSidebar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblnmeProf);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 613);
            this.panel1.TabIndex = 4;
            // 
            // lblnmeProf
            // 
            this.lblnmeProf.BackColor = System.Drawing.Color.LightGray;
            this.lblnmeProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnmeProf.Location = new System.Drawing.Point(93, 12);
            this.lblnmeProf.Name = "lblnmeProf";
            this.lblnmeProf.Size = new System.Drawing.Size(147, 46);
            this.lblnmeProf.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "PROFILE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 90);
            this.button2.TabIndex = 2;
            this.button2.Text = "BALANCE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 71);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 90);
            this.button3.TabIndex = 1;
            this.button3.Text = "LET\'S RIDE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name : ";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.DarkGray;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 263);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(247, 90);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.DarkGray;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Location = new System.Drawing.Point(0, 167);
            this.btnBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(247, 90);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "BALANCE";
            this.btnBalance.UseVisualStyleBackColor = false;
            // 
            // btnRide
            // 
            this.btnRide.BackColor = System.Drawing.Color.DarkGray;
            this.btnRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRide.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRide.Location = new System.Drawing.Point(0, 71);
            this.btnRide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRide.Name = "btnRide";
            this.btnRide.Size = new System.Drawing.Size(247, 90);
            this.btnRide.TabIndex = 1;
            this.btnRide.Text = "LET\'S RIDE";
            this.btnRide.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(165, 33);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : Hassan";
            // 
            // formreceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 613);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formreceipt";
            this.Text = "formreceipt";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnmeProf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnRide;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReceipt;
        public System.Windows.Forms.Label lblNameD;
        public System.Windows.Forms.Label lblCarD;
        public System.Windows.Forms.Label lblPlateD;
        public System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label1;
    }
}