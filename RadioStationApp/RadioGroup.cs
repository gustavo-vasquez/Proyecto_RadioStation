﻿using System;
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
        private const string _CommandPrefix = "__JumpListCommand:";
        public static Dictionary<string, RadioData> Stations = new Dictionary<string, RadioData>()
        {
            {
                "laRed", new RadioData()
                {
                    Command = _CommandPrefix + "49675",
                    Description = "La red AM 910",
                    Url = "https://lared_ar.secure2.footprint.net/egress/bhandler/streamroot_lsd2latam/lared_ar/chunklist_b32768.m3u8",
                    Icon = Path.Combine(Application.StartupPath, "icons", "laRed.ico")
                }
            },
            {
                "continental", new RadioData()
                {
                    Command = _CommandPrefix + "49676",
                    Description = "Radio continental AM 590",
                    Url = "https://20823.live.streamtheworld.com/CONTINENTAL_SC",
                    Icon = Path.Combine(Application.StartupPath, "icons", "continental.ico")
                }
            },
            {
                "metro", new RadioData()
                {
                    Command = _CommandPrefix + "49677",
                    Description = "Metro 95.1",
                    Url = "http://mp3.metroaudio1.stream.avstreaming.net:7200/metro",
                    Icon = Path.Combine(Application.StartupPath, "icons", "metro.ico")
                }
            },
            {
                "radioMitre", new RadioData()
                {
                    Command = _CommandPrefix + "49678",
                    Description = "Radio mitre AM 1100",
                    Url = "http://turadioenvivo.com:11031/stream",
                    Icon = Path.Combine(Application.StartupPath, "icons", "radioMitre.ico")
                }
            },
            {
                "vorterix", new RadioData()
                {
                    Command = _CommandPrefix + "49679",
                    Description = "Vorterix",
                    Url = "http://147.135.11.82:9904/;",
                    Icon = Path.Combine(Application.StartupPath, "icons", "vorterix.ico")
                }
            },
            {
                "delPlata", new RadioData()
                {
                    Command = _CommandPrefix + "49680",
                    Description = "Del plata AM 1030",
                    Url = "http://181.119.157.98:8000/amdelplata.mp3",
                    Icon = Path.Combine(Application.StartupPath, "icons", "delPlata.ico")
                }
            },
            {
                "elDestape", new RadioData()
                {
                    Command = _CommandPrefix + "49681",
                    Description = "El destape",
                    Url = "https://s2.radio.co/s120d8d180/listen",
                    Icon = Path.Combine(Application.StartupPath, "icons", "elDestape.ico")
                }
            },
            {
                "radioRivadavia", new RadioData()
                {
                    Command = _CommandPrefix + "49682",
                    Description = "Radio rivadavia AM 630",
                    Url = "http://209.95.35.49:7012/live",
                    Icon = Path.Combine(Application.StartupPath, "icons", "radioRivadavia.ico")
                }
            },
            {
                "radioLatina", new RadioData()
                {
                    Command = _CommandPrefix + "49683",
                    Description = "Radio latina FM 101.1",
                    Url = "http://streaming.latina101.com.ar:8080/RadioLatina",
                    Icon = Path.Combine(Application.StartupPath, "icons", "radioLatina.ico")
                }
            },
            {
                "cnnRadioArgentina", new RadioData()
                {
                    Command = _CommandPrefix + "49684",
                    Description = "CNN radio argentina",
                    Url = "http://estudio.cnnradioargentina.com.ar:8000/stream",
                    Icon = Path.Combine(Application.StartupPath, "icons", "cnnRadioArgentina.ico")
                }
            }
        };
    }

    public class RadioData
    {
        public string Command { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}