using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.page
{
    public interface IPageFactory
    {
        Page CreatePage(string text);
    }
}
