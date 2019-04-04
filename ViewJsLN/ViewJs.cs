using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;


namespace ViewJsLN
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class ViewJs
    {
        public static Dictionary<string, string> dic = new Dictionary<string, string>();
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("9c6339b4-f67e-4885-a3b9-31aa1115f2c3");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewJs"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private ViewJs(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new MenuCommand(this.MenuItemCallback, menuCommandID);
                commandService.AddCommand(menuItem);
            }
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static ViewJs Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package)
        {
            Instance = new ViewJs(package);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            try
            {

                var _applicationObject = this.ServiceProvider.GetService(typeof(EnvDTE.DTE)) as EnvDTE.DTE;
                var file = _applicationObject.ActiveDocument;
                string opFile = string.Empty;
                var fullName = file.FullName.ToLower();
                if (fullName.EndsWith(".cshtml"))
                {
                    opFile = fullName.Replace(@"\views\", @"\scripts\biz\").Replace(".cshtml", ".js");
                }
                else if (fullName.EndsWith(".js"))
                {
                    opFile = fullName.Replace(@"\scripts\biz\", @"\views\").Replace(".js", ".cshtml");
                }
                if (!string.IsNullOrEmpty(opFile))
                {
                    if (!File.Exists(opFile))
                    {
                        if (fullName.EndsWith(".cshtml"))
                        {
                            var strContent = new System.IO.StreamReader(fullName).ReadToEnd().ToLower();
                            List<string> lst = new List<string>();
                            var r = Regex.Matches(strContent, "/Scripts/(.*)".ToLower());
                            foreach (Match item in r)
                            {
                                var fileName = item.Value;
                                fileName = fileName.Substring(0, fileName.IndexOf(".js") + 3);
                                lst.Add(fileName);
                            }
                            string selItem;
                            if (lst.Count == 1)
                            {
                                selItem = lst[0];
                            }
                            else if (lst.Count > 1)
                            {
                                SelectOpenItem si = new SelectOpenItem(lst);
                                var dialog = si.ShowDialog();
                                selItem = si.SelItem;
                            }
                            else
                            {
                                return;
                            }
                            if (!string.IsNullOrEmpty(selItem))
                            {

                                var p = fullName.Substring(0, fullName.LastIndexOf(@"\views\"));
                                opFile = p + "/" + selItem;
                                if (File.Exists(opFile))
                                {
                                    opFile = new FileInfo(opFile).FullName.ToLower();
                                    if (!dic.ContainsKey(opFile))
                                    {
                                        dic.Add(opFile, fullName);
                                    }
                                }
                            }
                        }
                        else if (fullName.EndsWith(".js") && dic.ContainsKey(fullName))
                        {
                            opFile = dic[fullName];
                        }
                    }


                    if (File.Exists(opFile))
                    {
                        _applicationObject.ItemOperations.OpenFile(opFile);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
