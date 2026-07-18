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
            this.button4 = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblnmeProf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnRide = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMain.Controls.Add(this.button4);
            this.pnlMain.Controls.Add(this.lblBalance);
            this.pnlMain.Controls.Add(this.guna2CustomGradientPanel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(185, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(561, 460);
            this.pnlMain.TabIndex = 5;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(232, 362);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "RELOAD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(158, 280);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(250, 69);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBalance.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR BALANCE IS :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OMC_PROJECT.Properties.Resources.Wallet_by_back1design1_580x389_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(180, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(185, 460);
            this.pnlSidebar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblName2);
            this.panel1.Controls.Add(this.lblnmeProf);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 460);
            this.panel1.TabIndex = 4;
            // 
            // lblName2
            // 
            this.lblName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblName2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(70, 7);
            this.lblName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(106, 44);
            this.lblName2.TabIndex = 6;
            // 
            // lblnmeProf
            // 
            this.lblnmeProf.BackColor = System.Drawing.Color.LightGray;
            this.lblnmeProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnmeProf.Location = new System.Drawing.Point(70, 7);
            this.lblnmeProf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnmeProf.Name = "lblnmeProf";
            this.lblnmeProf.Size = new System.Drawing.Size(110, 37);
            this.lblnmeProf.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "PROFILE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 136);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "BALANCE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 58);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 73);
            this.button3.TabIndex = 1;
            this.button3.Text = "LET\'S RIDE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name : ";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.DarkGray;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 214);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(185, 73);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.DarkGray;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Location = new System.Drawing.Point(0, 136);
            this.btnBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(185, 73);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "BALANCE";
            this.btnBalance.UseVisualStyleBackColor = false;
            // 
            // btnRide
            // 
            this.btnRide.BackColor = System.Drawing.Color.DarkGray;
            this.btnRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRide.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRide.Location = new System.Drawing.Point(0, 58);
            this.btnRide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRide.Name = "btnRide";
            this.btnRide.Size = new System.Drawing.Size(185, 73);
            this.btnRide.TabIndex = 1;
            this.btnRide.Text = "LET\'S RIDE";
            this.btnRide.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 7);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : Hassan";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.RoyalBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(561, 470);
            this.guna2CustomGradientPanel1.TabIndex = 8;
            // 
            // formbalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 460);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formbalance";
            this.Text = "formbalance";
            this.Load += new System.EventHandler(this.formbalance_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnRide;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblnmeProf;
        private System.Windows.Forms.Label lblName2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}