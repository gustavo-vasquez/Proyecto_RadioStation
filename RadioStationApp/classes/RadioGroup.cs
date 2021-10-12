using Newtonsoft.Json;
using RadioStationApp.classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioStationApp.classes
{
    public class RadioGroup
    {
        private const string _CommandPrefix = "__JumpListCommand:";
        public static Dictionary<string, Radio> Stations { get; set; }

        static RadioGroup()
        {
            string startupPath = Path.Combine(Application.StartupPath, "icons");
            Stations = new Dictionary<string, Radio>();

            Stations.Add(RadioNames.LaRed, new Radio()
            {
                Description = "La red AM 910",
                Url = Properties.Settings.Default.laRed,
                Icon = Path.Combine(startupPath, "laRed.ico"),
                Command = _CommandPrefix + "49675"
            });

            Stations.Add(RadioNames.Continental, new Radio()
            {
                Description = "Continental AM 590",
                Url = Properties.Settings.Default.continental,
                Icon = Path.Combine(startupPath, "continental.ico"),
                Command = _CommandPrefix + "49676"
            });

            Stations.Add(RadioNames.Metro, new Radio()
            {
                Description = "Metro FM 95.1",
                Url = Properties.Settings.Default.metro,
                Icon = Path.Combine(startupPath, "metro.ico"),
                Command = _CommandPrefix + "49677"
            });

            Stations.Add(RadioNames.Mitre, new Radio()
            {
                Description = "Mitre AM 1100",
                Url = Properties.Settings.Default.mitre,
                Icon = Path.Combine(startupPath, "radioMitre.ico"),
                Command = _CommandPrefix + "49678"
            });

            Stations.Add(RadioNames.Vorterix, new Radio()
            {
                Description = "Vorterix FM 92.1",
                Url = Properties.Settings.Default.vorterix,
                Icon = Path.Combine(startupPath, "vorterix.ico"),
                Command = _CommandPrefix + "49679"
            });

            Stations.Add(RadioNames.DelPlata, new Radio()
            {
                Description = "Del plata AM 1030",
                Url = Properties.Settings.Default.delPlata,
                Icon = Path.Combine(startupPath, "delPlata.ico"),
                Command = _CommandPrefix + "49680"
            });

            Stations.Add(RadioNames.ElDestape, new Radio()
            {
                Description = "El destape FM 107.3",
                Url = Properties.Settings.Default.elDestape,
                Icon = Path.Combine(startupPath, "elDestape.ico"),
                Command = _CommandPrefix + "49681"
            });

            Stations.Add(RadioNames.Rivadavia, new Radio()
            {
                Description = "Rivadavia AM 630",
                Url = Properties.Settings.Default.rivadavia,
                Icon = Path.Combine(startupPath, "radioRivadavia.ico"),
                Command = _CommandPrefix + "49682"
            });

            Stations.Add(RadioNames.Latina, new Radio()
            {
                Description = "Latina FM 101.1",
                Url = Properties.Settings.Default.latina,
                Icon = Path.Combine(startupPath, "radioLatina.ico"),
                Command = _CommandPrefix + "49683"
            });

            Stations.Add(RadioNames.CNN, new Radio()
            {
                Description = "CNN argentina AM 950",
                Url = Properties.Settings.Default.cnn,
                Icon = Path.Combine(startupPath, "cnnRadioArgentina.ico"),
                Command = _CommandPrefix + "49684"
            });
        }

        private async static Task<IEnumerable<ExternalRadioData>> GetUpdatedList()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("https://drive.google.com/uc?id=1f479S7N65hQhsIUrC8ubbogQMP5VGGHr");
            List<ExternalRadioData> updatedList = JsonConvert.DeserializeObject<List<ExternalRadioData>>(result);

            return updatedList;
        }

        public async static Task<string> UpdateRadioLinks()
        {
            try
            {
                IEnumerable<ExternalRadioData> updatedRadioList = await GetUpdatedList();

                foreach (ExternalRadioData radio in updatedRadioList)
                {
                    switch (radio.Name)
                    {
                        case RadioNames.LaRed:
                            Stations[RadioNames.LaRed].Url = Properties.Settings.Default.laRed = radio.Url;
                            break;
                        case RadioNames.Continental:
                            Stations[RadioNames.Continental].Url = Properties.Settings.Default.continental = radio.Url;
                            break;
                        case RadioNames.Metro:
                            Stations[RadioNames.Metro].Url = Properties.Settings.Default.metro = radio.Url;
                            break;
                        case RadioNames.Mitre:
                            Stations[RadioNames.Mitre].Url = Properties.Settings.Default.mitre = radio.Url;
                            break;
                        case RadioNames.Vorterix:
                            Stations[RadioNames.Vorterix].Url = Properties.Settings.Default.vorterix = radio.Url;
                            break;
                        case RadioNames.DelPlata:
                            Stations[RadioNames.DelPlata].Url = Properties.Settings.Default.delPlata = radio.Url;
                            break;
                        case RadioNames.ElDestape:
                            Stations[RadioNames.ElDestape].Url = Properties.Settings.Default.elDestape = radio.Url;
                            break;
                        case RadioNames.Rivadavia:
                            Stations[RadioNames.Rivadavia].Url = Properties.Settings.Default.rivadavia = radio.Url;
                            break;
                        case RadioNames.Latina:
                            Stations[RadioNames.Latina].Url = Properties.Settings.Default.latina = radio.Url;
                            break;
                        case RadioNames.CNN:
                            Stations[RadioNames.CNN].Url = Properties.Settings.Default.cnn = radio.Url;
                            break;
                        default:
                            break;
                    }
                }

                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();

                return "Enlaces actualizados.";
            }
            catch
            {
                return "Error al actualizar enlaces.";
            }
        }
    }
}