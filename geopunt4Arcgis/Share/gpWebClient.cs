using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace geopunt4Arcgis
{
    class gpWebClient : WebClient
    {
        public int timeout { get; set; }

        public gpWebClient(Uri uri, int millisecTimeOut) 
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)0xc00;
            var objWebClient = GetWebRequest(uri);
            timeout = millisecTimeOut;
        }
        public gpWebClient(Uri uri)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)0xc00;
            var objWebClient = GetWebRequest(uri);
            timeout = 5000;
        }
        public gpWebClient()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)0xc00;
            timeout = 5000;
        }

        protected override WebRequest GetWebRequest(Uri uri)
        {
            var objWebRequest = base.GetWebRequest(uri);
            objWebRequest.Timeout = this.timeout;
            return objWebRequest;
        }
    }
}
