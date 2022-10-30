using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI.WebControls;

namespace MvcVueApp1.Models
{
    public class Helpers
    {
        public static IHtmlString LoadFile(string webpath)
        {
            string filePath = HostingEnvironment.MapPath(webpath);
            IHtmlString ret = new HtmlString(File.ReadAllText(filePath));
            return ret;
        }
    }
}