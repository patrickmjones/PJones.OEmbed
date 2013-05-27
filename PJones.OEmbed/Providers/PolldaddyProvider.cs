using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    /// <summary>
    /// www.polldaddy.com - Not currently supported
    /// </summary>
    class PolldaddyProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(.+\.)?polldaddy\.com/[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://polldaddy.com/oembed/"; } }

        public PolldaddyProvider()
            : base()
        {
            Supported = false;
        }
    }
}
