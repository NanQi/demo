using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using NanQi.Framework.Presentation;
using NanQi.Framework.Host;
using System.ComponentModel.Composition.Hosting;
using System.Xml.Linq;

namespace NanQi.Project.Host
{
    class Program
    {
        [Import]
        public IMain MainForm { get; set; }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var p = new Program();
            p.Run(args);
        }

        void Run(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var catalog = new DirectoryCatalog(Properties.Settings.Default.AddInDirectory);
            var container = new CompositionContainer(catalog);

            try
            {
                container.ComposeParts(this);

            }
            catch (ChangeRejectedException ex)
            {
                System.Console.WriteLine(ex.Message);
                return;
            }

            SetMenuSource();

            Application.Run(MainForm as Form);
        }

        void SetMenuSource()
        {
            List<TradeMenu> lstMenu = new List<TradeMenu>();

            XDocument doc = XDocument.Load("Menu.xml");
            var root = doc.Element("menu");

            foreach (var element in root.Elements())
            {
                TradeMenu cate = new TradeMenu();
                cate.Title = element.Attribute("title").Value;
                var att = element.Attribute("action");
                cate.ActionName = att == null ? null : att.Value;

                if (element.HasElements)
                {
                    SetMenuSource(element, cate);
                }
              
                lstMenu.Add(cate);
            }

            MainForm.LoadMenu(lstMenu);
        }

        void SetMenuSource(XElement parentElement, TradeMenu parentCategory)
        {
            List<TradeMenu> lstMenu = new List<TradeMenu>();

            foreach (var element in parentElement.Elements())
            {
                TradeMenu cate = new TradeMenu();
                cate.Title = element.Attribute("title").Value;
                cate.ActionName = element.Attribute("action").Value;

                if (element.HasElements)
                {
                    SetMenuSource(element, cate);
                }

                lstMenu.Add(cate);
            }

            parentCategory.Children = lstMenu;
        }

    }
}
