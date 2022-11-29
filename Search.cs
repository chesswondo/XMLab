using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLab
{
    public interface ISearch
    {
        List<Resource> Search(SearchCriteria criteria);
    }

    public class DomSearch : ISearch
    {
        private const int _maxCriteriaCount = 4;

        public List<Resource> Search(SearchCriteria criteria)
        {
            List<Resource> Resources = new List<Resource>();
            XmlDocument doc = new XmlDocument();
            doc.Load(XMLab.xmlPath);

            XmlNodeList ResourceNodes;

            string xPathCriteria = "";
            string ResourceSearchTag = "//" + XMLab.resourceTag;

            List<string> attributes = new List<string>();
            List<string> criteriaList = criteria.GetCriteriaList();

            attributes.Add(XMLab.title);
            attributes.Add(XMLab.author);
            attributes.Add(XMLab.year);
            attributes.Add(XMLab.faculty);

            for (int i = 0; i < criteriaList.Count; i++)
            {
                if (!criteriaList[i].Equals(""))
                {
                    xPathCriteria += "@" + attributes[i] + "='" + criteriaList[i] + "'and";
                }
            }
            int andLength = 3;
            try
            {
                xPathCriteria = xPathCriteria.Substring(0, xPathCriteria.Length - andLength);
            }
            catch { }

            if (criteria.AllCriteriaAreEmpty())
            {
                ResourceNodes = doc.SelectNodes(ResourceSearchTag);
            }
            else
            {
                string xPathQuery = ResourceSearchTag + "[" + xPathCriteria + "]";
                ResourceNodes = doc.SelectNodes(xPathQuery);
            }

            foreach (XmlNode ResourceNode in ResourceNodes)
            {
                Resource Resource = new Resource();
                FillAttributes(Resource, ResourceNode);
                Resources.Add(Resource);
            }
            //string xPathQuery = ;
            //doc.SelectNodes()

            return Resources;
        }

        private void FillAttributes(Resource Resource, XmlNode ResourceNode)
        {
            Resource.Title      = ResourceNode.Attributes[XMLab.title].Value;
            Resource.Author     = ResourceNode.Attributes[XMLab.author].Value;
            Resource.Year       = ResourceNode.Attributes[XMLab.year].Value;
            Resource.Faculty    = ResourceNode.Attributes[XMLab.faculty].Value;
            Resource.Annotation = ResourceNode.Attributes[XMLab.annotation].Value;
            Resource.Email      = ResourceNode.Attributes[XMLab.email].Value;
        }

    }

    public class SaxSearch : ISearch
    {
        public List<Resource> Search(SearchCriteria criteria)
        {
            List<Resource> resources = new List<Resource>();
            var xmlReader = new XmlTextReader(XMLab.xmlPath);
            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes && xmlReader.NodeType == XmlNodeType.Element)
                {
                    Resource resource = new Resource();
                    while (xmlReader.MoveToNextAttribute())
                    {
                        FillAttributes(resource, xmlReader, criteria);
                    }
                    resources.Add(resource.HasEmptyAttribute() ? null : resource);
                }
            }
            return resources;
        }

        private void FillAttributes(Resource resource, XmlReader xmlReader, SearchCriteria criteria)
        {
            string attrName = xmlReader.Name;
            string attrValue = xmlReader.Value;

            if (attrName.Equals(XMLab.title))        resource.Title   = ResolveCriteria(criteria.Title, attrName, attrValue);
            if (attrName.Equals(XMLab.author))       resource.Author  = ResolveCriteria(criteria.Author, attrName, attrValue);
            if (attrName.Equals(XMLab.year))         resource.Year    = ResolveCriteria(criteria.Year, attrName, attrValue);
            if (attrName.Equals(XMLab.faculty))      resource.Faculty = ResolveCriteria(criteria.Faculty, attrName, attrValue);

            if (attrName.Equals(XMLab.annotation))   resource.Annotation = attrValue;
            if (attrName.Equals(XMLab.email))        resource.Email      = attrValue;
        }

        private string ResolveCriteria(string criteria, string attrName, string attrValue)
        {
            if (criteria.Equals(""))  return attrValue;
            return attrValue.Equals(criteria) ? attrValue : "";
        }
    }

    public class LinqToXmlSearch : ISearch
    {
        public List<Resource> Search(SearchCriteria criteria)
        {
            List<Resource> resources = new List<Resource>();
            var doc = XDocument.Load(XMLab.xmlPath);

            var resourcesInList = from obj in doc.Descendants(XMLab.resourceTag)
                                  select new
                                  {
                                      title = criteria.Title.Equals("") ? obj.Attribute(XMLab.title).Value :
                                              criteria.Title.Equals(obj.Attribute(XMLab.title).Value) ?
                                              obj.Attribute(XMLab.title).Value : "",
                                      author= criteria.Author.Equals("") ? obj.Attribute(XMLab.author).Value :
                                              criteria.Author.Equals(obj.Attribute(XMLab.author).Value) ?
                                              obj.Attribute(XMLab.author).Value : "",
                                      year  = criteria.Year.Equals("") ? obj.Attribute(XMLab.year).Value :
                                              criteria.Year.Equals(obj.Attribute(XMLab.year).Value) ?
                                              obj.Attribute(XMLab.year).Value : "",
                                      faculty = criteria.Faculty.Equals("") ? obj.Attribute(XMLab.faculty).Value :
                                              criteria.Faculty.Equals(obj.Attribute(XMLab.faculty).Value) ?
                                              obj.Attribute(XMLab.faculty).Value : "",

                                      annotation = obj.Attribute(XMLab.annotation).Value,
                                      email      = obj.Attribute(XMLab.email).Value,
                                 };

            foreach (var resourceElem in resourcesInList)
            {
                Resource resource = new Resource();
                resource.Title      = resourceElem.title;
                resource.Author     = resourceElem.author;
                resource.Year       = resourceElem.year;
                resource.Faculty    = resourceElem.faculty;
                resource.Annotation = resourceElem.annotation;
                resource.Email      = resourceElem.email;

                resources.Add(resource.HasEmptyAttribute() ? null : resource);
            }

            return resources;
        }
    }



}
