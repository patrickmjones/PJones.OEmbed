using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PJones.OEmbed.Providers;
using PJones.OEmbed.Exceptions;

namespace PJones.OEmbed
{
    public class ProviderFactory
    {
        public static BaseProvider GetProvider(ProviderType type)
        {
            switch (type)
            {
                case ProviderType.Hulu:
                    return new HuluProvider();
                case ProviderType.Instagram:
                    return new InstagramProvider();
                case ProviderType.Polleverywhere:
                    return new PolleverywhereProvider();
                case ProviderType.Polldaddy:
                    return new PolldaddyProvider();
                case ProviderType.Scribd:
                    return new ScribdProvider();
                case ProviderType.Slideshare:
                    return new SlideshareProvider();
                case ProviderType.Smugmug:
                    return new SmugmugProvider();
                case ProviderType.Soundcloud:
                    return new SoundcloudProvider();
                case ProviderType.Spotify:
                    return new SpotifyProvider();
                case ProviderType.Vimeo:
                    return new VimeoProvider();
                case ProviderType.Youtube:
                    return new YoutubeProvider();
                default:
                    throw new UnknownProviderException();
            }
        }
    }
}
