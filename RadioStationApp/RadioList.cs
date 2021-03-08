using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioStationApp
{
    class RadioList
    {
        private const string _CommandPrefix = "__JumpListCommand:";
        private static string startupPath { get; set; }
        public static RadioData LaRed { get; set; }
        public static RadioData Continental { get; set; }
        public static RadioData Metro { get; set; }
        public static RadioData Mitre { get; set; }
        public static RadioData Vorterix { get; set; }
        public static RadioData DelPlata { get; set; }
        public static RadioData ElDestape { get; set; }
        public static RadioData Rivadavia { get; set; }
        public static RadioData Latina { get; set; }
        public static RadioData CNN { get; set; }

        static RadioList()
        {
            startupPath = Application.StartupPath;

            LaRed.Description = "La red AM 910";
            LaRed.Url = "https://latamstreaming-live-os.akamaized.net/live_passthrough/amlared/chunks.m3u8";
            LaRed.Icon = Path.Combine(startupPath, "icons", "laRed.ico");
            LaRed.Command = _CommandPrefix + "49675";

            Continental.Description = "Radio continental AM 590";
            Continental.Url = "https://20823.live.streamtheworld.com/CONTINENTAL_SC";
            Continental.Icon = Path.Combine(startupPath, "icons", "continental.ico");
            Continental.Command = _CommandPrefix + "49676";

            Metro.Description = "Metro 95.1";
            Metro.Url = "http://mp3.metroaudio1.stream.avstreaming.net:7200/metro";
            Metro.Icon = Path.Combine(startupPath, "icons", "metro.ico");
            Metro.Command = _CommandPrefix + "49677";

            Mitre.Description = "Radio mitre AM 1100";
            Mitre.Url = "http://turadioenvivo.com:11031/stream";
            Mitre.Icon = Path.Combine(startupPath, "icons", "radioMitre.ico");
            Mitre.Command = _CommandPrefix + "49678";

            Vorterix.Description = "Vorterix";
            Vorterix.Url = "http://104.131.4.100:8000/stream";
            Vorterix.Icon = Path.Combine(startupPath, "icons", "vorterix.ico");
            Vorterix.Command = _CommandPrefix + "49679";

            DelPlata.Description = "Del plata AM 1030";
            DelPlata.Url = "http://181.119.157.98:8000/amdelplata.mp3";
            DelPlata.Icon = Path.Combine(startupPath, "icons", "delPlata.ico");
            DelPlata.Command = _CommandPrefix + "49680";

            ElDestape.Description = "El destape";
            ElDestape.Url = "https://cdn2.instream.audio/:8000/stream";
            ElDestape.Icon = Path.Combine(startupPath, "icons", "elDestape.ico");
            ElDestape.Command = _CommandPrefix + "49681";

            Rivadavia.Description = "Radio rivadavia AM 630";
            Rivadavia.Url = "https://18743.live.streamtheworld.com/RIVADAVIAAAC.aac";
            Rivadavia.Icon = Path.Combine(startupPath, "icons", "radioRivadavia.ico");
            Rivadavia.Command = _CommandPrefix + "49682";

            Latina.Description = "Radio latina FM 101.1";
            Latina.Url = "http://streaming.latina101.com.ar:8080/RadioLatina";
            Latina.Icon = Path.Combine(startupPath, "icons", "radioLatina.ico");
            Latina.Command = _CommandPrefix + "49683";

            CNN.Description = "CNN radio argentina";
            CNN.Url = "http://estudio.cnnradioargentina.com.ar:8000/stream";
            CNN.Icon = Path.Combine(startupPath, "icons", "cnnRadioArgentina.ico");
            CNN.Command = _CommandPrefix + "49684";
        }
    }
}
