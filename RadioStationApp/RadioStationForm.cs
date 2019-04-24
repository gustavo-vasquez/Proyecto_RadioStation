using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Vlc.DotNet.Core.Interops.Signatures;

namespace RadioStationApp
{
    public partial class RadioStation : Form
    {        
        private VlcMediaPlayer _vlcMediaPlayer;
        private const string txtCustomRadioDefaultText = "Pegar stream url...";
        private ThumbnailToolBarButton thumbnailBtnMute;
        private ThumbnailToolBarButton thumbnailBtnStop;

        public RadioStation()
        {
            InitializeComponent();

            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            if (currentDirectory == null)
                return;

            var libDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            _vlcMediaPlayer = new VlcMediaPlayer(libDirectory);

            _vlcMediaPlayer.Playing += VlcMediaPlayerOnPlaying;
            _vlcMediaPlayer.Stopped += VlcMediaPlayerOnStopped;
            _vlcMediaPlayer.EncounteredError += VlcMediaPlayerOnEncounteredError;

            thumbnailBtnMute = new ThumbnailToolBarButton(Properties.Resources.speaker_icon, "Silenciar");
            thumbnailBtnMute.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(thumbnailBtnMute_Click);
            thumbnailBtnStop = new ThumbnailToolBarButton(Properties.Resources.stop_icon, "Detener");
            thumbnailBtnStop.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(btnStopStream_Click);
            thumbnailBtnStop.Enabled = false;
            TaskbarManager.Instance.ThumbnailToolBars.AddButtons(Handle, thumbnailBtnMute, thumbnailBtnStop);
        }

        private void VlcMediaPlayerOnEncounteredError(object sender, VlcMediaPlayerEncounteredErrorEventArgs e)
        {            
            this.Invoke(new MethodInvoker(delegate ()
            {
                this.txtMessage.Text = "La url expiró o es incorrecta.";
            }));
        }

        private void VlcMediaPlayerOnPlaying(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate () {
                this.imgEqualizer.Visible = true;
                this.btnStopStream.Enabled = true;
                this.thumbnailBtnStop.Enabled = true;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate, Handle);
            }));
        }

        private void VlcMediaPlayerOnStopped(object sender, VlcMediaPlayerStoppedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {                
                this.ResetButtonsOfRadioStreams();
                this.imgEqualizer.Visible = false;
                this.btnStopStream.Enabled = false;
                this.thumbnailBtnStop.Enabled = false;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error, Handle);
                TaskbarManager.Instance.SetProgressValue(100, 100, Handle);
            }));
        }

        private void RadioStation_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLaRed_Click(object sender, EventArgs e)
        {
            this.SetRadio(RadioList.Radio["laRed"], "Radio LaRed AM 910");
            btnLaRed.Enabled = false;

            if (!btnContinental.Enabled)
                btnContinental.Enabled = true;

            ResetRadiosPopup();
        }

        private void btnContinental_Click(object sender, EventArgs e)
        {
            this.SetRadio(RadioList.Radio["continental"], "Radio Continental AM 590");
            btnContinental.Enabled = false;

            if (!btnLaRed.Enabled)
                btnLaRed.Enabled = true;

            ResetRadiosPopup();
        }

        private void btnCustomRadio_Click(object sender, EventArgs e)
        {
            this.SetRadio(txtCustomRadio.Text, "personalizada");            
            this.ResetButtonsOfRadioStreams();
        }

        private void btnStopStream_Click(object sender, EventArgs e)
        {
            DoStopStream();
        }

        private void thumbnailBtnStop_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            DoStopStream();
        }

        private void SetRadio(string streamUrl, string message)
        {
            _vlcMediaPlayer.SetMedia(streamUrl, null);
            _vlcMediaPlayer.Play();
            txtMessage.Text = "Estás escuchando " + message;
        }

        private void ResetButtonsOfRadioStreams()
        {
            if (!btnLaRed.Enabled)
                btnLaRed.Enabled = true;

            if (!btnContinental.Enabled)
                btnContinental.Enabled = true;

            ResetRadiosPopup();
        }

        private void btnRadios_Click(object sender, EventArgs e)
        {
            Button buttonMenu = sender as Button;
            cmsRadiosPopup.Show(buttonMenu, new Point(0, 0));
        }

        private void txtCustomRadio_Enter(object sender, EventArgs e)
        {
            if (txtCustomRadio.Text.Equals(txtCustomRadioDefaultText))
            {
                txtCustomRadio.Text = string.Empty;
                txtCustomRadio.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtCustomRadio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomRadio.Text))
            {
                txtCustomRadio.Text = txtCustomRadioDefaultText;
                txtCustomRadio.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            DoMuteStream();
        }

        private void thumbnailBtnMute_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            DoMuteStream();
        }

        private void DoMuteStream()
        {
            if (_vlcMediaPlayer.State == MediaStates.Playing)
            {
                if (_vlcMediaPlayer.Audio.IsMute)
                {
                    btnMute.Image = Properties.Resources.speaker_v2;
                    thumbnailBtnMute.Icon = Properties.Resources.speaker_icon;
                    thumbnailBtnMute.Tooltip = "Silenciar";
                    _vlcMediaPlayer.Audio.IsMute = false;
                }
                else
                {
                    btnMute.Image = Properties.Resources.speaker_mute_v2;
                    thumbnailBtnMute.Icon = Properties.Resources.speaker_mute_icon;
                    thumbnailBtnMute.Tooltip = "Encender";
                    _vlcMediaPlayer.Audio.IsMute = true;
                }
            }
        }

        private void DoStopStream()
        {
            _vlcMediaPlayer.Stop();
            this.txtMessage.Text = "-";
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            string appInfoText = String.Join(
                    null,
                    ProjectInfo.Product,
                    Environment.NewLine,
                    ProjectInfo.Description,
                    Environment.NewLine,
                    Environment.NewLine,
                    ProjectInfo.Copyright,
                    Environment.NewLine,
                    Environment.NewLine,
                    "Versión: ",
                    Assembly.GetEntryAssembly().GetName().Version.ToString()
                );
            DialogResult AppInfoWindow = MessageBox.Show(appInfoText, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RadiosItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem currentMenuItem = sender as ToolStripMenuItem;
            
            currentMenuItem.Owner.Items
            .OfType<ToolStripMenuItem>().Where(i => i.Name != currentMenuItem.Name).ToList()
            .ForEach(item =>
            {
                item.Enabled = true;
                item.Checked = false;
            });

            this.SetRadio(RadioList.Radio[currentMenuItem.Name], currentMenuItem.Text);
            currentMenuItem.Enabled = false;
            btnLaRed.Enabled = btnContinental.Enabled = true;
        }

        private void ResetRadiosPopup()
        {
            cmsRadiosPopup.Items
            .OfType<ToolStripMenuItem>().ToList()
            .ForEach(item =>
            {
                item.Enabled = true;
                item.Checked = false;
            });
        }
    }
}