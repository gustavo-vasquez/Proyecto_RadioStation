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
using Un4seen.Bass;

namespace RadioStationApp
{
    public partial class RadioStation : Form
    {
        private int stream;
        private Dictionary<int, string> plugins;
        private float volume = 1f;
        
        private const string txtCustomRadioDefaultText = "Pegar stream url...";
        private ThumbnailToolBarButton thumbnailBtnMute;
        private ThumbnailToolBarButton thumbnailBtnStop;

        public RadioStation()
        {
            InitializeComponent();

            if (!Bass.LoadMe())
                MessageBox.Show("No se cargó la libreria Bass.");

            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
                MessageBox.Show("No se pudo inicializar la salida de audio.");
            
            plugins = Bass.BASS_PluginLoadDirectory(Path.Combine(Application.StartupPath, "addons"));

            thumbnailBtnMute = new ThumbnailToolBarButton(Properties.Resources.speaker_icon, "Silenciar");
            thumbnailBtnMute.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(thumbnailBtnMute_Click);
            thumbnailBtnStop = new ThumbnailToolBarButton(Properties.Resources.stop_icon, "Detener");
            thumbnailBtnStop.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(btnStopStream_Click);
            thumbnailBtnStop.Enabled = false;
            TaskbarManager.Instance.ThumbnailToolBars.AddButtons(Handle, thumbnailBtnMute, thumbnailBtnStop);
        }

        private void RadioStation_Load(object sender, EventArgs e)
        {
            
        }

        private void OpenRadioStream(string streamUrl, string description)
        {
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelStop(stream);

            stream = Bass.BASS_StreamCreateURL(streamUrl, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

            if (stream != 0)
            {
                Bass.BASS_ChannelPlay(stream, false);
                Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume);
                txtMessage.Text = "Estás escuchando " + description;

                imgEqualizer.Visible = true;
                btnStopStream.Enabled = true;
                thumbnailBtnStop.Enabled = true;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate, Handle);
            }
            else
                txtMessage.Text = "La url expiró o es incorrecta (" + Bass.BASS_ErrorGetCode().ToString() + ")";
        }

        private void btnLaRed_Click(object sender, EventArgs e)
        {
            btnLaRed.Enabled = false;
            OpenRadioStream(RadioCollection.Radio["laRed"], "Radio LaRed AM 910");

            if (!btnContinental.Enabled)
                btnContinental.Enabled = true;

            ResetRadiosPopup();
        }

        private void btnContinental_Click(object sender, EventArgs e)
        {
            btnContinental.Enabled = false;
            OpenRadioStream(RadioCollection.Radio["continental"], "Radio Continental AM 590");

            if (!btnLaRed.Enabled)
                btnLaRed.Enabled = true;

            ResetRadiosPopup();
        }

        private void btnCustomRadio_Click(object sender, EventArgs e)
        {
            OpenRadioStream(txtCustomRadio.Text, "personalizada");
            ResetButtonsOfRadioStreams();
        }

        private void StopRadioStream()
        {
            Bass.BASS_ChannelStop(stream);
            txtMessage.Text = "-";

            ResetButtonsOfRadioStreams();
            imgEqualizer.Visible = false;
            btnStopStream.Enabled = false;
            thumbnailBtnStop.Enabled = false;
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error, Handle);
            TaskbarManager.Instance.SetProgressValue(100, 100, Handle);
        }

        private void btnStopStream_Click(object sender, EventArgs e)
        {
            StopRadioStream();
        }

        private void thumbnailBtnStop_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            StopRadioStream();
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
            MuteRadioStream();
        }

        private void thumbnailBtnMute_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            MuteRadioStream();
        }

        private void MuteRadioStream()
        {
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelGetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, ref volume);
                if (volume == 0f)
                {
                    btnMute.Image = Properties.Resources.speaker_v2;
                    thumbnailBtnMute.Icon = Properties.Resources.speaker_icon;
                    thumbnailBtnMute.Tooltip = "Silenciar";
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume = 1f);
                }
                else
                {
                    btnMute.Image = Properties.Resources.speaker_mute_v2;
                    thumbnailBtnMute.Icon = Properties.Resources.speaker_mute_icon;
                    thumbnailBtnMute.Tooltip = "Encender";
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume = 0f);
                }
            }
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

            OpenRadioStream(RadioCollection.Radio[currentMenuItem.Name], currentMenuItem.Text);
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

        private void RadioStation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_StreamFree(stream);
            Bass.BASS_Free();

            foreach (int plugin in plugins.Keys)
                Bass.BASS_PluginFree(plugin);
        }
    }
}