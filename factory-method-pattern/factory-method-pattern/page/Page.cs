using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.page
{
    public abstract class Page
    {
        private String _name;
        private String _content;

        // Constructors

        public Page(String content)
        {
            _name = "Article";
            _content = content;
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

        public String Content
        {
            get { return _content; }
            set
            {
                _content = value;
            }
        }

        // Methods

        public override bool Equals(object? obj)
        {
            return (obj as Page)._name == _name && (obj as Page)._content == _content;
        }

        public override String ToString()
        {
            return $"{_name}:\n{_content}\n";
        }
    }
}
