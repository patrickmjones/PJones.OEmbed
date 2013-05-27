using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    public class YoutubeProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?youtube\.com/watch[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://www.youtube.com/oembed"; } }
    }
}
