using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewJsLN
{
    public class ViewJsConfig
    {
        public string ShortcutViews { get; set; } = @"\areas\";
        public string ShortcutScripts { get; set; } = @"\wwwroot\js\biz\";
        public string ViewsSuffix { get; set; } = ".cshtml";
        public string ScriptsRegex { get; set; } = "/js/Biz/(.*)";
    

    }
}
