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
            new WebClient().DownloadFile("http://dev.woq.ca/_Zip/WoQLauncher.zip", "WoQLauncher.zip");
            new WebClient().DownloadFile("http://dev.woq.ca/_Zip/Patch.zip", "Patch.zip");

            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = " x WoQLauncher.zip -aoa";
            // Enter the executable to run, including the complete path
            start.FileName = "7za.exe";
            // Do you want to show a console window?
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = false;
            Process proc = Process.Start(start);


            // Prepare the process to run
            ProcessStartInfo start2 = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start2.Arguments = " x Patch.zip -aoa";
            // Enter the executable to run, including the complete path
            start2.FileName = "7za.exe";
            // Do you want to show a console window?
            start2.WindowStyle = ProcessWindowStyle.Hidden;
            start2.CreateNoWindow = false;
            Process proc2 = Process.Start(start2);

            proc2.WaitForExit();

            // Prepare the process to run
            ProcessStartInfo start3 = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start3.Arguments = null;
            // Enter the executable to run, including the complete path
            start3.FileName = "WoQLauncher.exe";
            // Do you want to show a console window?
            start3.WindowStyle = ProcessWindowStyle.Normal;
            start3.CreateNoWindow = false;
            Process proc3 = Process.Start(start3);

            
        }
    }
}
