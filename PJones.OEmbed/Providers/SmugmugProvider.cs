using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class SmugmugProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(.+\.)?smugmug\.com/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://api.smugmug.com/services/oembed/"; } }
    }
}
