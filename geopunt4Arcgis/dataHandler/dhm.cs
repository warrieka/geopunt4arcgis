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
    class dhm
    {
        public WebClient client;
        string baseUri = "https://dhm.agiv.be/api/elevation/v1/";

        public dhm(string proxyUrl , int port , int timeout)
        {
            this.init(proxyUrl , port , timeout);
        }
        public dhm(int timeout)
        {
            this.init("", 80, timeout);
        }
        public dhm()
        {
            this.init("",80,5000 );
        }

        private void init(string proxyUrl , int port , int timeout)
        {
            if (proxyUrl == null || proxyUrl == "")
            {
                client = new gpWebClient() { Encoding = System.Text.Encoding.UTF8 , timeout= timeout};
            }
            else
            {
                client = new gpWebClient() { Encoding = System.Text.Encoding.UTF8, 
                                           Proxy = new System.Net.WebProxy(proxyUrl, port), timeout= timeout };
            }
        }

        public List<List<double>> getDataAlongLine( datacontract.geojsonLine profileLine, int nrSamples , CRS srs)
        {
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            Uri dhmUri = new Uri(baseUri + "DHMV2/request/");

            datacontract.dhmRequest dhmMsg = new datacontract.dhmRequest() { 
                Samples = nrSamples, LineString = profileLine, SrsIn= (int)srs , SrsOut= (int)srs };

            string postData = JsonConvert.SerializeObject(dhmMsg);
            byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(postData);
            byte[] byteResult = client.UploadData(dhmUri, "POST", byteArray);

            string json = Encoding.ASCII.GetString(byteResult);
            List<List<double>> response = JsonConvert.DeserializeObject<List<List<double>>>(json);

            return response;
        }
        public List<List<double>> getDataAlongLine(datacontract.geojsonLine profileLine , int nrSamples){
            return this.getDataAlongLine(profileLine, nrSamples, CRS.WGS84);    
        }
        public List<List<double>> getDataAlongLine(datacontract.geojsonLine profileLine)
        {
            return this.getDataAlongLine(profileLine, 30, CRS.WGS84);
        }
    }
}
