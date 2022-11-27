using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLab
{
    public class Resource
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Faculty { get; set; }
        public string Annotation{ get; set; }
        public string Email { get; set; }
        // Checks whether some of the attributes is unset.
        public bool HasEmptyAttribute()
        {
            return Title.Equals("") || Author.Equals("") || Year.Equals("")
                 || Faculty.Equals("") || Annotation.Equals("") || Email.Equals("");
        }
    }
}

