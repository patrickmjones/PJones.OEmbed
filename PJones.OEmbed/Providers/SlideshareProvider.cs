using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class SlideshareProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?slideshare\.net/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://www.slideshare.net/api/oembed/2"; } }
    }
}
