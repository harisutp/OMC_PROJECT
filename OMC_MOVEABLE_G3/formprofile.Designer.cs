namespace OMC_PROJECT
{
    partial class formprofile
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
            this.txtDisabilities = new System.Windows.Forms.TextBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlMain.Controls.Add(this.guna2CustomGradientPanel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(278, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(841, 708);
            this.pnlMain.TabIndex = 3;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.txtDisabilities);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnPhoto);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtContact);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnLogout);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtName);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.NAME);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.RoyalBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 2);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(837, 706);
            this.guna2CustomGradientPanel1.TabIndex = 12;
            // 
            // txtDisabilities
            // 
            this.txtDisabilities.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtDisabilities.Location = new System.Drawing.Point(213, 536);
            this.txtDisabilities.Name = "txtDisabilities";
            this.txtDisabilities.Size = new System.Drawing.Size(394, 29);
            this.txtDisabilities.TabIndex = 11;
            this.txtDisabilities.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPhoto.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPhoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhoto.Location = new System.Drawing.Point(295, 247);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(225, 45);
            this.btnPhoto.TabIndex = 11;
            this.btnPhoto.Text = "Change your photo";
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtContact.Location = new System.Drawing.Point(213, 442);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(394, 29);
            this.txtContact.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.Font = new System.Drawing.Font("Bahnschrift", 11.2F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(343, 597);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 55);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtName.Location = new System.Drawing.Point(213, 346);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(394, 29);
            this.txtName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disabilities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email / Phone Number";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.Color.Transparent;
            this.NAME.Font = new System.Drawing.Font("Bahnschrift", 11.8F, System.Drawing.FontStyle.Bold);
            this.NAME.ForeColor = System.Drawing.Color.White;
            this.NAME.Location = new System.Drawing.Point(208, 311);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(77, 29);
            this.NAME.TabIndex = 1;
            this.NAME.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OMC_PROJECT.Properties.Resources.istockphoto_2171382633_612x612_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(295, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
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
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(278, 708);
            this.pnlSidebar.TabIndex = 2;
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
            this.panel1.Size = new System.Drawing.Size(300, 708);
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
            // formprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 708);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formprofile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formprofile";
            this.pnlMain.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnRide;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtDisabilities;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPhoto;
    }
}