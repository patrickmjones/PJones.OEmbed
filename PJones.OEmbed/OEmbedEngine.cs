using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PJones.OEmbed.Providers;

namespace PJones.OEmbed
{
    public class OEmbedEngine
    {
        public IEnumerable<Type> Providers { get; set; }

        /// <summary>
        /// Parses a block of HTML/text using supplied Providers (defaults to all)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Parse(string input)
        {
            string output = input;
            foreach (Type t in Providers)
            {
                object provider = Activator.CreateInstance(t);
                if (((BaseProvider)provider).Supported)
                {
                    output = ((BaseProvider)provider).Process(output);
                }
            }
            return output;
        }

        public OEmbedEngine()
        {
            Initialize(new List<Type> {
                typeof(HuluProvider),
                typeof(InstagramProvider), 
                typeof(PolleverywhereProvider),
                typeof(PolldaddyProvider),
                typeof(ScribdProvider),
                typeof(SlideshareProvider),
                typeof(SmugmugProvider),
                typeof(SoundcloudProvider),
                typeof(SpotifyProvider),
                typeof(YoutubeProvider),
                typeof(TwitterProvider),
                typeof(VimeoProvider) 
            });
        }
        public OEmbedEngine(IEnumerable<Type> providers)
        {
            Initialize(providers);
        }
        protected void Initialize(IEnumerable<Type> providers)
        {
            Providers = providers;
        }
    }
}
