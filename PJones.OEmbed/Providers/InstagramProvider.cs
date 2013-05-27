using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class InstagramProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"http://instagr(\.am|am\.com)/p/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://api.instagram.com/oembed"; } }

        public override OEmbedResult PostProcessResult(OEmbedResult result)
        {
            if (String.IsNullOrEmpty(result.html))
            {
                result.html = String.Format(@"<img src=""{0}"" alt=""{1}"" />", result.url, result.title);
            }
            return result;
        }
    }
}
