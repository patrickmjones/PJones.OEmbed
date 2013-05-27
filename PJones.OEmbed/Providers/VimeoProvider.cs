using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class VimeoProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?vimeo\.com/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://vimeo.com/api/oembed.json"; } }
    }
}
