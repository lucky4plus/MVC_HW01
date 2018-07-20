using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Money.Helper
{
    public static class MoneyHelper
    {
        public static HtmlString DisplayCategoryColor(this HtmlHelper htmlHelper,string category)
        {
            var className = string.Empty;
            switch (category)
            {
                case "支出":
                    className = "danger";
                    break;
                case "收入":
                    className = "info";
                    break;
                default:
                    break;
            }
            return new MvcHtmlString($"<span class='text-{className}'>{category}</span>");
        }
    }
}