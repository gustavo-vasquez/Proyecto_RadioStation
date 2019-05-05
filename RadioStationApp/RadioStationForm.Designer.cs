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
            this.metro951 = new System.Windows.Forms.ToolStripMenuItem();
            this.radio10 = new System.Windows.Forms.ToolStripMenuItem();
            this.radioMitre = new System.Windows.Forms.ToolStripMenuItem();
            this.vorterix = new System.Windows.Forms.ToolStripMenuItem();
            this.delPlataAM1030 = new System.Windows.Forms.ToolStripMenuItem();
            this.elDestape = new System.Windows.Forms.ToolStripMenuItem();
            this.radioRivadaviaAM630 = new System.Windows.Forms.ToolStripMenuItem();
            this.radioLatinaFM1011 = new System.Windows.Forms.ToolStripMenuItem();
            this.cNNRadioArgentina = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorItem = new System.Windows.Forms.ToolStripSeparator();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tltGeneral = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLaRed)).BeginInit();
            this.cmsRadiosPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaRed
            // 
            this.btnLaRed.Location = new System.Drawing.Point(48, 177);
            this.btnLaRed.Name = "btnLaRed";
            this.btnLaRed.Size = new System.Drawing.Size(75, 23);
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
            this.txtCustomRadio.TabIndex = 0;
            this.txtCustomRadio.Enter += new System.EventHandler(this.txtCustomRadio_Enter);
            this.txtCustomRadio.Leave += new System.EventHandler(this.txtCustomRadio_Leave);
            // 
            // btnCustomRadio
            // 
            this.btnCustomRadio.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomRadio.Image")));
            this.btnCustomRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomRadio.Location = new System.Drawing.Point(197, 47);
            this.btnCustomRadio.Name = "btnCustomRadio";
            this.btnCustomRadio.Size = new System.Drawing.Size(75, 23);
            this.btnCustomRadio.TabIndex = 1;
            this.btnCustomRadio.Text = "Escuchar";
            this.btnCustomRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tltGeneral.SetToolTip(this.btnCustomRadio, "Escuchar url de radio ingresada");
            this.btnCustomRadio.UseVisualStyleBackColor = true;
            this.btnCustomRadio.Click += new System.EventHandler(this.btnCustomRadio_Click);
            // 
            // btnMute
            // 
            this.btnMute.Image = global::RadioStationApp.Properties.Resources.speaker_v2;
            this.btnMute.Location = new System.Drawing.Point(224, 226);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(48, 23);
            this.btnMute.TabIndex = 4;
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
            this.btnRadios.TabIndex = 6;
            this.tltGeneral.SetToolTip(this.btnRadios, "Escuchar radios adicionales");
            this.btnRadios.UseVisualStyleBackColor = true;
            this.btnRadios.Click += new System.EventHandler(this.btnRadios_Click);
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
            this.btnStopStream.TabIndex = 5;
            this.btnStopStream.Text = "Detener";
            this.btnStopStream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopStream.UseVisualStyleBackColor = true;
            this.btnStopStream.Click += new System.EventHandler(this.btnStopStream_Click);
            // 
            // cmsRadiosPopup
            // 
            this.cmsRadiosPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metro951,
            this.radio10,
            this.radioMitre,
            this.vorterix,
            this.delPlataAM1030,
            this.elDestape,
            this.radioRivadaviaAM630,
            this.radioLatinaFM1011,
            this.cNNRadioArgentina,
            this.separatorItem,
            this.aboutItem});
            this.cmsRadiosPopup.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.cmsRadiosPopup.Name = "cmsRadiosPopup";
            this.cmsRadiosPopup.Size = new System.Drawing.Size(201, 230);
            // 
            // metro951
            // 
            this.metro951.CheckOnClick = true;
            this.metro951.Image = global::RadioStationApp.Properties.Resources.metro95_1;
            this.metro951.Name = "metro951";
            this.metro951.Size = new System.Drawing.Size(200, 22);
            this.metro951.Text = "Metro 95.1";
            this.metro951.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // radio10
            // 
            this.radio10.CheckOnClick = true;
            this.radio10.Image = global::RadioStationApp.Properties.Resources.radio10;
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(200, 22);
            this.radio10.Text = "Radio 10";
            this.radio10.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // radioMitre
            // 
            this.radioMitre.CheckOnClick = true;
            this.radioMitre.Image = global::RadioStationApp.Properties.Resources.radio_mitre;
            this.radioMitre.Name = "radioMitre";
            this.radioMitre.Size = new System.Drawing.Size(200, 22);
            this.radioMitre.Text = "Radio Mitre";
            this.radioMitre.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // vorterix
            // 
            this.vorterix.CheckOnClick = true;
            this.vorterix.Image = global::RadioStationApp.Properties.Resources.vorterix;
            this.vorterix.Name = "vorterix";
            this.vorterix.Size = new System.Drawing.Size(200, 22);
            this.vorterix.Text = "Vorterix";
            this.vorterix.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // delPlataAM1030
            // 
            this.delPlataAM1030.CheckOnClick = true;
            this.delPlataAM1030.Image = global::RadioStationApp.Properties.Resources.del_plata_am1030;
            this.delPlataAM1030.Name = "delPlataAM1030";
            this.delPlataAM1030.Size = new System.Drawing.Size(200, 22);
            this.delPlataAM1030.Text = "Del Plata AM 1030";
            this.delPlataAM1030.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // elDestape
            // 
            this.elDestape.CheckOnClick = true;
            this.elDestape.Image = global::RadioStationApp.Properties.Resources.el_destape;
            this.elDestape.Name = "elDestape";
            this.elDestape.Size = new System.Drawing.Size(200, 22);
            this.elDestape.Text = "El destape";
            this.elDestape.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // radioRivadaviaAM630
            // 
            this.radioRivadaviaAM630.CheckOnClick = true;
            this.radioRivadaviaAM630.Image = global::RadioStationApp.Properties.Resources.radio_rivadavia_am630;
            this.radioRivadaviaAM630.Name = "radioRivadaviaAM630";
            this.radioRivadaviaAM630.Size = new System.Drawing.Size(200, 22);
            this.radioRivadaviaAM630.Text = "Radio Rivadavia AM 630";
            this.radioRivadaviaAM630.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // radioLatinaFM1011
            // 
            this.radioLatinaFM1011.CheckOnClick = true;
            this.radioLatinaFM1011.Image = global::RadioStationApp.Properties.Resources.radio_latina_fm101_1;
            this.radioLatinaFM1011.Name = "radioLatinaFM1011";
            this.radioLatinaFM1011.Size = new System.Drawing.Size(200, 22);
            this.radioLatinaFM1011.Text = "Radio Latina FM 101.1";
            this.radioLatinaFM1011.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // cNNRadioArgentina
            // 
            this.cNNRadioArgentina.CheckOnClick = true;
            this.cNNRadioArgentina.Image = global::RadioStationApp.Properties.Resources.cnn_radio_argentina;
            this.cNNRadioArgentina.Name = "cNNRadioArgentina";
            this.cNNRadioArgentina.Size = new System.Drawing.Size(200, 22);
            this.cNNRadioArgentina.Text = "CNN Radio Argentina";
            this.cNNRadioArgentina.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // separatorItem
            // 
            this.separatorItem.Name = "separatorItem";
            this.separatorItem.Size = new System.Drawing.Size(197, 6);
            // 
            // aboutItem
            // 
            this.aboutItem.Image = global::RadioStationApp.Properties.Resources.info;
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(200, 22);
            this.aboutItem.Text = "Acerca de...";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // RadioStation
            // 
            this.AcceptButton = this.btnCustomRadio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
            this.Name = "RadioStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estación de radio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RadioStation_FormClosing);
            this.Load += new System.EventHandler(this.RadioStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLaRed)).EndInit();
            this.cmsRadiosPopup.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem metro951;
        private System.Windows.Forms.ToolStripMenuItem radio10;
        private System.Windows.Forms.ToolStripMenuItem radioMitre;
        private System.Windows.Forms.ToolStripMenuItem vorterix;
        private System.Windows.Forms.ToolStripMenuItem delPlataAM1030;
        private System.Windows.Forms.ToolStripMenuItem elDestape;
        private System.Windows.Forms.ToolStripMenuItem radioRivadaviaAM630;
        private System.Windows.Forms.ToolStripMenuItem radioLatinaFM1011;
        private System.Windows.Forms.ToolStripMenuItem cNNRadioArgentina;
        private System.Windows.Forms.ToolStripSeparator separatorItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolTip tltGeneral;
    }
}

