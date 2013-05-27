using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PJones.OEmbed;
using PJones.OEmbed.Providers;

namespace PJones.OEmbed.UI
{
    public class LinkToEmbed : System.Web.UI.WebControls.WebControl
    {
        public string URL { get; set; }
        public PJones.OEmbed.ProviderType Provider { get; set; }

        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.Write(GetEmbedHTML());
        }

        protected virtual string GetEmbedHTML() 
        {
            BaseProvider provider = GetEmbedProvider();
            string output = String.Empty;
            OEmbedResult result = provider.GetEmbedResult(URL);
            if (result != null)
            {
                output = result.html;
            }
            return output;
        }

        protected virtual BaseProvider GetEmbedProvider()
        {
            return ProviderFactory.GetProvider(Provider);
        }
    }
}
