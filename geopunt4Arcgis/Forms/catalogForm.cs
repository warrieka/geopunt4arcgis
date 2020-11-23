using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Catalog;

namespace geopunt4Arcgis
{
    public partial class catalogForm : Form
    {
        IActiveView view;
        IMap map;
        ISpatialReference wgs;
        geopunt4arcgisExtension gpExtension;

        /*filters lists*/
        List<string> gdiThemes;
        List<string> orgNames;
        Dictionary<string, string> dataTypes;
        List<string> inspKeyw;

        AutoCompleteStringCollection keyWords;

        dataHandler.catalog clg;
        datacontract.metadataResponse metaList = null;

        public catalogForm()
        {
            view = ArcMap.Document.ActiveView;
            map = view.FocusMap;

            wgs = geopuntHelper.wgs84;

            gpExtension = geopunt4arcgisExtension.getGeopuntExtension();

            InitializeComponent();
            initGui();
        }

        public void initGui()
        {
            clg = new dataHandler.catalog(timeout: gpExtension.timeout);
            keyWords = new AutoCompleteStringCollection();
            keyWords.AddRange(  clg.getKeyWords().ToArray() );
            keywordTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            keywordTxt.AutoCompleteCustomSource = keyWords;

            gdiThemes = clg.getGDIthemes();
            gdiThemes.Insert(0, "");
            GDIthemeCbx.DataSource = gdiThemes;

            orgNames = clg.getOrganisations();
            orgNames.Insert(0, "");
            orgNames.Sort();
            orgNameCbx.DataSource = orgNames;

            dataTypes = clg.dataTypes;
            List<string> dtypes = dataTypes.Select(c => c.Key).ToList();
            dtypes.Insert(0, "");
            typeCbx.DataSource = dtypes;

            inspKeyw = clg.inspireKeywords();
            inspKeyw.Insert(0, "");
            inspKeyw.Sort();
            INSPIREthemeCbx.DataSource = inspKeyw;

            filterResultsCbx.SelectedIndex = 0;
        }

        #region "eventHandlers"
        private void zoekBtn_Click(object sender, EventArgs e)
        {
            search();
        }

