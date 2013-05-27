using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class HuluProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?hulu\.com/watch/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://www.hulu.com/api/oembed.json"; } }
    }
}
