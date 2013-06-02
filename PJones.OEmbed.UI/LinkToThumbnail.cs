using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PJones.OEmbed.Providers;
using System.Web.UI.WebControls;

namespace PJones.OEmbed.UI
{
    class LinkToThumbnail : WebControl
    {
        /// <summary>
        /// MaxWidth for Thumbnail image
        /// </summary>
        public int MaxWidth { get; set; }

        /// <summary>
        /// MaxHeight for Thumbnail image
        /// </summary>
        public int MaxHeight { get; set; }

        /// <summary>
        /// Default image url to use if none found
        /// </summary>
        public string DefaultImageUrl { get; set; }
        
        protected override void GetEmbedHTML(System.Web.UI.HtmlTextWriter writer)
        {
            Image image = new Image();
            if (MaxWidth > 0)
            {
                image.Width = MaxWidth;
            }
            if (MaxHeight > 0)
            {
                image.Height = MaxHeight;
            }
            
            OEmbedResult result = GetEmbedResult(MaxWidth, MaxHeight);
            if (result != null && !String.IsNullOrEmpty(result.thumbnail_url))
            {                
                image.ImageUrl = result.thumbnail_url;
            }
            else
            {
                image.ImageUrl = DefaultImageUrl;
            }
            
            image.RenderControl(writer);
        }
    }
}
