using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelper.Library
{
    public static class CustomExtensions
    {

        public static MvcHtmlString Button(this HtmlHelper helper, ButtonType type,string id = "buttonId", string text = "save")
        {
            string button = string.Format("<button id='{0}' type='{1}'>{2}</button>", id, type.ToString(), text);
            return MvcHtmlString.Create(button);

        }

        public static MvcHtmlString ButtonWithTagBuilder(this HtmlHelper helper, ButtonType type, string id = "buttonId", string text = "save")
        {
            TagBuilder builder = new TagBuilder("button");
            builder.GenerateId(id);
            builder.SetInnerText(text);
            builder.Attributes.Add(new KeyValuePair<string, string>("type", type.ToString()));
            
            return MvcHtmlString.Create(builder.ToString());

        }


        public enum ButtonType
        {
            button,
            submit,
            password
        }
    }
}