using System.Windows.Forms;

namespace OMC_PROJECT
{
    partial class formadmin : Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCap3 = new System.Windows.Forms.Label();
            this.lblCap2 = new System.Windows.Forms.Label();
            this.lblCap1 = new System.Windows.Forms.Label();
            this.lblVal3 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCap6 = new System.Windows.Forms.Label();
            this.lblCap5 = new System.Windows.Forms.Label();
            this.lblCap4 = new System.Windows.Forms.Label();
            this.lblVal5 = new System.Windows.Forms.Label();
            this.lblVal6 = new System.Windows.Forms.Label();
            this.lblVal4 = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(442, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Pages";
            // 
            // cboTable
            // 
            this.cboTable.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(77, 136);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(335, 31);
            this.cboTable.TabIndex = 3;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AutoSize = true;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnLogOut);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSearch);
            this.guna2CustomGradientPanel1.Controls.Add(this.label11);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtSearchId);
            this.guna2CustomGradientPanel1.Controls.Add(this.groupBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.groupBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.cboTable);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.RoyalBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1119, 708);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(182, 268);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 47);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(73, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "ID number";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.txtSearchId.Location = new System.Drawing.Point(77, 216);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(335, 30);
            this.txtSearchId.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Controls.Add(this.lblCap3);
            this.groupBox2.Controls.Add(this.lblCap2);
            this.groupBox2.Controls.Add(this.lblCap1);
            this.groupBox2.Controls.Add(this.lblVal3);
            this.groupBox2.Controls.Add(this.lblVal2);
            this.groupBox2.Controls.Add(this.lblVal1);
            this.groupBox2.Location = new System.Drawing.Point(51, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 265);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // lblCap3
            // 
            this.lblCap3.AutoSize = true;
            this.lblCap3.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblCap3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCap3.Location = new System.Drawing.Point(32, 180);
            this.lblCap3.Name = "lblCap3";
            this.lblCap3.Size = new System.Drawing.Size(69, 23);
            this.lblCap3.TabIndex = 5;
            this.lblCap3.Text = "label14";
            // 
            // lblCap2
            // 
            this.lblCap2.AutoSize = true;
            this.lblCap2.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblCap2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCap2.Location = new System.Drawing.Point(32, 107);
            this.lblCap2.Name = "lblCap2";
            this.lblCap2.Size = new System.Drawing.Size(68, 23);
            this.lblCap2.TabIndex = 4;
            this.lblCap2.Text = "label13";
            // 
            // lblCap1
            // 
            this.lblCap1.AutoSize = true;
            this.lblCap1.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblCap1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCap1.Location = new System.Drawing.Point(32, 27);
            this.lblCap1.Name = "lblCap1";
            this.lblCap1.Size = new System.Drawing.Size(68, 23);
            this.lblCap1.TabIndex = 3;
            this.lblCap1.Text = "label12";
            // 
            // lblVal3
            // 
            this.lblVal3.BackColor = System.Drawing.Color.White;
            this.lblVal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal3.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblVal3.Location = new System.Drawing.Point(26, 209);
            this.lblVal3.Name = "lblVal3";
            this.lblVal3.Size = new System.Drawing.Size(354, 33);
            this.lblVal3.TabIndex = 2;
            // 
            // lblVal2
            // 
            this.lblVal2.BackColor = System.Drawing.Color.White;
            this.lblVal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal2.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblVal2.Location = new System.Drawing.Point(26, 136);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(354, 33);
            this.lblVal2.TabIndex = 1;
            // 
            // lblVal1
            // 
            this.lblVal1.BackColor = System.Drawing.Color.White;
            this.lblVal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal1.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblVal1.Location = new System.Drawing.Point(26, 57);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(354, 33);
            this.lblVal1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.lblCap6);
            this.groupBox1.Controls.Add(this.lblCap5);
            this.groupBox1.Controls.Add(this.lblCap4);
            this.groupBox1.Controls.Add(this.lblVal5);
            this.groupBox1.Controls.Add(this.lblVal6);
            this.groupBox1.Controls.Add(this.lblVal4);
            this.groupBox1.Location = new System.Drawing.Point(519, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 490);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblCap6
            // 
            this.lblCap6.AutoSize = true;
            this.lblCap6.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblCap6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCap6.Location = new System.Drawing.Point(40, 355);
            this.lblCap6.Name = "lblCap6";
            this.lblCap6.Size = new System.Drawing.Size(68, 23);
            this.lblCap6.TabIndex = 9;
            this.lblCap6.Text = "label17";
            // 
            // lblCap5
            // 
            this.lblCap5.AutoSize = true;
            this.lblCap5.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblCap5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCap5.Location = new System.Drawing.Point(40, 193);
            this.lblCap5.Name = "lblCap5";
            this.lblCap5.Size = new System.Drawing.Size(68, 23);
            this.lblCap5.TabIndex = 8;
            this.lblCap5.Text = "label16";
            // 
            // lblCap4
            // 
            this.lblCap4.AutoSize = true;
            this.lblCap4.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblCap4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCap4.Location = new System.Drawing.Point(40, 40);
            this.lblCap4.Name = "lblCap4";
            this.lblCap4.Size = new System.Drawing.Size(68, 23);
            this.lblCap4.TabIndex = 6;
            this.lblCap4.Text = "label15";
            // 
            // lblVal5
            // 
            this.lblVal5.BackColor = System.Drawing.Color.White;
            this.lblVal5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal5.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblVal5.Location = new System.Drawing.Point(33, 222);
            this.lblVal5.Name = "lblVal5";
            this.lblVal5.Size = new System.Drawing.Size(479, 108);
            this.lblVal5.TabIndex = 7;
            // 
            // lblVal6
            // 
            this.lblVal6.BackColor = System.Drawing.Color.White;
            this.lblVal6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal6.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblVal6.Location = new System.Drawing.Point(32, 384);
            this.lblVal6.Name = "lblVal6";
            this.lblVal6.Size = new System.Drawing.Size(480, 45);
            this.lblVal6.TabIndex = 4;
            // 
            // lblVal4
            // 
            this.lblVal4.BackColor = System.Drawing.Color.White;
            this.lblVal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal4.Font = new System.Drawing.Font("Bahnschrift", 9.5F);
            this.lblVal4.Location = new System.Drawing.Point(33, 69);
            this.lblVal4.Name = "lblVal4";
            this.lblVal4.Size = new System.Drawing.Size(479, 101);
            this.lblVal4.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(880, 638);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(180, 45);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // formadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1119, 708);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.formadmin_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboTable;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox txtSearchId;
        private GroupBox groupBox2;
        private Label lblVal3;
        private Label lblVal2;
        private Label lblVal1;
        private Label lblVal5;
        private Label lblVal6;
        private Label lblVal4;
        private Label lblCap3;
        private Label lblCap2;
        private Label lblCap1;
        private Label lblCap6;
        private Label lblCap5;
        private Label lblCap4;
        private Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
    }
}