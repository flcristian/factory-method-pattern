using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.document
{
    public interface IDocumentFactory
    {
        Document CreateDocument(string text);
    }
}
