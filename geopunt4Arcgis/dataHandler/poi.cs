using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace geopunt4Arcgis.dataHandler
{
    class poi
    {
        public WebClient client;
        NameValueCollection qryValues;
        string baseUrl = "http://poi.api.geopunt.be/v1/core";

        public poi(string proxyUrl, int port, int timeout)
        {
            this.init(proxyUrl, port, timeout);
        }
        public poi(int timeout)
        {
            this.init("", 80, timeout);
        }
        public poi()
        {
            this.init("", 80, 5000);
        }

        private void init(string proxyUrl, int port, int timeout)
        {
            if (proxyUrl == null || proxyUrl == "")
            {
                client = new gpWebClient() { Encoding = System.Text.Encoding.UTF8 , timeout= timeout};
            }
            else
            {
                client = new gpWebClient() { Encoding = System.Text.Encoding.UTF8, 
                                           Proxy = new System.Net.WebProxy(proxyUrl, port),
                                           timeout = timeout};
            }
            client.Headers["Content-type"] = "application/json";

            qryValues = new NameValueCollection();
        }

        public datacontract.poiCategories listThemes()
        {
            Uri poiUri = new Uri( baseUrl + "/themes");
            string json = client.DownloadString(poiUri);

            datacontract.poiCategories poiResponse = JsonConvert.DeserializeObject<datacontract.poiCategories>(json);

            client.QueryString.Clear();
            return poiResponse;
        }

        public datacontract.poiCategories listCategories(string themeid ) 
        {
            Uri poiUri;
            if (themeid == null || themeid == "" ) poiUri = new Uri(baseUrl + "/categories");
            else poiUri = new Uri(baseUrl + string.Format("/themes/{0}/categories", themeid));
            string json = client.DownloadString(poiUri);

            datacontract.poiCategories poiResponse = JsonConvert.DeserializeObject<datacontract.poiCategories>(json);

            client.QueryString.Clear();
            return poiResponse;
        }
        public datacontract.poiCategories listCategories( ) 
        {
            return listCategories(null);
        }

        public datacontract.poiCategories listPOItypes(string themeid, string categoryid)
        {
            Uri poiUri;
            if ((themeid != "" && themeid != null) && (categoryid != "" && categoryid != null))
            {
                poiUri = new Uri(baseUrl + string.Format("/themes/{0}/categories/{1}/poitypes", themeid, categoryid));
            }
            else if (categoryid != "" && categoryid != null)
            {
                poiUri = new Uri(baseUrl + string.Format("/categories/{0}/poitypes", categoryid));
            }
            else
            {
                poiUri = new Uri(baseUrl +"/poitypes");
            }

            string json = client.DownloadString(poiUri);

            datacontract.poiCategories poiResponse = JsonConvert.DeserializeObject<datacontract.poiCategories>(json);

            client.QueryString.Clear();
            return poiResponse;
        }
        public datacontract.poiCategories listPOItypes(string themeid)
        {
            return listPOItypes(themeid, null);
        }
        public datacontract.poiCategories listPOItypes()
        {
            return listPOItypes(null, null);
        }

        public datacontract.poiMinResponse getMinmodel(string q, bool Clustering, string theme, string category, 
            string POItype, CRS srs, int? id, string niscode, boundingBox bbox)
        {
            setQueryValues(q, 1024, Clustering, false, theme, category, POItype, srs, id, niscode, bbox );
            client.QueryString = qryValues;

            string json = client.DownloadString(baseUrl);

            datacontract.poiMinResponse poiResponse = JsonConvert.DeserializeObject<datacontract.poiMinResponse>(json);

            client.QueryString.Clear();

            return poiResponse;
        }

        public datacontract.poiMinResponse getMinmodel(string q, bool Clustering, string theme, string category, 
            string POItype, CRS srs, int? id, string niscode)
        {
            return getMinmodel(q, Clustering, theme, category, POItype, srs, id, niscode, null);
        }
        public datacontract.poiMinResponse getMinmodel(string q, bool Clustering, string theme, string category, 
            string POItype, CRS srs, int? id)
        {
            return getMinmodel(q, Clustering, theme, category, POItype, srs, id, "", null);
        }

        public datacontract.poiMaxResponse getMaxmodel(string q, int c, bool Clustering, string theme, string category,
            string POItype, CRS srs, int? id, string niscode, boundingBox bbox)
        {
            setQueryValues(q, c, Clustering, true, theme, category, POItype, srs, id, niscode, bbox);
            client.QueryString = qryValues;

            string json = client.DownloadString(baseUrl);

            datacontract.poiMaxResponse poiResponse = JsonConvert.DeserializeObject<datacontract.poiMaxResponse>(json);

            client.QueryString.Clear();

            return poiResponse;
        }
        public datacontract.poiMaxResponse getMaxmodel(string q, int c, bool Clustering, string theme, string category,
            string POItype, CRS srs, int? id, string niscode )
        {
            return getMaxmodel(q, c, Clustering, theme, category, POItype, srs, id, niscode, null );
        }
        public datacontract.poiMaxResponse getMaxmodel(string q, int c, bool Clustering, string theme, string category,
            string POItype, CRS srs, int? id )
        {
            return getMaxmodel(q, c, Clustering, theme, category, POItype, srs, id, "", null );
        }

        private void setQueryValues(string q , int c , bool Clustering , bool maxModel,
             string theme , string category, string POItype, CRS srs, 
             int? id , string niscode, boundingBox bbox )
        {
            qryValues.Clear();

            if (q != null || q != "") qryValues.Add("keyword", q);

            if (Clustering && !maxModel ) qryValues.Add("Clustering", "true");
            else qryValues.Add("Clustering", "false");
            //srs
            qryValues.Add("srsIn", Convert.ToString((int)srs));
            qryValues.Add("srsOut", Convert.ToString((int)srs));
            //string lists
            if (id != null ) qryValues.Add("id", id.ToString());
            if (niscode != null || niscode != "") qryValues.Add("region", niscode);
            if (theme != null || theme != "" ) qryValues.Add("theme", theme);
            if (category != null || category != "" ) qryValues.Add("category", category);
            if (POItype != null || POItype != "" ) qryValues.Add("POItype", POItype);
            qryValues.Add("maxcount", c.ToString());

            if (maxModel)
            {
                qryValues.Add("maxmodel", "true");
            }
            else
            {
                qryValues.Add("maxmodel", "false");
            }

            if (bbox != null) qryValues.Add("bbox", bbox.ToBboxString("|", "|"));
        }
    }
}
