using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class ScribdProvider :BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?scribd\.com/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://www.scribd.com/services/oembed"; } }
    }
}
