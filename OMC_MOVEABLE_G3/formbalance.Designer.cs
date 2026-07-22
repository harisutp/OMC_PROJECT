namespace OMC_PROJECT
{
    partial class formbalance
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblReload = new System.Windows.Forms.Label();
            this.btnReload2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnRide = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMain.Controls.Add(this.guna2CustomGradientPanel1);
            this.pnlMain.Controls.Add(this.btnReload);
            this.pnlMain.Controls.Add(this.lblBalance);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(278, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(841, 708);
            this.pnlMain.TabIndex = 5;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.lblReload);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnReload2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.RoyalBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(841, 708);
            this.guna2CustomGradientPanel1.TabIndex = 8;
            // 
            // lblReload
            // 
            this.lblReload.BackColor = System.Drawing.Color.White;
            this.lblReload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReload.Font = new System.Drawing.Font("Bahnschrift", 19F);
            this.lblReload.Location = new System.Drawing.Point(311, 405);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(243, 94);
            this.lblReload.TabIndex = 9;
            this.lblReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReload2
            // 
            this.btnReload2.AutoRoundedCorners = true;
            this.btnReload2.BackColor = System.Drawing.Color.Transparent;
            this.btnReload2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload2.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.btnReload2.ForeColor = System.Drawing.Color.White;
            this.btnReload2.Location = new System.Drawing.Point(346, 520);
            this.btnReload2.Name = "btnReload2";
            this.btnReload2.Size = new System.Drawing.Size(180, 45);
            this.btnReload2.TabIndex = 8;
            this.btnReload2.Text = "RELOAD";
            this.btnReload2.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR BALANCE IS :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OMC_PROJECT.Properties.Resources.Wallet_by_back1design1_580x389_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(270, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(464, 686);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(212, 63);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBalance.Location = new System.Drawing.Point(237, 431);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(374, 105);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(278, 708);
            this.pnlSidebar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 708);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(0, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 112);
            this.button4.TabIndex = 4;
            this.button4.Text = "ABOUT US";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 112);
            this.button1.TabIndex = 3;
            this.button1.Text = "PROFILE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(0, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 112);
            this.button2.TabIndex = 2;
            this.button2.Text = "BALANCE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(0, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 112);
            this.button3.TabIndex = 1;
            this.button3.Text = "LET\'S RIDE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.DarkGray;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 329);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(278, 112);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.DarkGray;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Location = new System.Drawing.Point(0, 209);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(278, 112);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "BALANCE";
            this.btnBalance.UseVisualStyleBackColor = false;
            // 
            // btnRide
            // 
            this.btnRide.BackColor = System.Drawing.Color.DarkGray;
            this.btnRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRide.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRide.Location = new System.Drawing.Point(0, 89);
            this.btnRide.Name = "btnRide";
            this.btnRide.Size = new System.Drawing.Size(278, 112);
            this.btnRide.TabIndex = 1;
            this.btnRide.Text = "LET\'S RIDE";
            this.btnRide.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(186, 42);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : Hassan";
            // 
            // formbalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 708);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formbalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formbalance";
            this.Load += new System.EventHandler(this.formbalance_Load);
            this.pnlMain.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnRide;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblBalance;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnReload2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblReload;
    }
}