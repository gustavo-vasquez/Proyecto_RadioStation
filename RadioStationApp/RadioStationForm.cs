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
        private string[] _args = Environment.GetCommandLineArgs();
        private int _stream;
        private Dictionary<int, string> _plugins;
        private float _volume = 1f;
        private const string _customRadioPlaceHolder = "Pegar stream url...";
        private ThumbnailToolBarButton muteThumbnailButton;
        private ThumbnailToolBarButton stopThumbnailButton;

        public RadioStation()
        {
            InitializeComponent();
            InitializeBASSLibrary(true);
            CreateThumbnailControls();
        }

        private void RadioStation_Load(object sender, EventArgs e)
        {
            CheckLineArguments();
        }

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

            PlayRadioStream(RadioGroup.Stations[currentMenuItem.Name].Url, RadioGroup.Stations[currentMenuItem.Name].Description);
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
            FreeBASSResources();
        }

        #region LIBRARY RESOURCES

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

        private void CreateThumbnailControls()
        {
            muteThumbnailButton = new ThumbnailToolBarButton(Properties.Resources.speaker_icon, "Silenciar");
            muteThumbnailButton.Click += (sender, args) => { MuteRadioStream(); };

            stopThumbnailButton = new ThumbnailToolBarButton(Properties.Resources.stop_icon, "Detener");
            stopThumbnailButton.Click += (sender, args) => { StopRadioStream(); };

            stopThumbnailButton.Enabled = false;
            TaskbarManager.Instance.ThumbnailToolBars.AddButtons(Handle, muteThumbnailButton, stopThumbnailButton);

            JumpList jumplist = JumpList.CreateJumpListForIndividualWindow(TaskbarManager.Instance.ApplicationId, IntPtr.Zero);
            JumpListCustomCategory category = new JumpListCustomCategory("Radios");
            List<JumpListLink> items = new List<JumpListLink>();

            foreach (KeyValuePair<string, RadioData> radio in RadioGroup.Stations)
            {
                items.Add(new JumpListLink(Assembly.GetEntryAssembly().Location, radio.Value.Description)
                {
                    IconReference = new Microsoft.WindowsAPICodePack.Shell.IconReference(radio.Value.Icon, 0),
                    Arguments = "-" + radio.Value.Name
                });
            }

            category.AddJumpListItems(items.ToArray());
            jumplist.AddCustomCategories(category);
            jumplist.Refresh();
        }

        private void CheckLineArguments()
        {
            if (_args.Length > 1)
            {
                switch (_args[1])
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

        #region STREAM ACTIONS

        private void PlayRadioStream(string streamUrl, string description)
        {
            if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
                StopRadioStream();

            _stream = Bass.BASS_StreamCreateURL(streamUrl, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

            if (_stream != 0)
            {
                Bass.BASS_ChannelPlay(_stream, false);
                Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, _volume);

                txtMessage.Text = "Estás escuchando " + description;
                imgEqualizer.Visible = btnStopStream.Enabled = stopThumbnailButton.Enabled = true;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate, Handle);
            }
            else
                txtMessage.Text = "La url expiró o es incorrecta (" + Bass.BASS_ErrorGetCode().ToString() + ")";
        }

        private void StopRadioStream()
        {
            Bass.BASS_ChannelStop(_stream);

            txtMessage.Text = "-";
            ResetButtonsOfRadioStreams();
            imgEqualizer.Visible = btnStopStream.Enabled = stopThumbnailButton.Enabled = false;
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
                    btnMute.Image = Properties.Resources.speaker_v2;
                    muteThumbnailButton.Icon = Properties.Resources.speaker_icon;
                    muteThumbnailButton.Tooltip = "Silenciar";
                    Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, _volume = 1f);
                }
                else
                {
                    btnMute.Image = Properties.Resources.speaker_mute_v2;
                    muteThumbnailButton.Icon = Properties.Resources.speaker_mute_icon;
                    muteThumbnailButton.Tooltip = "Encender";
                    Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, _volume = 0f);
                }
            }
        }

        #endregion
    }
}