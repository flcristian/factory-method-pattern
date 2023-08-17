using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.document
{
    public class DocumentFactory : IDocumentFactory
    {
        public Document CreateDocument(string text)
        {
            string[] data = text.Split('/');

            string type = data[0];
            int i = 1;

            switch (type)
            {
                case "Report":
                    return new Report(text);
                case "Resume":
                    return new Resume(text);
                default:
                    return new Document(type);
            }
        }
    }
}
