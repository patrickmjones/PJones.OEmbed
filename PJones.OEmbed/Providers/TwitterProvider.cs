using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class TwitterProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?twitter\.com/.+?/status(es)?/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://api.twitter.com/1/statuses/oembed.json"; } }
    }
}
