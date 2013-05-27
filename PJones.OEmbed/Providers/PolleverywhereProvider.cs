using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed.Providers
{
    class PolleverywhereProvider : BaseProvider
    {
        public override string ProviderPattern { get { return @"https?://(www\.)?polleverywhere\.com/(polls|multiple_choice_polls|free_text_polls)[^\s""<]*"; } }
        public override string EndpointURL { get { return @"http://www.polleverywhere.com/services/oembed/"; } }
    }
}
