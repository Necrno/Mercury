﻿/*  
 ▄▀▀▄ ▄▀▄  ▄▀▀█▄▄▄▄  ▄▀▀▄▀▀▀▄  ▄▀▄▄▄▄   ▄▀▀▄ ▄▀▀▄  ▄▀▀▄▀▀▀▄  ▄▀▀▄ ▀▀▄ 
█  █ ▀  █ ▐  ▄▀   ▐ █   █   █ █ █    ▌ █   █    █ █   █   █ █   ▀▄ ▄▀ 
▐  █    █   █▄▄▄▄▄  ▐  █▀▀█▀  ▐ █      ▐  █    █  ▐  █▀▀█▀  ▐     █   
  █    █    █    ▌   ▄▀    █    █        █    █    ▄▀    █        █   
▄▀   ▄▀    ▄▀▄▄▄▄   █     █    ▄▀▄▄▄▄▀    ▀▄▄▄▄▀  █     █       ▄▀    
█    █     █    ▐   ▐     ▐   █     ▐             ▐     ▐       █     
▐    ▐     ▐                  ▐                                 ▐   
*/

using System;
using System.Windows.Forms;
using System.IO;
using MercuryBOT.Splash;
using System.Threading;
using MercuryBOT.Properties;
using MercuryBOT.Helpers;
using System.Reflection;
using System.Linq;

namespace MercuryBOT
{
    static class Program
    {

        public static readonly string BOTNAME          = "MercuryBOT";
        public static readonly string BOTNAMELowerCaps = "MᴇʀᴄᴜʀʏBOT";

        public static readonly string spkDomain        = "http://sp0ok3r.tk/Mercury/";
        public static readonly string Version          = "4.0.0beta3";


        public static readonly string ExecutablePath   = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string AccountsJsonFile = ExecutablePath + @"\Accounts.json";
        public static readonly string SettingsJsonFile = ExecutablePath + @"\Settings.json";
        public static readonly string SentryFolder     = ExecutablePath + @"\Sentry\";
        public static readonly string ChatLogsFolder   = ExecutablePath + @"\ChatLogs\";



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}