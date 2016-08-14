using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSession3.Helper
{
    public static class WebExtentions
    {
        public static string TryGetValue(this int[] array, int index)
        {
            if (array.Length > index)
            {
                return array[index].ToString();
            }

            return string.Empty;
        }

        public static string Image(this HtmlHelper helper, string id, string alt, int width, int height)
        {
            var img = new TagBuilder("img");

            img.GenerateId(id);
            img.MergeAttribute("src", $"https://unsplash.it/{width}/{height}?random&v={Guid.NewGuid().GetHashCode()}");
            img.MergeAttribute("alt", alt);

            return img.ToString(TagRenderMode.SelfClosing);
        }

        public static MvcHtmlString Image(this HtmlHelper helper, int width, int height)
        {
            return MvcHtmlString.Create($"<img src=\"https://unsplash.it/{width}/{height}?random&v={Guid.NewGuid()}\" />");
        }
    }
}