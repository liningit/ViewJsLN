using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ViewJsLN
{
    public partial class ConfigSet : Form
    {
        public ConfigSet()
        {
            InitializeComponent();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            loadConfig(new ViewJsConfig());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ViewJs.Config.ShortcutScripts = txtShortcutScripts.Text;
            ViewJs.Config.ShortcutViews = txtShortcutViews.Text;
            ViewJs.Config.ViewsSuffix = txtViewsSuffix.Text;
            ViewJs.Config.ScriptsRegex = txtScriptsRegex.Text;
            XmlSerializer xml = new XmlSerializer(typeof(ViewJsConfig));

            var configFile = ViewJs.ConfigPath;

            using (MemoryStream stream = new MemoryStream())
            {
                xml.Serialize(stream, ViewJs.Config);
                stream.Position = 0;
                using (StreamReader sr = new StreamReader(stream))
                {
                    File.WriteAllText(configFile, sr.ReadToEnd());
                }
            }
            this.Close();

        }

        private void ConfigSet_Load(object sender, EventArgs e)
        {
     
            XmlSerializer xml = new XmlSerializer(typeof(ViewJsConfig));
            using (var s = new FileStream(ViewJs.ConfigPath, FileMode.Open))
            {
                ViewJs.Config = xml.Deserialize(s) as ViewJsConfig;
                loadConfig(ViewJs.Config);
            }

        }

        private void loadConfig(ViewJsConfig config)
        {
            txtShortcutScripts.Text = config.ShortcutScripts;
            txtShortcutViews.Text = config.ShortcutViews;
            txtViewsSuffix.Text = config.ViewsSuffix;
            txtScriptsRegex.Text = config.ScriptsRegex;
        }
    }
}
