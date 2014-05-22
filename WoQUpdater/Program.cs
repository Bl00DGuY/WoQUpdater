using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WoQUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("WoQ Updater");
            Console.WriteLine();
            Console.Write("By Bl00DGuY");
            new WebClient().DownloadFile("https://dl.dropboxusercontent.com/u/35486795/bloodaddon/zip/Bl00DAddon.zip", "WoQLauncher.zip");
            new WebClient().DownloadFile("https://dl.dropboxusercontent.com/u/35486795/bloodaddon/zip/Bl00DAddon.zip", "Data\\Patch.zip");
            Process.Start("7za.exe x WoQLauncher.zip -aoa");
        }
    }
}
