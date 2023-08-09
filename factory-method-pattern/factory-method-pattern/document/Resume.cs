using factory_method_pattern.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.document
{
    public class Resume : Document
    {
        public Resume()
        {
            Name = "Resume";

            Pages.Add(new SkillsPage("skills"));
            Pages.Add(new EducationPage("education"));
            Pages.Add(new ExperiencePage("experience"));
        }
    }
}
