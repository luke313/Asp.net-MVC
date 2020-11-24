using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CutomHtmlHelper.Library
{
    public static class CustomExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string id="buttonId",string type="button", string text="save")
        {
            string button = string.Format("<button id='{0}' type='{1}'>{2}</button>", id, type, text);
            return MvcHtmlString.Create(button);
        }
    }
}