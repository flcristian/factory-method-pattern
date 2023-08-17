using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_pattern.page
{
    public class Page
    {
        private string _name;
        private string _content;

        // Constructors

        public Page(string content)
        {
            _name = "Article";
            _content = content;
        }

        public Page(string name, string content)
        {
            _name = name;
            _content = content;
        }

        // Accessors

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string Content
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

        public override string ToString()
        {
            return $"{_name}:\n{_content}\n";
        }
    }
}
