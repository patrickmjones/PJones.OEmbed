using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    public class SpotifyProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(open|play)\.spotify\.com/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"https://embed.spotify.com/oembed/"; } }
    }
}
