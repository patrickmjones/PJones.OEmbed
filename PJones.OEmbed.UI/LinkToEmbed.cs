using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PJones.OEmbed;
using PJones.OEmbed.Providers;

namespace PJones.OEmbed.UI
{
    public class LinkToEmbed : WebControl
    {
        protected override void GetEmbedHTML(System.Web.UI.HtmlTextWriter writer) 
        {
            string output = String.Empty;
            OEmbedResult result = GetEmbedResult();
            if (result != null)
            {
                output = result.html;
            }
            writer.Write(output);
        }
    }
}
