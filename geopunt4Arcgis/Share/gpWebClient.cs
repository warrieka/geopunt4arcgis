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
            var objWebClient = GetWebRequest(uri);
            timeout = millisecTimeOut;
        }
        public gpWebClient(Uri uri)
        {
            var objWebClient = GetWebRequest(uri);
            timeout = 5000;
        }
        public gpWebClient()
        {
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
