using JumpListHelpers;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Un4seen.Bass;

namespace RadioStationApp
{
    public partial class RadioStation : JumpListMainFormBase
    {
        private string[] _args = Environment.GetCommandLineArgs();
        private int _stream;
        private Dictionary<int, string> _plugins;
        private float _volume = 1f;
        private string _previousStreamUrl, _previousStreamDescription;
        private string _currentStreamUrl, _currentStreamDescription;
        private const string _customRadioPlaceHolder = "Pegar stream url...";
        private ThumbnailToolBarButton muteThumbnailButton;
        private ThumbnailToolBarButton previousThumbnailButton;
        private ThumbnailToolBarButton stopThumbnailButton;

        public RadioStation()
        {
            InitializeComponent();
            InitializeBASSLibrary(true);
            InitializeTaskbarControls();
            MouseWheel += trackBarVolume_MouseWheel;
            trackBarVolume.MouseWheel += trackBarVolume_MouseWheel;
        }

        #region Form events

        private void btnLaRed_Click(object sender, EventArgs e)
        {   
            PlayRadioStream(RadioGroup.Stations["laRed"].Url, RadioGroup.Stations["laRed"].Description);
            btnLaRed.Enabled = false;

            if (!btnContinental.Enabled)
                btnContinental.Enabled = true;

            ResetRadiosPopup();
        }

        private void btnContinental_Click(object sender, EventArgs e)
        {
            PlayRadioStream(RadioGroup.Stations["continental"].Url, RadioGroup.Stations["continental"].Description);
            btnContinental.Enabled = false;

            if (!btnLaRed.Enabled)
                btnLaRed.Enabled = true;

            ResetRadiosPopup();
        }

        private void btnCustomRadio_Click(object sender, EventArgs e)
        {
            PlayRadioStream(txtCustomRadio.Text, "personalizada");
            ResetButtonsOfRadioStreams();
        }

        private void btnStopStream_Click(object sender, EventArgs e)
        {
            StopRadioStream();
        }

        private void btnRadios_Click(object sender, EventArgs e)
        {
            Button menuButton = sender as Button;
            cmsRadiosPopup.Show(menuButton, new Point(0, 0));
        }

