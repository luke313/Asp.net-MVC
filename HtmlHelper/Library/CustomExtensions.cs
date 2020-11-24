using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelper.Library
{
    public static class CustomExtensions
    {
        public static MvcHtmlString Button(string id="buttonId", string type="button", string text="save" )
        {
            string button = string.Format("<button id='{0}' type='{1}' text={2}></button", id, type, text);
            return MvcHtmlString.Create(button);
        }
    }
}