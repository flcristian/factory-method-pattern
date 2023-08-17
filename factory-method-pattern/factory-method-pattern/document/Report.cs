using factory_method_pattern.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.document
{
    public class Report : Document
    {
        public Report()
        {
            Name = "Report";

            IPageFactory pageFactory = new PageFactory();

            Pages.Add(pageFactory.CreatePage("Introduction/Introduction"));
            Pages.Add(pageFactory.CreatePage("Summary/Summary"));
            Pages.Add(pageFactory.CreatePage("Bibliography/Bibliography"));
        }
        public Report(string text)
        {
            string[] data = text.Split('/');
            Name = data[0];

            IPageFactory pageFactory = new PageFactory();

            Pages.Add(pageFactory.CreatePage($"Introduction/{data[1]}"));
            Pages.Add(pageFactory.CreatePage($"Summary/{data[2]}"));
            Pages.Add(pageFactory.CreatePage($"Bibliography/{data[3]}"));
        }
    }
}
