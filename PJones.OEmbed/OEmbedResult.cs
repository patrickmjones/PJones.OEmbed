using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJones.OEmbed
{
    public class OEmbedResult
    {
        /// <summary>
        /// Title of the media
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// URL / Permalink to media
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Author's name or UserID
        /// </summary>
        public string author_name { get; set; }

        /// <summary>
        /// Author's URL
        /// </summary>
        public string author_url { get; set; }

        /// <summary>
        /// Provider name (ex: YouTube)
        /// </summary>
        public string provider_name { get; set; }

        /// <summary>
        /// Provider URL (ex: http://www.youtube.com)
        /// </summary>
        public string provider_url { get; set; }

        /// <summary>
        /// HTML Code to embed media
        /// </summary>
        public string html { get; set; }

        /// <summary>
        /// Thumbnail URL if applicable
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// Thumbnail height in pixels if applicable
        /// </summary>
        public int thumbnail_height { get; set; }

        /// <summary>
        /// Thumbnail width in pixels if applicable
        /// </summary>
        public int thumbnail_width { get; set; }

        /// <summary>
        /// Width of media in pixels
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Height of media in pixels
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Type of media (ex: video)
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Version of media
        /// </summary>
        public string version { get; set; }
    }
}
