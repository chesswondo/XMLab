using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace XMLab
{
    public struct SearchCriteria
    {
        private readonly string _title;
        private readonly string _author;
        private readonly string _year;
        private readonly string _faculty;

        public string Title  { get { return _title; } }
        public string Author { get { return _author; } }
        public string Year   { get { return _year; } }
        public string Faculty { get { return _faculty; } }

        public SearchCriteria(XmlNode resource)
        {
            _title   = resource.Attributes[XMLab.title].Value;
            _author  = resource.Attributes[XMLab.author].Value;
            _year = resource.Attributes[XMLab.year].Value;
            _faculty = resource.Attributes[XMLab.faculty].Value;
        }

        public SearchCriteria(string title, string author, string year, string faculty)
        {
            _title = title;
            _author = author;
            _year = year;
            _faculty = faculty;
        }


        public bool AllCriteriaAreEmpty()
        {
            return _title.Equals("") && _author.Equals("") && _year.Equals("") && _faculty.Equals("");
        }

        public List<string> GetCriteriaList()
        {
            List<string> result = new List<string>();
            result.Add(_title);
            result.Add(_author);
            result.Add(_year);
            result.Add(_faculty);

            return result;
        }
    }
}
