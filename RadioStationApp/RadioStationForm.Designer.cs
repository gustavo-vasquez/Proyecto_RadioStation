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
            this.metro951Item = new System.Windows.Forms.ToolStripMenuItem();
            this.radio10Item = new System.Windows.Forms.ToolStripMenuItem();
            this.radioMitreItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorterixItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delPlataAM1030Item = new System.Windows.Forms.ToolStripMenuItem();
            this.elDestapeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioRivadaviaAM630Item = new System.Windows.Forms.ToolStripMenuItem();
            this.radioLatinaFM1011Item = new System.Windows.Forms.ToolStripMenuItem();
            this.cNNRadioArgentinaItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.metro951Item,
            this.radio10Item,
            this.radioMitreItem,
            this.vorterixItem,
            this.delPlataAM1030Item,
            this.elDestapeItem,
            this.radioRivadaviaAM630Item,
            this.radioLatinaFM1011Item,
            this.cNNRadioArgentinaItem,
            this.separatorItem,
            this.aboutItem});
            this.cmsRadiosPopup.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.cmsRadiosPopup.Name = "cmsRadiosPopup";
            this.cmsRadiosPopup.Size = new System.Drawing.Size(201, 230);
            // 
            // metro951Item
            // 
            this.metro951Item.CheckOnClick = true;
            this.metro951Item.Image = global::RadioStationApp.Properties.Resources.metro95_1;
            this.metro951Item.Name = "metro951Item";
            this.metro951Item.Size = new System.Drawing.Size(200, 22);
            this.metro951Item.Text = "Metro 95.1";
            this.metro951Item.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // radio10Item
            // 
            this.radio10Item.CheckOnClick = true;
            this.radio10Item.Image = global::RadioStationApp.Properties.Resources.radio10;
            this.radio10Item.Name = "radio10Item";
            this.radio10Item.Size = new System.Drawing.Size(200, 22);
            this.radio10Item.Text = "Radio 10";
            this.radio10Item.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // radioMitreItem
            // 
            this.radioMitreItem.CheckOnClick = true;
            this.radioMitreItem.Image = global::RadioStationApp.Properties.Resources.radio_mitre;
            this.radioMitreItem.Name = "radioMitreItem";
            this.radioMitreItem.Size = new System.Drawing.Size(200, 22);
            this.radioMitreItem.Text = "Radio Mitre";
            this.radioMitreItem.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // vorterixItem
            // 
            this.vorterixItem.CheckOnClick = true;
            this.vorterixItem.Image = global::RadioStationApp.Properties.Resources.vorterix;
            this.vorterixItem.Name = "vorterixItem";
            this.vorterixItem.Size = new System.Drawing.Size(200, 22);
            this.vorterixItem.Text = "Vorterix";
            this.vorterixItem.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // delPlataAM1030Item
            // 
            this.delPlataAM1030Item.CheckOnClick = true;
            this.delPlataAM1030Item.Image = global::RadioStationApp.Properties.Resources.del_plata_am1030;
            this.delPlataAM1030Item.Name = "delPlataAM1030Item";
            this.delPlataAM1030Item.Size = new System.Drawing.Size(200, 22);
            this.delPlataAM1030Item.Text = "Del Plata AM 1030";
            this.delPlataAM1030Item.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // elDestapeItem
            // 
            this.elDestapeItem.CheckOnClick = true;
            this.elDestapeItem.Image = global::RadioStationApp.Properties.Resources.el_destape;
            this.elDestapeItem.Name = "elDestapeItem";
            this.elDestapeItem.Size = new System.Drawing.Size(200, 22);
            this.elDestapeItem.Text = "El destape";
            this.elDestapeItem.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // radioRivadaviaAM630Item
            // 
            this.radioRivadaviaAM630Item.CheckOnClick = true;
            this.radioRivadaviaAM630Item.Image = global::RadioStationApp.Properties.Resources.radio_rivadavia_am630;
            this.radioRivadaviaAM630Item.Name = "radioRivadaviaAM630Item";
            this.radioRivadaviaAM630Item.Size = new System.Drawing.Size(200, 22);
            this.radioRivadaviaAM630Item.Text = "Radio Rivadavia AM 630";
            this.radioRivadaviaAM630Item.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // radioLatinaFM1011Item
            // 
            this.radioLatinaFM1011Item.CheckOnClick = true;
            this.radioLatinaFM1011Item.Image = global::RadioStationApp.Properties.Resources.radio_latina_fm101_1;
            this.radioLatinaFM1011Item.Name = "radioLatinaFM1011Item";
            this.radioLatinaFM1011Item.Size = new System.Drawing.Size(200, 22);
            this.radioLatinaFM1011Item.Text = "Radio Latina FM 101.1";
            this.radioLatinaFM1011Item.Click += new System.EventHandler(this.RadiosItem_Click);
            // 
            // cNNRadioArgentinaItem
            // 
            this.cNNRadioArgentinaItem.CheckOnClick = true;
            this.cNNRadioArgentinaItem.Image = global::RadioStationApp.Properties.Resources.cnn_radio_argentina;
            this.cNNRadioArgentinaItem.Name = "cNNRadioArgentinaItem";
            this.cNNRadioArgentinaItem.Size = new System.Drawing.Size(200, 22);
            this.cNNRadioArgentinaItem.Text = "CNN Radio Argentina";
            this.cNNRadioArgentinaItem.Click += new System.EventHandler(this.RadiosItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem metro951Item;
        private System.Windows.Forms.ToolStripMenuItem radio10Item;
        private System.Windows.Forms.ToolStripMenuItem radioMitreItem;
        private System.Windows.Forms.ToolStripMenuItem vorterixItem;
        private System.Windows.Forms.ToolStripMenuItem delPlataAM1030Item;
        private System.Windows.Forms.ToolStripMenuItem elDestapeItem;
        private System.Windows.Forms.ToolStripMenuItem radioRivadaviaAM630Item;
        private System.Windows.Forms.ToolStripMenuItem radioLatinaFM1011Item;
        private System.Windows.Forms.ToolStripMenuItem cNNRadioArgentinaItem;
        private System.Windows.Forms.ToolStripSeparator separatorItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolTip tltGeneral;
    }
}

