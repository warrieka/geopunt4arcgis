﻿using System;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Globalization;
using Newtonsoft.Json;

namespace geopunt4Arcgis 
{
    class versionChecker
    {
        WebClient gpClient;
        System.Diagnostics.Process prs;

        string versionJSurl = "http://www.geopunt.be/~/media/geopunt/voor-experts/plugins/bestanden/arcgis%20plugin/geopunt4arcgis.json";
        string dlAddinUri =   "http://www.geopunt.be/~/media/geopunt/voor-experts/plugins/bestanden/arcgis%20plugin%20bestand/geopunt4arcgis.esriAddIn";

        public versionChecker(string proxyUrl, int port, int timeout) 
        {
            this.init(proxyUrl, port, timeout);
        }
        public versionChecker(int timeout)
        {
            this.init("", 80, timeout);
        }
        public versionChecker() 
        {
            this.init("", 80, 5000);
        }

        private void init(string proxyUrl, int port, int timeout)
        {
            if (proxyUrl == null || proxyUrl == "")
            {
                gpClient = new gpWebClient() { Encoding = System.Text.Encoding.UTF8, timeout = timeout };
            }
            else
            {
                gpClient = new gpWebClient()
                {
                    Encoding = System.Text.Encoding.UTF8,
                    Proxy = new System.Net.WebProxy(proxyUrl, port),
                    timeout = timeout
                };
            }
            gpClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);

            prs = new System.Diagnostics.Process();
            prs.StartInfo.UseShellExecute = false;  
        }

        public void checkVersion()
        {
            gpClient.DownloadStringAsync(new Uri(versionJSurl));
        }

        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                if (e.Error == null)
                {
                    string json = e.Result;
                    string currentVersion = ThisAddIn.Version;
                    Dictionary<string, string> versionJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (currentVersion.CompareTo( versionJson["Version"]) < 0)
                    {
                        DialogResult dlg = MessageBox.Show("De geopunt plugin is niet meer up to date, wenst u de browser te openen om de nieuwe versie te downloaden? ",
                            ThisAddIn.Name + " " + currentVersion, MessageBoxButtons.YesNo);

                        if (dlg == DialogResult.Yes)
                        {
                           System.Diagnostics.Process.Start("http://www.geopunt.be/voor-experts/geopunt-plug-ins/arcgis%20plugin");
                           // reInstall();  
                        }
                    }
                }
                else
                {
                    MessageBox.Show( e.Error.Message );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private void reInstall()
        {   
            string tempLoc = Path.Combine(Path.GetTempPath(), "geopunt4arcgis.esriAddIn");
            string commonFiles = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
            string regAddin = "\"" + commonFiles + "\\ArcGIS\\bin\\ESRIRegAddIn.exe" + "\"";

            gpClient.DownloadFile(dlAddinUri, tempLoc);

            prs.StartInfo.FileName =  regAddin;
            prs.StartInfo.Arguments = "/s /u " + ThisAddIn.AddInID;
            prs.Start();

            prs.StartInfo.Arguments = "/s " + tempLoc;
            prs.Start();

            DialogResult dlg = MessageBox.Show(
                "De plugin geopunt4Arcgis werd geherinstalleerd, u dient nu ArcGIS te herstarten om deze updates toe te passen.", 
                "Herstart Vereist");
        }

    }
}
