using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace PJones.SC.OEmbed.Providers
{
    public abstract class BaseProvider
    {
        public abstract string ProviderPattern { get; }
        public abstract string OEmbedURL {get; }
        public string Process(string input)
        {
            string output = input;

            MatchCollection matches = Regex.Matches(input, ProviderPattern);
            foreach (Match m in matches)
            {
                OEmbedResult result = JsonConvert.DeserializeObject<OEmbedResult>(GetEmbed(m.Value));
                output = output.Replace(m.Value, result.html);
            }

            return output;
        }
        public string GetEmbed(string url)
        {
            StringBuilder output = new StringBuilder();
            string fullURL = OEmbedURL + "?url=" + url;

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
