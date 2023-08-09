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

            Pages.Add(new IntroductionPage("introduction"));
            Pages.Add(new SummaryPage("summary"));
            Pages.Add(new BibliographyPage("bibliography"));
        }
    }
}
