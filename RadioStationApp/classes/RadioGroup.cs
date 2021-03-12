using RadioStationApp.classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                Url = "https://latamstreaming-live-os.akamaized.net/live_passthrough/amlared/chunks.m3u8",
                Icon = Path.Combine(startupPath, "laRed.ico"),
                Command = _CommandPrefix + "49675"
            });

            Stations.Add(RadioNames.Continental, new Radio()
            {
                Description = "Continental AM 590",
                Url = "https://20823.live.streamtheworld.com/CONTINENTAL_SC",
                Icon = Path.Combine(startupPath, "continental.ico"),
                Command = _CommandPrefix + "49676"
            });

            Stations.Add(RadioNames.Metro, new Radio()
            {
                Description = "Metro FM 95.1",
                Url = "http://mp3.metroaudio1.stream.avstreaming.net:7200/metro",
                Icon = Path.Combine(startupPath, "metro.ico"),
                Command = _CommandPrefix + "49677"
            });

            Stations.Add(RadioNames.Mitre, new Radio()
            {
                Description = "Mitre AM 1100",
                Url = "http://turadioenvivo.com:11031/stream",
                Icon = Path.Combine(startupPath, "radioMitre.ico"),
                Command = _CommandPrefix + "49678"
            });

            Stations.Add(RadioNames.Vorterix, new Radio()
            {
                Description = "Vorterix FM 92.1",
                Url = "http://104.131.4.100:8000/stream",
                Icon = Path.Combine(startupPath, "vorterix.ico"),
                Command = _CommandPrefix + "49679"
            });

            Stations.Add(RadioNames.DelPlata, new Radio()
            {
                Description = "Del plata AM 1030",
                Url = "http://181.119.157.98:8000/amdelplata.mp3",
                Icon = Path.Combine(startupPath, "delPlata.ico"),
                Command = _CommandPrefix + "49680"
            });

            Stations.Add(RadioNames.ElDestape, new Radio()
            {
                Description = "El destape FM 107.3",
                Url = "https://cdn2.instream.audio/:8000/stream",
                Icon = Path.Combine(startupPath, "elDestape.ico"),
                Command = _CommandPrefix + "49681"
            });

            Stations.Add(RadioNames.Rivadavia, new Radio()
            {
                Description = "Rivadavia AM 630",
                Url = "https://18743.live.streamtheworld.com/RIVADAVIAAAC.aac",
                Icon = Path.Combine(startupPath, "radioRivadavia.ico"),
                Command = _CommandPrefix + "49682"
            });

            Stations.Add(RadioNames.Latina, new Radio()
            {
                Description = "Latina FM 101.1",
                Url = "http://streaming.latina101.com.ar:8080/RadioLatina",
                Icon = Path.Combine(startupPath, "radioLatina.ico"),
                Command = _CommandPrefix + "49683"
            });

            Stations.Add(RadioNames.CNN, new Radio()
            {
                Description = "CNN argentina AM 950",
                Url = "http://estudio.cnnradioargentina.com.ar:8000/stream",
                Icon = Path.Combine(startupPath, "cnnRadioArgentina.ico"),
                Command = _CommandPrefix + "49684"
            });
        }
    }
}