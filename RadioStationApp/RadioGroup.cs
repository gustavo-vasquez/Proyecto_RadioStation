﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStationApp
{
    public static class RadioGroup
    {
        public static Dictionary<string, string> Radio = new Dictionary<string, string>()
        {
            {"laRed", "https://la_red.secure2.footprint.net/egress/bhandler/streamroot_lsd2latam/la_red/chunklist_b32768.m3u8"},
            {"continental", "https://20823.live.streamtheworld.com/CONTINENTAL_SC"},
            {"metro951", "http://mp3.metroaudio1.stream.avstreaming.net:7200/metro"},
            {"radioMitre", "http://turadioenvivo.com:11031/stream"},
            {"vorterix", "http://147.135.11.82:9904/;"},
            {"delPlataAM1030", "http://181.119.157.98:8000/amdelplata.mp3"},
            {"elDestape", "https://s2.radio.co/s120d8d180/listen"},
            {"radioRivadaviaAM630", "http://209.95.35.49:7012/live"},
            {"radioLatinaFM1011", "http://streaming.latina101.com.ar:8080/RadioLatina"},
            {"cnnRadioArgentina", "http://estudio.cnnradioargentina.com.ar:8000/stream"}
        };
    }
}