        private void keywordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                search();
            }
        }

        private void helpLbl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://www.geopunt.be/voor-experts/geopunt-plug-ins/arcgis%20plugin/functionaliteiten/catalogus");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metaList == null) return;

            updateInfo();
        }

        private void OpenDownloadBtn_Click(object sender, EventArgs e)
        {
            loadArcgis();
        }

        private void addWMSbtn_Click(object sender, EventArgs e)
        {
            addWMS();
        }

        private void filterResultsCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFilter();
        }
        #endregion

        #region "private functions"

        private void updateFilter()
        {
            string filterTxt = filterResultsCbx.Text;
            switch (filterTxt)
            {
                case "Alles weergeven":
                    searchResultsList.Items.Clear();
                    searchResultsList.Items.AddRange(geenFilter());
                    break;
                case "WMS":
                    searchResultsList.Items.Clear();
                    searchResultsList.Items.AddRange(filterWMS());
                    break;
                case "Arcgis service":
                    searchResultsList.Items.Clear();
                    searchResultsList.Items.AddRange(filterAGS());
                    break;
                case "Download":
                    searchResultsList.Items.Clear();
                    searchResultsList.Items.AddRange(filterDL());
                    break;
                default:
                    break;
            }
        }
        
        private string[] filterDL()
        {
            if (metaList == null) return new string[0];
            return (from g in metaList.metadataRecords
                    where metaList.geturl(g.title, "DOWNLOAD")
                    select g.title).ToArray();
        }
        
        private string[] filterWMS()
        {
            if (metaList == null) return new string[0];
            return (from g in metaList.metadataRecords
                    where metaList.geturl(g.title, "OGC:WMS")
                    select g.title).ToArray();
        }

        private string[] filterAGS()
        {
           if (metaList == null) return new string[0];
           return (from g in metaList.metadataRecords
                   where  metaList.geturl(g.title, "Esri Rest API", 0)
                   select g.title).ToArray();
        }

        private string[] geenFilter()
        {
            if (metaList == null) return new string[0];
            return (from g in metaList.metadataRecords
                    select g.title).ToArray();
        }

        private void search()
        {
            searchResultsList.Items.Clear();
            statusMsgLbl.Text = "";
            webView.DocumentText = "";

            try
            {
                string zoekString = keywordTxt.Text;
                string themekey = GDIthemeCbx.Text;
                string orgName = orgNameCbx.Text;
                string dataType = "";
                if (dataTypes.Select(c => c.Key).Contains(typeCbx.Text)) dataType = dataTypes[typeCbx.Text];
                string inspiretheme = INSPIREthemeCbx.Text;

                metaList = clg.searchAll(zoekString, themekey, orgName, dataType, "", inspiretheme);

                if (metaList.to != 0)
                {
                    updateFilter();
                    statusMsgLbl.Text = String.Format("Aantal records gevonden: {0}", metaList.summary.count);
                }
                else
                {
                    MessageBox.Show("Er werd niets gevonden dat voldoet aan deze criteria", "Geen resultaat");
                }
                addWMSbtn.Enabled = false;
                OpenArcgisBtn.Enabled = false;
            }
            catch (WebException wex)
            {
                if (wex.Status == WebExceptionStatus.Timeout)
                    MessageBox.Show("De connectie werd afgebroken." +
                        " Het duurde te lang voor de server een resultaat terug gaf.\n" +
                         "U kunt via de instellingen de 'timout'-tijd optrekken.", wex.Message);
                else if (wex.Response != null)
                {
                    string resp = new StreamReader(wex.Response.GetResponseStream()).ReadToEnd();
                    MessageBox.Show(resp, wex.Message);
                }
                else
                    MessageBox.Show(wex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " : " + ex.StackTrace, "Error");
            }
        }
        
        private void updateInfo()
        {
            addWMSbtn.Enabled = false;
            OpenArcgisBtn.Enabled = false;

            string selVal = searchResultsList.Text;
            List<datacontract.metadata> metaObjs = (from n in metaList.metadataRecords
                                                    where n.title == selVal
                                                    select n).ToList();
            if (metaObjs.Count > 0)
            {
                datacontract.metadata metaObj = metaObjs[0];
                string infoMsg = string.Format("<h2>{0}</h2><br/><div>{1}</div>", metaObj.title, metaObj.description);
                infoMsg += string.Format(
                "<div><a target='_blank' href='https://metadata.vlaanderen.be/srv/dut/catalog.search#/metadata/{0}'>Ga naar fiche in metadata center</a></div>",
                                          metaObj.geonet.uuid   );
               
                if (metaObj.links != null && metaObj.links.Count() > 0 )
                {
                   infoMsg += "<br/><ul>";
                   foreach (string link in metaObj.links)
                   { 
                      string[] links = link.Split('|');
                      if (links[3].ToUpper().Contains("DOWNLOAD"))
                      {
                         string url = links[2];
                         string name = (String.IsNullOrEmpty(links[0])) ? links[1] : links[0];
                         infoMsg += string.Format("<li><a target='_blank' href='{1}'>{0}</a></li>", name, url);
                      }     
                   }
                   infoMsg += "</ul>";
                }
                webView.DocumentText = infoMsg;

                if (metaList.geturl(selVal, "Esri Rest API", 0)) OpenArcgisBtn.Enabled = true;
                if (metaList.geturl(selVal, "OGC:WMS")) addWMSbtn.Enabled = true;
            }
        }

        private void loadArcgis()
        {
           string selVal = searchResultsList.Text;
           string arcName; 
           string arcUrl;

           bool hasArc = metaList.geturl(selVal, "Esri Rest API", out arcUrl, out arcName, 0);
           if (hasArc)
           {
              arcUrl = arcUrl.Split('?')[0] + "?";
              if (geopuntHelper.websiteExists(arcUrl, true) == false)
              {
                 MessageBox.Show("Kan geen connectie maken met de Service.", "Connection timed out");
                 return;
              }
              geopuntHelper.addAGS2map(ArcMap.Document.FocusMap, arcUrl, arcName);

           }

        }

        private void addWMS()
        {
            string selVal = searchResultsList.Text;
            List<ESRI.ArcGIS.GISClient.IWMSLayerDescription> lyrDescripts;
            string lyrDlgName; string lyrName; string wmsUrl;
            layerSelectionForm lyrDlg;

            bool hasWms = metaList.geturl(selVal, "OGC:WMS", out wmsUrl, out lyrName);
            if (hasWms)
            {
                wmsUrl = wmsUrl.Split('?')[0] + "?";

                if (geopuntHelper.websiteExists(wmsUrl, true) == false)
                {
                    MessageBox.Show("Kan geen connectie maken met de Service.", "Connection timed out");
                    return;
                }
                try
                {
                    lyrDescripts = geopuntHelper.listWMSlayers(wmsUrl);
                    if (lyrDescripts.Count <= 2) 
                    {
                        geopuntHelper.addWMS2map(ArcMap.Document.FocusMap, wmsUrl);
                        return;
                    }
                        
                    lyrDlg = new layerSelectionForm(lyrDescripts, lyrName);
                    lyrDlg.ShowDialog(this);

                    lyrDlgName = lyrDlg.selectedLayerName;

                    if (lyrDlgName != null)
                    {
                        ILayer lyr = geopuntHelper.getWMSLayerByName(wmsUrl, lyrDlgName);
                        if (lyr != null)
                        {
                            ArcMap.Document.FocusMap.AddLayer(lyr);
                        }
                        else
                        {
                            geopuntHelper.addWMS2map(ArcMap.Document.FocusMap, wmsUrl);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " : " + ex.StackTrace, "Error");
                }
            }
        }
        #endregion 


    }
}
