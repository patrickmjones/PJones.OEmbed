using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class SpeakerdeckProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?speakerdeck\.com/[^\s""<]*"; } }
        public override string EndpointURL { get { return "http://speakerdeck.com/oembed.json"; } }
    }
}
