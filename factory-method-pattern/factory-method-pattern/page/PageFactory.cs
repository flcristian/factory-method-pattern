using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.page
{
    public class PageFactory : IPageFactory
    {
        public Page CreatePage(string text)
        {
            string[] data = text.Split('/');

            string type = data[0];
            string content = data[1];

            switch (type)
            {
                case "Skills":
                    return new SkillsPage(content);
                case "Summary":
                    return new SummaryPage(content);
                case "Introduction":
                    return new IntroductionPage(content);
                case "Experience":
                    return new ExperiencePage(content);
                case "Education":
                    return new EducationPage(content);
                case "Bibliography":
                    return new BibliographyPage(content);
                default:
                    return new Page(type, content);
            }
        }
    }
}
