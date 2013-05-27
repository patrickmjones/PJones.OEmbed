using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class SoundcloudProvider:BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?soundcloud\.com/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://soundcloud.com/oembed"; } }
    }
}