        private void txtCustomRadio_Enter(object sender, EventArgs e)
        {
            if (txtCustomRadio.Text.Equals(_customRadioPlaceHolder))
            {
                txtCustomRadio.Text = string.Empty;
                txtCustomRadio.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtCustomRadio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomRadio.Text))
            {
                txtCustomRadio.Text = _customRadioPlaceHolder;
                txtCustomRadio.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            MuteRadioStream();
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            string appInfoText = string.Join(
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

            PlayRadioStream(RadioGroup.Stations[currentMenuItem.Name].Url, RadioGroup.Stations[currentMenuItem.Name].Description);
            currentMenuItem.Enabled = false;
            btnLaRed.Enabled = btnContinental.Enabled = true;
        }

        private void RadioStation_FormClosing(object sender, FormClosingEventArgs e)
        {
            FreeBASSResources();
        }

        #endregion

        #region Library resources

        private void InitializeBASSLibrary(bool enablePlugins)
        {
            if (!Bass.LoadMe())
                MessageBox.Show("No se cargó la libreria Bass.");

            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
                MessageBox.Show("No se pudo inicializar la salida de audio.");

            if (enablePlugins)
                _plugins = Bass.BASS_PluginLoadDirectory(Path.Combine(Application.StartupPath, "addons"));
        }

        private void FreeBASSResources()
        {
            Bass.BASS_StreamFree(_stream);
            Bass.BASS_Free();

            if (_plugins != null)
                foreach (int plugin in _plugins.Keys)
                    Bass.BASS_PluginFree(plugin);
        }

        #endregion

        #region Form actions

        private void InitializeTaskbarControls()
        {
            muteThumbnailButton = new ThumbnailToolBarButton(Properties.Resources.speaker, "Silenciar");
            muteThumbnailButton.Click += (sender, args) => { MuteRadioStream(); };

            previousThumbnailButton = new ThumbnailToolBarButton(Properties.Resources.previous, "Sintonizar radio anterior");
            previousThumbnailButton.Click += (sender, args) => { if (_previousStreamUrl != null && _previousStreamDescription != null) PlayRadioStream(_previousStreamUrl, _previousStreamDescription); };

            stopThumbnailButton = new ThumbnailToolBarButton(Properties.Resources.stop, "Detener");
            stopThumbnailButton.Click += (sender, args) => { StopRadioStream(); };
            stopThumbnailButton.Enabled = false;

            TaskbarManager.Instance.ThumbnailToolBars.AddButtons(Handle, muteThumbnailButton, previousThumbnailButton, stopThumbnailButton);

            this.JumpListCommandReceived += (sender, e) =>
            {
                CheckLineArguments(e.CommandName);
                this.WindowState = FormWindowState.Minimized;
            };

            this.Shown += (sender, e) =>
            {
                string categoryName = "Radios";

                foreach (KeyValuePair<string, RadioData> radio in RadioGroup.Stations)
                {
                    JumpListManager.AddCategorySelfLink(
                            categoryName,
                            radio.Value.Description,
                            "-" + radio.Key,
                            radio.Value.Icon,
                            0
                        );
                }

                JumpListManager.Refresh();

                if (_args.Length > 1)
                    foreach (KeyValuePair<string, RadioData> radio in RadioGroup.Stations)
                        if (_args[1] == radio.Value.Command)
                            CheckLineArguments("-" + radio.Key);
            };
        }

        private void CheckLineArguments(string commandLine)
        {
            if (!string.IsNullOrWhiteSpace(commandLine))
            {
                switch (commandLine)
                {
                    case "-laRed":
                        btnLaRed.PerformClick();
                        break;
                    case "-continental":
                        btnContinental.PerformClick();
                        break;
                    case "-metro":
                        cmsRadiosPopup.Items[0].PerformClick();
                        break;
                    case "-radioMitre":
                        cmsRadiosPopup.Items[1].PerformClick();
                        break;
                    case "-vorterix":
                        cmsRadiosPopup.Items[2].PerformClick();
                        break;
                    case "-delPlata":
                        cmsRadiosPopup.Items[3].PerformClick();
                        break;
                    case "-elDestape":
                        cmsRadiosPopup.Items[4].PerformClick();
                        break;
                    case "-radioRivadavia":
                        cmsRadiosPopup.Items[5].PerformClick();
                        break;
                    case "-radioLatina":
                        cmsRadiosPopup.Items[6].PerformClick();
                        break;
                    case "-cnnRadioArgentina":
                        cmsRadiosPopup.Items[7].PerformClick();
                        break;
                    default:
                        break;
                }
            }
        }

        private void ResetButtonsOfRadioStreams()
        {
            if (!btnLaRed.Enabled)
                btnLaRed.Enabled = true;

            if (!btnContinental.Enabled)
                btnContinental.Enabled = true;

            ResetRadiosPopup();
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

        #endregion

        #region Stream playback actions

        private void PlayRadioStream(string streamUrl, string description)
        {
            if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
                StopRadioStream();

            _stream = Bass.BASS_StreamCreateURL(streamUrl, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

            if (_stream != 0)
            {
                Bass.BASS_ChannelPlay(_stream, false);
                Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, _volume);
                _currentStreamUrl = streamUrl;
                _currentStreamDescription = description;

                txtMessage.Text = "Estás escuchando " + description;
                imgEqualizer.Visible = btnStopStream.Enabled = trackBarVolume.Enabled = stopThumbnailButton.Enabled = true;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate, Handle);
                TaskbarManager.Instance.SetOverlayIcon(Properties.Resources.play_status, "streaming");
            }
            else
                txtMessage.Text = "La url expiró o es incorrecta (" + Bass.BASS_ErrorGetCode().ToString() + ")";
        }

        private void StopRadioStream()
        {
            Bass.BASS_ChannelStop(_stream);
            _previousStreamUrl = _currentStreamUrl;
            _previousStreamDescription = _currentStreamDescription;

            txtMessage.Text = "";
            ResetButtonsOfRadioStreams();
            imgEqualizer.Visible = btnStopStream.Enabled = trackBarVolume.Enabled = stopThumbnailButton.Enabled = false;
            TaskbarManager.Instance.SetOverlayIcon(Properties.Resources.stop_status, "Stop");
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error, Handle);
            TaskbarManager.Instance.SetProgressValue(100, 100, Handle);
        }

        private void MuteRadioStream()
        {
            if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelGetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, ref _volume);
                if (_volume == 0f)
                {
                    btnMute.Image = Properties.Resources.speaker_button;
                    muteThumbnailButton.Icon = Properties.Resources.speaker;
                    muteThumbnailButton.Tooltip = "Silenciar";
                    trackBarVolume.Enabled = true;
                    Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, _volume = (float)trackBarVolume.Value / 100);
                }
                else
                {
                    btnMute.Image = Properties.Resources.speaker_mute_button;
                    muteThumbnailButton.Icon = Properties.Resources.speaker_mute;
                    muteThumbnailButton.Tooltip = "Encender";
                    trackBarVolume.Enabled = false;
                    Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, _volume = 0f);
                }
            }
        }

        #endregion

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            TrackBar volumeBar = (TrackBar)sender;
            labelVolume.Text = volumeBar.Value.ToString();
            Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, _volume = (float)volumeBar.Value / 100);
        }

        private void trackBarVolume_MouseWheel(object sender, MouseEventArgs e)
        {
            int newVolume = trackBarVolume.Value;

            try
            {
                ((HandledMouseEventArgs)e).Handled = true; // disable default mouse wheel
                
                if (e.Delta > 0)
                {
                    if (trackBarVolume.Value < trackBarVolume.Maximum)
                        newVolume = trackBarVolume.Value + 5;
                }
                else
                {
                    if (trackBarVolume.Value > trackBarVolume.Minimum)
                        newVolume = trackBarVolume.Value - 5;
                }

                trackBarVolume.Value = newVolume;
            }
            catch (Exception error)
            {
                if (error is ArgumentOutOfRangeException)
                {
                    if (newVolume < trackBarVolume.Minimum)
                        trackBarVolume.Value = 0;
                    else if (newVolume > trackBarVolume.Maximum)
                        trackBarVolume.Value = 100;
                }
            }
        }
    }
}
