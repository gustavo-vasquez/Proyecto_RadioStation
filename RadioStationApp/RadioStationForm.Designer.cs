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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadioStation));
            this.btnLaRed = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.btnContinental = new System.Windows.Forms.Button();
            this.txtCustomRadio = new System.Windows.Forms.TextBox();
            this.btnCustomRadio = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnRadios = new System.Windows.Forms.Button();
            this.imgEqualizer = new System.Windows.Forms.PictureBox();
            this.imgContinental = new System.Windows.Forms.PictureBox();
            this.imgLaRed = new System.Windows.Forms.PictureBox();
            this.btnStopStream = new System.Windows.Forms.Button();
            this.cmsRadiosPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metro = new System.Windows.Forms.ToolStripMenuItem();
            this.mitre = new System.Windows.Forms.ToolStripMenuItem();
            this.vorterix = new System.Windows.Forms.ToolStripMenuItem();
            this.delPlata = new System.Windows.Forms.ToolStripMenuItem();
            this.elDestape = new System.Windows.Forms.ToolStripMenuItem();
            this.rivadavia = new System.Windows.Forms.ToolStripMenuItem();
            this.latina = new System.Windows.Forms.ToolStripMenuItem();
            this.cnn = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorAfterRadios = new System.Windows.Forms.ToolStripSeparator();
            this.updateRadioLinks = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorAfterVerification = new System.Windows.Forms.ToolStripSeparator();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tltGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.txtUpdateRadioLinks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLaRed)).BeginInit();
            this.cmsRadiosPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaRed
            // 
            this.btnLaRed.Location = new System.Drawing.Point(47, 177);
            this.btnLaRed.Name = "btnLaRed";
            this.btnLaRed.Size = new System.Drawing.Size(76, 23);
            this.btnLaRed.TabIndex = 2;
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
            this.txtCustomRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomRadio.Location = new System.Drawing.Point(12, 49);
            this.txtCustomRadio.Name = "txtCustomRadio";
            this.txtCustomRadio.Size = new System.Drawing.Size(179, 20);
            this.txtCustomRadio.TabIndex = 0;
            this.tltGeneral.SetToolTip(this.txtCustomRadio, "Escribe la URL de la radio que quieres escuchar (HTTP/HTTPS)");
            this.txtCustomRadio.Enter += new System.EventHandler(this.txtCustomRadio_Enter);
            this.txtCustomRadio.Leave += new System.EventHandler(this.txtCustomRadio_Leave);
            // 
            // btnCustomRadio
            // 
            this.btnCustomRadio.Image = global::RadioStationApp.Properties.Resources.headphones;
            this.btnCustomRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomRadio.Location = new System.Drawing.Point(197, 47);
            this.btnCustomRadio.Name = "btnCustomRadio";
            this.btnCustomRadio.Size = new System.Drawing.Size(75, 23);
            this.btnCustomRadio.TabIndex = 1;
            this.btnCustomRadio.Text = "Escuchar";
            this.btnCustomRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tltGeneral.SetToolTip(this.btnCustomRadio, "Escuchar radio a través de la URL ingresada");
            this.btnCustomRadio.UseVisualStyleBackColor = true;
            this.btnCustomRadio.Click += new System.EventHandler(this.btnCustomRadio_Click);
            // 
            // btnMute
            // 
            this.btnMute.Image = global::RadioStationApp.Properties.Resources.speaker_button;
            this.btnMute.Location = new System.Drawing.Point(224, 226);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(48, 23);
            this.btnMute.TabIndex = 7;
            this.tltGeneral.SetToolTip(this.btnMute, "Activar/desactivar sonido");
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnRadios
            // 
            this.btnRadios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRadios.Image = global::RadioStationApp.Properties.Resources.online_radio;
            this.btnRadios.Location = new System.Drawing.Point(12, 226);
            this.btnRadios.Name = "btnRadios";
            this.btnRadios.Size = new System.Drawing.Size(48, 23);
            this.btnRadios.TabIndex = 4;
            this.tltGeneral.SetToolTip(this.btnRadios, "Escuchar radios adicionales");
            this.btnRadios.UseVisualStyleBackColor = true;
            this.btnRadios.Click += new System.EventHandler(this.btnRadios_Click);
            // 
            // imgEqualizer
            // 
            this.imgEqualizer.Image = ((System.Drawing.Image)(resources.GetObject("imgEqualizer.Image")));
            this.imgEqualizer.Location = new System.Drawing.Point(130, 87);
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
            this.btnStopStream.Image = global::RadioStationApp.Properties.Resources.stop_button;
            this.btnStopStream.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStopStream.Location = new System.Drawing.Point(75, 226);
            this.btnStopStream.Name = "btnStopStream";
            this.btnStopStream.Size = new System.Drawing.Size(134, 23);
            this.btnStopStream.TabIndex = 5;
            this.btnStopStream.Text = "Detener";
            this.btnStopStream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopStream.UseVisualStyleBackColor = true;
            this.btnStopStream.Click += new System.EventHandler(this.btnStopStream_Click);
            // 
            // cmsRadiosPopup
            // 
            this.cmsRadiosPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metro,
            this.mitre,
            this.vorterix,
            this.delPlata,
            this.elDestape,
            this.rivadavia,
            this.latina,
            this.cnn,
            this.separatorAfterRadios,
            this.updateRadioLinks,
            this.separatorAfterVerification,
            this.aboutItem});
            this.cmsRadiosPopup.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.cmsRadiosPopup.Name = "cmsRadiosPopup";
            this.cmsRadiosPopup.Size = new System.Drawing.Size(220, 236);
            // 
            // metro
            // 
            this.metro.Image = ((System.Drawing.Image)(resources.GetObject("metro.Image")));
            this.metro.Name = "metro";
            this.metro.Size = new System.Drawing.Size(219, 22);
            this.metro.Text = "Metro FM 95.1";
            this.metro.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // mitre
            // 
            this.mitre.Image = ((System.Drawing.Image)(resources.GetObject("mitre.Image")));
            this.mitre.Name = "mitre";
            this.mitre.Size = new System.Drawing.Size(219, 22);
            this.mitre.Text = "Mitre AM 1100";
            this.mitre.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // vorterix
            // 
            this.vorterix.Image = ((System.Drawing.Image)(resources.GetObject("vorterix.Image")));
            this.vorterix.Name = "vorterix";
            this.vorterix.Size = new System.Drawing.Size(219, 22);
            this.vorterix.Text = "Vorterix FM 92.1";
            this.vorterix.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // delPlata
            // 
            this.delPlata.Image = ((System.Drawing.Image)(resources.GetObject("delPlata.Image")));
            this.delPlata.Name = "delPlata";
            this.delPlata.Size = new System.Drawing.Size(219, 22);
            this.delPlata.Text = "Del plata AM 1030";
            this.delPlata.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // elDestape
            // 
            this.elDestape.Image = ((System.Drawing.Image)(resources.GetObject("elDestape.Image")));
            this.elDestape.Name = "elDestape";
            this.elDestape.Size = new System.Drawing.Size(219, 22);
            this.elDestape.Text = "El destape FM 107.3";
            this.elDestape.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // rivadavia
            // 
            this.rivadavia.Image = ((System.Drawing.Image)(resources.GetObject("rivadavia.Image")));
            this.rivadavia.Name = "rivadavia";
            this.rivadavia.Size = new System.Drawing.Size(219, 22);
            this.rivadavia.Text = "Rivadavia AM 630";
            this.rivadavia.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // latina
            // 
            this.latina.Image = ((System.Drawing.Image)(resources.GetObject("latina.Image")));
            this.latina.Name = "latina";
            this.latina.Size = new System.Drawing.Size(219, 22);
            this.latina.Text = "Latina FM 101.1";
            this.latina.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // cnn
            // 
            this.cnn.Image = ((System.Drawing.Image)(resources.GetObject("cnn.Image")));
            this.cnn.Name = "cnn";
            this.cnn.Size = new System.Drawing.Size(219, 22);
            this.cnn.Text = "CNN argentina AM 950";
            this.cnn.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // separatorAfterRadios
            // 
            this.separatorAfterRadios.Name = "separatorAfterRadios";
            this.separatorAfterRadios.Size = new System.Drawing.Size(216, 6);
            // 
            // updateRadioLinks
            // 
            this.updateRadioLinks.Image = global::RadioStationApp.Properties.Resources.refresh;
            this.updateRadioLinks.Name = "updateRadioLinks";
            this.updateRadioLinks.Size = new System.Drawing.Size(219, 22);
            this.updateRadioLinks.Text = "Actualizar enlaces de radios";
            this.updateRadioLinks.Click += new System.EventHandler(this.updateRadioLinks_Click);
            // 
            // separatorAfterVerification
            // 
            this.separatorAfterVerification.Name = "separatorAfterVerification";
            this.separatorAfterVerification.Size = new System.Drawing.Size(216, 6);
            // 
            // aboutItem
            // 
            this.aboutItem.Image = global::RadioStationApp.Properties.Resources.info;
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(219, 22);
            this.aboutItem.Text = "Acerca de...";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // tltGeneral
            // 
            this.tltGeneral.AutoPopDelay = 5000;
            this.tltGeneral.InitialDelay = 1000;
            this.tltGeneral.ReshowDelay = 100;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.AutoSize = false;
            this.trackBarVolume.LargeChange = 10;
            this.trackBarVolume.Location = new System.Drawing.Point(131, 101);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(23, 90);
            this.trackBarVolume.SmallChange = 5;
            this.trackBarVolume.TabIndex = 6;
            this.trackBarVolume.TickFrequency = 5;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tltGeneral.SetToolTip(this.trackBarVolume, "Volumen");
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // labelVolume
            // 
            this.labelVolume.Location = new System.Drawing.Point(125, 185);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(34, 14);
            this.labelVolume.TabIndex = 10;
            this.labelVolume.Text = "100";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUpdateRadioLinks
            // 
            this.txtUpdateRadioLinks.Location = new System.Drawing.Point(47, 206);
            this.txtUpdateRadioLinks.Name = "txtUpdateRadioLinks";
            this.txtUpdateRadioLinks.Size = new System.Drawing.Size(189, 13);
            this.txtUpdateRadioLinks.TabIndex = 11;
            this.txtUpdateRadioLinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioStation
            // 
            this.AcceptButton = this.btnCustomRadio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtUpdateRadioLinks);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnRadios);
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
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "RadioStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Streadio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RadioStation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLaRed)).EndInit();
            this.cmsRadiosPopup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
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
        private System.Windows.Forms.Button btnRadios;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.ContextMenuStrip cmsRadiosPopup;
        private System.Windows.Forms.ToolStripMenuItem metro;
        private System.Windows.Forms.ToolStripMenuItem mitre;
        private System.Windows.Forms.ToolStripMenuItem vorterix;
        private System.Windows.Forms.ToolStripMenuItem delPlata;
        private System.Windows.Forms.ToolStripMenuItem elDestape;
        private System.Windows.Forms.ToolStripMenuItem rivadavia;
        private System.Windows.Forms.ToolStripMenuItem latina;
        private System.Windows.Forms.ToolStripMenuItem cnn;
        private System.Windows.Forms.ToolStripSeparator separatorAfterRadios;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolTip tltGeneral;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.ToolStripMenuItem updateRadioLinks;
        private System.Windows.Forms.ToolStripSeparator separatorAfterVerification;
        private System.Windows.Forms.Label txtUpdateRadioLinks;
    }
}

