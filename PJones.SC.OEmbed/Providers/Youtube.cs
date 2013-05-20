using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.SC.OEmbed.Providers
{
    public class Youtube : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?youtube\.com/watch[^ <]*"; } }
        public override string OEmbedURL { get { return @"http://www.youtube.com/oembed"; } }
    }
}
