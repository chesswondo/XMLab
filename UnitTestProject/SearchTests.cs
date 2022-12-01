using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using XMLab;


namespace UnitTestProject
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void Test_DOM()
        {
            ISearch search = new DomSearch();
            SearchCriteria criteria = new SearchCriteria("Test title","","2022","");
            List<Resource> resources = search.Search(criteria);

            Assert.AreEqual(resources.Count, 1);
            Assert.AreEqual(resources[0].Title, "Test title");
            Assert.AreEqual(resources[0].Author, "Test author");
        }

        [TestMethod]
        public void Test_Sax()
        {
            ISearch search = new SaxSearch();
            SearchCriteria criteria = new SearchCriteria("", "Test author", "2022", "");
            List<Resource> resources = search.Search(criteria);

            Assert.AreEqual(1,             resources.Count);
            Assert.AreEqual("Test title",  resources[0].Title);
            Assert.AreEqual("Test author", resources[0].Author);
        }

        [TestMethod]
        public void Test_Linq()
        {
            ISearch search = new LinqToXmlSearch();
            SearchCriteria criteria = new SearchCriteria("Test title", "Test author", "2022", "");
            List<Resource> resources = search.Search(criteria);

            Assert.AreEqual(1, resources.Count);
            Assert.AreEqual("Test title", resources[0].Title);
            Assert.AreEqual("Test author", resources[0].Author);
        }

    }
}
