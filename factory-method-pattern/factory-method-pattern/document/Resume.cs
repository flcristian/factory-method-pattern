using factory_method_pattern.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.document
{
    public class Resume : Document
    {
        public Resume()
        {
            Name = "Resume";

            IPageFactory pageFactory = new PageFactory();

            Pages.Add(pageFactory.CreatePage("Skills/Skills"));
            Pages.Add(pageFactory.CreatePage("Education/Education"));
            Pages.Add(pageFactory.CreatePage("Experience/Experience"));
        }

        public Resume(string text)
        {
            string[] data = text.Split('/');

            Name = data[0];

            IPageFactory pageFactory = new PageFactory();

            Pages.Add(pageFactory.CreatePage($"Skills/{data[1]}"));
            Pages.Add(pageFactory.CreatePage($"Education/{data[2]}"));
            Pages.Add(pageFactory.CreatePage($"Experience/{data[3]}"));
        }
    }
}
