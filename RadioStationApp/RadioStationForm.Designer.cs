namespace RadioStationApp
{
    partial class RadioStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadioStation));
            this.btnLaRed = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.btnContinental = new System.Windows.Forms.Button();
            this.txtCustomRadio = new System.Windows.Forms.TextBox();
            this.btnCustomRadio = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnProductInfo = new System.Windows.Forms.Button();
            this.imgEqualizer = new System.Windows.Forms.PictureBox();
            this.imgContinental = new System.Windows.Forms.PictureBox();
            this.imgLaRed = new System.Windows.Forms.PictureBox();
            this.btnStopStream = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLaRed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaRed
            // 
            this.btnLaRed.Location = new System.Drawing.Point(48, 177);
            this.btnLaRed.Name = "btnLaRed";
            this.btnLaRed.Size = new System.Drawing.Size(75, 23);
            this.btnLaRed.TabIndex = 0;
            this.btnLaRed.Text = "LaRed";
            this.btnLaRed.UseVisualStyleBackColor = true;
            this.btnLaRed.Click += new System.EventHandler(this.btnLaRed_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 9);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(260, 33);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "-";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinental
            // 
            this.btnContinental.Location = new System.Drawing.Point(161, 177);
            this.btnContinental.Name = "btnContinental";
            this.btnContinental.Size = new System.Drawing.Size(75, 23);
            this.btnContinental.TabIndex = 3;
            this.btnContinental.Text = "Continental";
            this.btnContinental.UseVisualStyleBackColor = true;
            this.btnContinental.Click += new System.EventHandler(this.btnContinental_Click);
            // 
            // txtCustomRadio
            // 
            this.txtCustomRadio.Location = new System.Drawing.Point(12, 49);
            this.txtCustomRadio.Name = "txtCustomRadio";
            this.txtCustomRadio.Size = new System.Drawing.Size(179, 20);
            this.txtCustomRadio.TabIndex = 4;
            // 
            // btnCustomRadio
            // 
            this.btnCustomRadio.Location = new System.Drawing.Point(197, 47);
            this.btnCustomRadio.Name = "btnCustomRadio";
            this.btnCustomRadio.Size = new System.Drawing.Size(75, 23);
            this.btnCustomRadio.TabIndex = 5;
            this.btnCustomRadio.Text = "Escuchar";
            this.btnCustomRadio.UseVisualStyleBackColor = true;
            this.btnCustomRadio.Click += new System.EventHandler(this.btnCustomRadio_Click);
            // 
            // btnMute
            // 
            this.btnMute.Image = global::RadioStationApp.Properties.Resources.speaker;
            this.btnMute.Location = new System.Drawing.Point(12, 226);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(48, 23);
            this.btnMute.TabIndex = 10;
            this.btnMute.UseVisualStyleBackColor = true;
            // 
            // btnProductInfo
            // 
            this.btnProductInfo.Image = global::RadioStationApp.Properties.Resources.info;
            this.btnProductInfo.Location = new System.Drawing.Point(224, 226);
            this.btnProductInfo.Name = "btnProductInfo";
            this.btnProductInfo.Size = new System.Drawing.Size(48, 23);
            this.btnProductInfo.TabIndex = 9;
            this.btnProductInfo.UseVisualStyleBackColor = true;
            this.btnProductInfo.Click += new System.EventHandler(this.btnProductInfo_Click);
            // 
            // imgEqualizer
            // 
            this.imgEqualizer.Image = ((System.Drawing.Image)(resources.GetObject("imgEqualizer.Image")));
            this.imgEqualizer.Location = new System.Drawing.Point(130, 122);
            this.imgEqualizer.Name = "imgEqualizer";
            this.imgEqualizer.Size = new System.Drawing.Size(23, 14);
            this.imgEqualizer.TabIndex = 8;
            this.imgEqualizer.TabStop = false;
            this.imgEqualizer.Visible = false;
            // 
            // imgContinental
            // 
            this.imgContinental.Image = ((System.Drawing.Image)(resources.GetObject("imgContinental.Image")));
            this.imgContinental.Location = new System.Drawing.Point(161, 87);
            this.imgContinental.Name = "imgContinental";
            this.imgContinental.Size = new System.Drawing.Size(75, 79);
            this.imgContinental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgContinental.TabIndex = 7;
            this.imgContinental.TabStop = false;
            // 
            // imgLaRed
            // 
            this.imgLaRed.Image = ((System.Drawing.Image)(resources.GetObject("imgLaRed.Image")));
            this.imgLaRed.ImageLocation = "";
            this.imgLaRed.Location = new System.Drawing.Point(47, 87);
            this.imgLaRed.Name = "imgLaRed";
            this.imgLaRed.Size = new System.Drawing.Size(75, 79);
            this.imgLaRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLaRed.TabIndex = 6;
            this.imgLaRed.TabStop = false;
            // 
            // btnStopStream
            // 
            this.btnStopStream.Enabled = false;
            this.btnStopStream.Image = global::RadioStationApp.Properties.Resources.stop;
            this.btnStopStream.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStopStream.Location = new System.Drawing.Point(75, 226);
            this.btnStopStream.Name = "btnStopStream";
            this.btnStopStream.Size = new System.Drawing.Size(134, 23);
            this.btnStopStream.TabIndex = 2;
            this.btnStopStream.Text = "Detener";
            this.btnStopStream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopStream.UseVisualStyleBackColor = true;
            this.btnStopStream.Click += new System.EventHandler(this.btnStopStream_Click);
            // 
            // RadioStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnProductInfo);
            this.Controls.Add(this.imgEqualizer);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.imgContinental);
            this.Controls.Add(this.imgLaRed);
            this.Controls.Add(this.btnCustomRadio);
            this.Controls.Add(this.txtCustomRadio);
            this.Controls.Add(this.btnContinental);
            this.Controls.Add(this.btnStopStream);
            this.Controls.Add(this.btnLaRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadioStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estación de radio";
            this.Load += new System.EventHandler(this.RadioStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLaRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaRed;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Button btnStopStream;
        private System.Windows.Forms.Button btnContinental;
        private System.Windows.Forms.TextBox txtCustomRadio;
        private System.Windows.Forms.Button btnCustomRadio;
        private System.Windows.Forms.PictureBox imgLaRed;
        private System.Windows.Forms.PictureBox imgContinental;
        private System.Windows.Forms.PictureBox imgEqualizer;
        private System.Windows.Forms.Button btnProductInfo;
        private System.Windows.Forms.Button btnMute;
    }
}

