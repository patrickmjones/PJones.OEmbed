using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PJones.OEmbed.Providers;

namespace PJones.OEmbed.UI
{
    public class WebControl:System.Web.UI.WebControls.WebControl
    {
        /// <summary>
        /// URL to media to parse
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Provider to perform parse
        /// </summary>
        public PJones.OEmbed.ProviderType Provider { get; set; }

        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            GetEmbedHTML(writer);
        }

        protected virtual void GetEmbedHTML(System.Web.UI.HtmlTextWriter writer)
        {
            throw new NotImplementedException();
        }        

        protected virtual BaseProvider GetEmbedProvider()
        {
            return ProviderFactory.GetProvider(Provider);
        }

        protected virtual OEmbedResult GetEmbedResult()
        {
            return GetEmbedResult(0, 0);
        }
        protected virtual OEmbedResult GetEmbedResult(int width, int height)
        {
            BaseProvider provider = GetEmbedProvider();
            if (provider != null)
            {
                return provider.GetEmbedResult(URL);
            }
            else
            {
                OEmbedEngine eng = new OEmbedEngine();
                return eng.ParseURL(URL, width, height);
            }
        }
    }
}
