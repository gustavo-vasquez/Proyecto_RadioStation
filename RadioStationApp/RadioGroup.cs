using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioStationApp
{
    public class RadioGroup
    {
        public static Dictionary<string, string> Radios = new Dictionary<string, string>()
        {
            {"laRed", "https://la_red.secure2.footprint.net/egress/bhandler/streamroot_lsd2latam/la_red/chunklist_b32768.m3u8"},
            {"continental", "https://20823.live.streamtheworld.com/CONTINENTAL_SC"},
            {"metro", "http://mp3.metroaudio1.stream.avstreaming.net:7200/metro"},
            {"radioMitre", "http://turadioenvivo.com:11031/stream"},
            {"vorterix", "http://147.135.11.82:9904/;"},
            {"delPlata", "http://181.119.157.98:8000/amdelplata.mp3"},
            {"elDestape", "https://s2.radio.co/s120d8d180/listen"},
            {"radioRivadavia", "http://209.95.35.49:7012/live"},
            {"radioLatina", "http://streaming.latina101.com.ar:8080/RadioLatina"},
            {"cnnRadioArgentina", "http://estudio.cnnradioargentina.com.ar:8000/stream"}
        };

        public static Dictionary<string, RadioData> Stations = new Dictionary<string, RadioData>()
        {
            {
                "laRed", new RadioData()
                {
                    Name = "laRed",
                    Description = "La red AM 910",
                    Url = "https://la_red.secure2.footprint.net/egress/bhandler/streamroot_lsd2latam/la_red/chunklist_b32768.m3u8",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "laRed.ico")
                }
            },
            {
                "continental", new RadioData()
                {
                    Name = "continental",
                    Description = "Radio continental AM 590",
                    Url = "https://20823.live.streamtheworld.com/CONTINENTAL_SC",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "continental.ico")
                }
            },
            {
                "metro", new RadioData()
                {
                    Name = "metro",
                    Description = "Metro 95.1",
                    Url = "http://mp3.metroaudio1.stream.avstreaming.net:7200/metro",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "metro.ico")
                }
            },
            {
                "radioMitre", new RadioData()
                {
                    Name = "radioMitre",
                    Description = "Radio mitre AM 1100",
                    Url = "http://turadioenvivo.com:11031/stream",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "radioMitre.ico")
                }
            },
            {
                "vorterix", new RadioData()
                {
                    Name = "vorterix",
                    Description = "Vorterix",
                    Url = "http://147.135.11.82:9904/;",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "vorterix.ico")
                }
            },
            {
                "delPlata", new RadioData()
                {
                    Name = "delPlata",
                    Description = "Del plata AM 1030",
                    Url = "http://181.119.157.98:8000/amdelplata.mp3",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "delPlata.ico")
                }
            },
            {
                "elDestape", new RadioData()
                {
                    Name = "elDestape",
                    Description = "El destape",
                    Url = "https://s2.radio.co/s120d8d180/listen",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "elDestape.ico")
                }
            },
            {
                "radioRivadavia", new RadioData()
                {
                    Name = "radioRivadavia",
                    Description = "Radio rivadavia AM 630",
                    Url = "http://209.95.35.49:7012/live",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "radioRivadavia.ico")
                }
            },
            {
                "radioLatina", new RadioData()
                {
                    Name = "radioLatina",
                    Description = "Radio latina FM 101.1",
                    Url = "http://streaming.latina101.com.ar:8080/RadioLatina",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "radioLatina.ico")
                }
            },
            {
                "cnnRadioArgentina", new RadioData()
                {
                    Name = "cnnRadioArgentina",
                    Description = "CNN radio argentina",
                    Url = "http://estudio.cnnradioargentina.com.ar:8000/stream",
                    Icon = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "radios", "cnnRadioArgentina.ico")
                }
            }
        };

        //public List<RadioData> Stations { get; set; }

        //public RadioGroup()
        //{
        //    Stations = new List<RadioData>();
        //    string path = Path.Combine(Application.StartupPath, @"..\..", "resources", "icons", "stations");

        //    Stations.Add(new RadioData()
        //    {
        //        Name = "laRed",
        //        Description = "La red AM 910",
        //        Url = "https://la_red.secure2.footprint.net/egress/bhandler/streamroot_lsd2latam/la_red/chunklist_b32768.m3u8",
        //        Icon = Path.Combine(path, "laRed.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "continental",
        //        Description = "Radio continental AM 590",
        //        Url = "https://20823.live.streamtheworld.com/CONTINENTAL_SC",
        //        Icon = Path.Combine(path, "continental.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "metro",
        //        Description = "Metro 95.1",
        //        Url = "http://mp3.metroaudio1.stream.avstreaming.net:7200/metro",
        //        Icon = Path.Combine(path, "metro.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "radioMitre",
        //        Description = "Radio mitre AM 1100",
        //        Url = "http://turadioenvivo.com:11031/stream",
        //        Icon = Path.Combine(path, "radioMitre.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "vorterix",
        //        Description = "Vorterix",
        //        Url = "http://147.135.11.82:9904/;",
        //        Icon = Path.Combine(path, "vorterix.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "delPlata",
        //        Description = "Del plata AM 1030",
        //        Url = "http://181.119.157.98:8000/amdelplata.mp3",
        //        Icon = Path.Combine(path, "delPlata.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "elDestape",
        //        Description = "El destape",
        //        Url = "https://s2.radio.co/s120d8d180/listen",
        //        Icon = Path.Combine(path, "elDestape.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "radioRivadavia",
        //        Description = "Radio rivadavia AM 630",
        //        Url = "http://209.95.35.49:7012/live",
        //        Icon = Path.Combine(path, "radioRivadavia.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "radioLatina",
        //        Description = "Radio latina FM 101.1",
        //        Url = "http://streaming.latina101.com.ar:8080/RadioLatina",
        //        Icon = Path.Combine(path, "radioLatina.ico")
        //    });
        //    Stations.Add(new RadioData()
        //    {
        //        Name = "cnnRadioArgentina",
        //        Description = "CNN radio argentina",
        //        Url = "http://estudio.cnnradioargentina.com.ar:8000/stream",
        //        Icon = Path.Combine(path, "cnnRadioArgentina.ico")
        //    });
        //}
    }

    public class RadioData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}