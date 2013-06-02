using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System;

namespace PJones.OEmbed.Providers
{
    public abstract class BaseProvider
    {
        /// <summary>
        /// Normally true, but if your Provider needs to be disabled, do it here
        /// </summary>
        public bool Supported { get; set; }

        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }

        /// <summary>
        /// Regex to identify URLs as processable by this Provider
        /// </summary>
        public abstract string ProviderPattern { get; }

        /// <summary>
        /// API Endpoint - this is where OEmbed API Calls are made
        /// </summary>
        public abstract string EndpointURL {get; }

        public BaseProvider()
        {
            Supported = true;
        }

        /// <summary>
        /// Processes a chunk of HTML/text
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Process(string input)
        {
            string output = input;

            MatchCollection matches = Regex.Matches(input, ProviderPattern);
            foreach (Match m in matches)
            {
                OEmbedResult result = GetEmbedResult(m.Value);
                output = output.Replace(m.Value, result.html);
            }

            return output;
        }

        /// <summary>
        /// Determines if url matches this provider
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public bool IsMatch(string url)
        {
            return Regex.IsMatch(url, ProviderPattern);
        }

        /// <summary>
        /// Gets OEmbedResult for a URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public OEmbedResult GetEmbedResult(string url)
        {
            string response = GetEmbedResponse(url);
            OEmbedResult result = JsonConvert.DeserializeObject<OEmbedResult>(response);            
            return PostProcessResult(result);
        }

        /// <summary>
        /// If a provider wants to post-process a result, implement this method
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public virtual OEmbedResult PostProcessResult(OEmbedResult result)
        {
            return result;
        }

        /// <summary>
        /// Gets raw html response body for a URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GetEmbedResponse(string url)
        {
            StringBuilder output = new StringBuilder();
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            queryString["url"] = url;
            queryString["format"] = "json";
            if (MaxHeight > 0)
            {
                queryString["maxheight"] = MaxHeight.ToString();
            }
            if (MaxWidth > 0)
            {
                queryString["maxwidth"] = MaxWidth.ToString();
            }
            
            string fullURL = String.Format("{0}?{1}", EndpointURL, queryString.ToString());

            WebRequest embedReq;
            embedReq = WebRequest.Create(fullURL);
            Stream objStream;
            objStream = embedReq.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    output.AppendLine(sLine);
            }

            return output.ToString();
        }
    }
}
