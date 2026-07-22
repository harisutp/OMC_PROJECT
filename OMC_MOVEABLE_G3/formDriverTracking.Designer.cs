namespace OMC_PROJECT
{
    partial class formDriverTracking
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
            this.components = new System.ComponentModel.Container();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblTrackingTitle = new System.Windows.Forms.Label();
            this.lblTrackingStatus = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblDriverCar = new System.Windows.Forms.Label();
            this.lblDriverPlate = new System.Windows.Forms.Label();
            this.lblPickup = new System.Windows.Forms.Label();
            this.lblDropOff = new System.Windows.Forms.Label();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressTrip = new System.Windows.Forms.ProgressBar();
            this.btnCancelRide = new System.Windows.Forms.Button();
            this.btnTripCompleted = new System.Windows.Forms.Button();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.webViewTrackingMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnlFallbackMap = new System.Windows.Forms.Panel();
            this.trackingTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlInfo.SuspendLayout();
            this.pnlMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewTrackingMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlInfo.Controls.Add(this.lblTrackingTitle);
            this.pnlInfo.Controls.Add(this.lblTrackingStatus);
            this.pnlInfo.Controls.Add(this.lblDriverName);
            this.pnlInfo.Controls.Add(this.lblDriverCar);
            this.pnlInfo.Controls.Add(this.lblDriverPlate);
            this.pnlInfo.Controls.Add(this.lblPickup);
            this.pnlInfo.Controls.Add(this.lblDropOff);
            this.pnlInfo.Controls.Add(this.lblEstimatedTime);
            this.pnlInfo.Controls.Add(this.lblProgress);
            this.pnlInfo.Controls.Add(this.progressTrip);
            this.pnlInfo.Controls.Add(this.btnCancelRide);
            this.pnlInfo.Controls.Add(this.btnTripCompleted);
            this.pnlInfo.Controls.Add(this.btnBackHome);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(330, 708);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblTrackingTitle
            // 
            this.lblTrackingTitle.Font = new System.Drawing.Font("Bahnschrift", 17F, System.Drawing.FontStyle.Bold);
            this.lblTrackingTitle.ForeColor = System.Drawing.Color.White;
            this.lblTrackingTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTrackingTitle.Name = "lblTrackingTitle";
            this.lblTrackingTitle.Size = new System.Drawing.Size(290, 40);
            this.lblTrackingTitle.TabIndex = 0;
            this.lblTrackingTitle.Text = "DRIVER TRACKING";
            this.lblTrackingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrackingStatus
            // 
            this.lblTrackingStatus.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold);
            this.lblTrackingStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrackingStatus.Location = new System.Drawing.Point(20, 70);
            this.lblTrackingStatus.Name = "lblTrackingStatus";
            this.lblTrackingStatus.Size = new System.Drawing.Size(290, 62);
            this.lblTrackingStatus.TabIndex = 1;
            this.lblTrackingStatus.Text = "Preparing your trip...";
            this.lblTrackingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDriverName
            // 
            this.lblDriverName.Font = new System.Drawing.Font("Bahnschrift", 11.5F);
            this.lblDriverName.ForeColor = System.Drawing.Color.White;
            this.lblDriverName.Location = new System.Drawing.Point(20, 145);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(290, 28);
            this.lblDriverName.TabIndex = 2;
            this.lblDriverName.Text = "Driver :";
            // 
            // lblDriverCar
            // 
            this.lblDriverCar.Font = new System.Drawing.Font("Bahnschrift", 11.5F);
            this.lblDriverCar.ForeColor = System.Drawing.Color.White;
            this.lblDriverCar.Location = new System.Drawing.Point(20, 175);
            this.lblDriverCar.Name = "lblDriverCar";
            this.lblDriverCar.Size = new System.Drawing.Size(290, 28);
            this.lblDriverCar.TabIndex = 3;
            this.lblDriverCar.Text = "Car :";
            // 
            // lblDriverPlate
            // 
            this.lblDriverPlate.Font = new System.Drawing.Font("Bahnschrift", 11.5F);
            this.lblDriverPlate.ForeColor = System.Drawing.Color.White;
            this.lblDriverPlate.Location = new System.Drawing.Point(20, 205);
            this.lblDriverPlate.Name = "lblDriverPlate";
            this.lblDriverPlate.Size = new System.Drawing.Size(290, 28);
            this.lblDriverPlate.TabIndex = 4;
            this.lblDriverPlate.Text = "Plate :";
            // 
            // lblPickup
            // 
            this.lblPickup.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblPickup.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPickup.Location = new System.Drawing.Point(20, 245);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(290, 52);
            this.lblPickup.TabIndex = 5;
            this.lblPickup.Text = "Pick Up :";
            // 
            // lblDropOff
            // 
            this.lblDropOff.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblDropOff.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDropOff.Location = new System.Drawing.Point(20, 300);
            this.lblDropOff.Name = "lblDropOff";
            this.lblDropOff.Size = new System.Drawing.Size(290, 52);
            this.lblDropOff.TabIndex = 6;
            this.lblDropOff.Text = "Drop Off :";
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstimatedTime.ForeColor = System.Drawing.Color.Aqua;
            this.lblEstimatedTime.Location = new System.Drawing.Point(20, 360);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(290, 30);
            this.lblEstimatedTime.TabIndex = 7;
            this.lblEstimatedTime.Text = "Estimated time : -";
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(20, 395);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(290, 26);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "Trip progress : 0%";
            // 
            // progressTrip
            // 
            this.progressTrip.Location = new System.Drawing.Point(20, 424);
            this.progressTrip.Name = "progressTrip";
            this.progressTrip.Size = new System.Drawing.Size(290, 26);
            this.progressTrip.TabIndex = 9;
            // 
            // btnCancelRide
            // 
            this.btnCancelRide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelRide.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRide.Font = new System.Drawing.Font("Bahnschrift", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelRide.ForeColor = System.Drawing.Color.White;
            this.btnCancelRide.Location = new System.Drawing.Point(26, 472);
            this.btnCancelRide.Name = "btnCancelRide";
            this.btnCancelRide.Size = new System.Drawing.Size(272, 51);
            this.btnCancelRide.TabIndex = 10;
            this.btnCancelRide.Text = "CANCEL RIDE";
            this.btnCancelRide.UseVisualStyleBackColor = false;
            this.btnCancelRide.Click += new System.EventHandler(this.btnCancelRide_Click);
            // 
            // btnTripCompleted
            // 
            this.btnTripCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTripCompleted.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTripCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTripCompleted.Font = new System.Drawing.Font("Bahnschrift", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnTripCompleted.ForeColor = System.Drawing.Color.White;
            this.btnTripCompleted.Location = new System.Drawing.Point(25, 540);
            this.btnTripCompleted.Name = "btnTripCompleted";
            this.btnTripCompleted.Size = new System.Drawing.Size(273, 52);
            this.btnTripCompleted.TabIndex = 11;
            this.btnTripCompleted.Text = "TRIP COMPLETED";
            this.btnTripCompleted.UseVisualStyleBackColor = false;
            this.btnTripCompleted.Click += new System.EventHandler(this.btnTripCompleted_Click);
            // 
            // btnBackHome
            // 
            this.btnBackHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBackHome.Enabled = false;
            this.btnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHome.Font = new System.Drawing.Font("Bahnschrift", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnBackHome.ForeColor = System.Drawing.Color.White;
            this.btnBackHome.Location = new System.Drawing.Point(25, 612);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(273, 51);
            this.btnBackHome.TabIndex = 12;
            this.btnBackHome.Text = "BACK TO HOME";
            this.btnBackHome.UseVisualStyleBackColor = false;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.webViewTrackingMap);
            this.pnlMap.Controls.Add(this.pnlFallbackMap);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(330, 0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(789, 708);
            this.pnlMap.TabIndex = 1;
            // 
            // webViewTrackingMap
            // 
            this.webViewTrackingMap.AllowExternalDrop = false;
            this.webViewTrackingMap.CreationProperties = null;
            this.webViewTrackingMap.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewTrackingMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewTrackingMap.Location = new System.Drawing.Point(0, 0);
            this.webViewTrackingMap.Name = "webViewTrackingMap";
            this.webViewTrackingMap.Size = new System.Drawing.Size(789, 708);
            this.webViewTrackingMap.TabIndex = 0;
            this.webViewTrackingMap.ZoomFactor = 1D;
            // 
            // pnlFallbackMap
            // 
            this.pnlFallbackMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFallbackMap.Location = new System.Drawing.Point(0, 0);
            this.pnlFallbackMap.Name = "pnlFallbackMap";
            this.pnlFallbackMap.Size = new System.Drawing.Size(789, 708);
            this.pnlFallbackMap.TabIndex = 1;
            this.pnlFallbackMap.Visible = false;
            this.pnlFallbackMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFallbackMap_Paint);
            this.pnlFallbackMap.Resize += new System.EventHandler(this.pnlFallbackMap_Resize);
            // 
            // trackingTimer
            // 
            this.trackingTimer.Tick += new System.EventHandler(this.trackingTimer_Tick);
            // 
            // formDriverTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 708);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "formDriverTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoveAble - Driver Tracking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDriverTracking_FormClosing);
            this.Load += new System.EventHandler(this.formDriverTracking_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webViewTrackingMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblTrackingTitle;
        private System.Windows.Forms.Label lblTrackingStatus;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblDriverCar;
        private System.Windows.Forms.Label lblDriverPlate;
        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.Label lblDropOff;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressTrip;
        private System.Windows.Forms.Button btnCancelRide;
        private System.Windows.Forms.Button btnTripCompleted;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Panel pnlMap;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewTrackingMap;
        private System.Windows.Forms.Panel pnlFallbackMap;
        private System.Windows.Forms.Timer trackingTimer;
    }
}
