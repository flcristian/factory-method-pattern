﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.page
{
    public class SummaryPage : Page
    {
        public SummaryPage(String content) : base(content)
        {
            base.Name = "Summary";
        }
    }
}
