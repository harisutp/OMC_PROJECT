namespace OMC_PROJECT
{
    partial class formlogin
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSignUp3 = new System.Windows.Forms.Button();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(495, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 80);
            this.label12.TabIndex = 70;
            this.label12.Text = "ABLE";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(387, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 80);
            this.label13.TabIndex = 69;
            this.label13.Text = "MOVE";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(255, 315);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(485, 34);
            this.txtPassword2.TabIndex = 76;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(250, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 25);
            this.label16.TabIndex = 72;
            this.label16.Text = "Password";
            // 
            // btnSignUp3
            // 
            this.btnSignUp3.BackColor = System.Drawing.Color.SlateGray;
            this.btnSignUp3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp3.ForeColor = System.Drawing.Color.White;
            this.btnSignUp3.Location = new System.Drawing.Point(255, 461);
            this.btnSignUp3.Name = "btnSignUp3";
            this.btnSignUp3.Size = new System.Drawing.Size(179, 43);
            this.btnSignUp3.TabIndex = 77;
            this.btnSignUp3.Text = "SIGN UP";
            this.btnSignUp3.UseVisualStyleBackColor = false;
            this.btnSignUp3.Click += new System.EventHandler(this.btnSignUp3_Click);
            // 
            // btnLogin2
            // 
            this.btnLogin2.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogin2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin2.ForeColor = System.Drawing.Color.White;
            this.btnLogin2.Location = new System.Drawing.Point(521, 462);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(194, 42);
            this.btnLogin2.TabIndex = 78;
            this.btnLogin2.Text = "LOG IN";
            this.btnLogin2.UseVisualStyleBackColor = false;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // txtEmail2
            // 
            this.txtEmail2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail2.Location = new System.Drawing.Point(255, 235);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(485, 34);
            this.txtEmail2.TabIndex = 80;
            this.txtEmail2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formlogin
            // 
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1063, 564);
            this.Controls.Add(this.txtEmail2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin2);
            this.Controls.Add(this.btnSignUp3);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "formlogin";
            this.Load += new System.EventHandler(this.formlogin_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignup2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSignUp3;
        private System.Windows.Forms.Button btnLogin2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Label label1;
    }
}