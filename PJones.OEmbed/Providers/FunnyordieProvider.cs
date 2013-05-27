using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class FunnyordieProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?funnyordie\.com/videos/[^\s""<]*"; } }
        public override string EndpointURL { get { return "http://www.funnyordie.com/oembed"; } }
    }
}
