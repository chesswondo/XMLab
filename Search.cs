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

        // Sets the speified Resource's attributes.
        private void FillAttributes(Resource Resource, XmlAttribute attribute, SearchCriteria criteria)
        {
            string attrName = attribute.Name;
            string attrValue = attribute.Value;

            if (attrName.Equals(XMLab.title))
            {
                Resource.Author = ResolveCriteria(criteria.Title, attrName, attrValue);
            }
            if (attrName.Equals(XMLab.author))
            {
                Resource.Author = ResolveCriteria(criteria.Author, attrName, attrValue);
            }
            if (attrName.Equals(XMLab.year))
            {
                Resource.Year = ResolveCriteria(criteria.Year, attrName, attrValue);
            }
            if (attrName.Equals(XMLab.faculty))
            {
                Resource.Faculty = ResolveCriteria(criteria.Faculty, attrName, attrValue);
            }
            if (attrName.Equals(XMLab.annotation))
            {
                Resource.Annotation = attrValue;
            }
            if (attrName.Equals(XMLab.email))
            {
                Resource.Email = attrValue;
            }
        }

        // Works on the search criteria constarints.
        private string ResolveCriteria(string criteria, string attrName, string attrValue)
        {
            if (criteria.Equals(""))
            {
                return attrValue;
            }

            return attrValue.Equals(criteria) ? attrValue : "";
        }
    }

}
