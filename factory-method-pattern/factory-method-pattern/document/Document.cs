using factory_method_pattern.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.document
{
    public abstract class Document
    {
        private String _name;
        private List<Page> _pages;
        
        // Constructors

        public Document()
        {
            _name = "Document";
            _pages = new List<Page>();
        }

        // Accessors

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public List<Page> Pages
        {
            get { return _pages; }
            set
            {
                _pages = value;
            }
        }

        // Methods

        public override bool Equals(object? obj)
        {
            return (obj as Document)._name == _name && (obj as Document)._pages == _pages;
        }

        public override string ToString()
        {
            String desc = $"{_name}\n=-=-=-=-=-=-=-=-=\n";
            foreach (Page page in _pages)
            {
                desc += $"{page}";
            }
            return desc;
        }
    }
}
