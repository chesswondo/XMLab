using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLab
{
    public partial class XMLab : Form
    {
        public const string resourceTag = "resource";
        public const string title       = "title";
        public const string author      = "author";
        public const string year        = "year";
        public const string faculty     = "faculty";
        public const string annotation  = "annotation";
        public const string email       = "email";

        public const string xmlPath     = "./data.xml";

        public XMLab()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCriteriaLists();
        }

        private void FillCriteriaLists()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            XmlElement root = doc.DocumentElement;
            XmlNodeList resources = root.SelectNodes(resourceTag);

            for (int i = 0; i < resources.Count; i++)
            {
                XmlNode resource = resources.Item(i);
                SearchCriteria criteria = new SearchCriteria(resource);
                AddCriteria(criteria);
            }
        }

        // Adds search criteria to lists.
        private void AddCriteria(SearchCriteria criteria)
        {
            if (!dlTitle.Items.Contains(criteria.Title))     dlTitle.Items.Add(criteria.Title);
            if (!dlAuthor.Items.Contains(criteria.Author))   dlAuthor.Items.Add(criteria.Author);
            if (!dlYear.Items.Contains(criteria.Year))       dlYear.Items.Add(criteria.Year);
            if (!dlFaculty.Items.Contains(criteria.Faculty)) dlFaculty.Items.Add(criteria.Faculty);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SearchTitleChanged(object sender, EventArgs e)
        {
            dlTitle.Enabled = SearchTitle.Checked;
            if (SearchTitle.Checked)
                dlTitle.Text = dlTitle.Items[0].ToString();
        }

        private void SearchAuthorChanged(object sender, EventArgs e)
        {
            dlAuthor.Enabled = SearchAuthor.Checked;
            if (SearchAuthor.Checked)
                dlAuthor.Text = dlAuthor.Items[0].ToString();
        }

        private void SearchYearChanged(object sender, EventArgs e)
        {
            dlYear.Enabled = SearchYear.Checked;
            if (SearchYear.Checked)
                dlYear.Text = dlYear.Items[0].ToString();
        }

        private void SearchFacultyChanged(object sender, EventArgs e)
        {
            dlFaculty.Enabled = SearchFaculty.Checked;
            if (SearchFaculty.Checked)
                dlFaculty.Text = dlFaculty.Items[0].ToString();
        }

        private void searchBtnClick(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            ISearch search = new DomSearch();
            /*
            if (saxBtn.Checked)
            {
                search = new SaxSearch();
            }
            if (linqToXmlBtn.Checked)
            {
                search = new LinqToXmlSearch();
            }
            */
            List<Resource> resources = search.Search(GetSearchCriteria());
            OutputSearchResults(resources);
        }

        private SearchCriteria GetSearchCriteria()
        {
            string title = SearchTitle.Checked ? dlTitle.Text : "";
            string author = SearchAuthor.Checked ? dlAuthor.Text : "";
            string year = SearchYear.Checked ? dlYear.Text : "";
            string faculty = SearchFaculty.Checked ? dlFaculty.Text : "";

            return new SearchCriteria(title, author, year, faculty);
        }

        private void OutputSearchResults(List<Resource> resources)
        {
            searchResultsViewer.Text = "";

            int resultCount = 0;
            for (int i = 0; i < resources.Count; i++)
            {
                if (resources[i] != null)
                {
                    searchResultsViewer.Text += "Результат\t:"  + (resultCount + 1) + "\n";
                    searchResultsViewer.Text += "Назва\t\t: " + resources[i].Title + "\n";
                    searchResultsViewer.Text += "Автор\t\t: " + resources[i].Author + "\n";
                    searchResultsViewer.Text += "Рік\t\t: " + resources[i].Year + "\n";
                    searchResultsViewer.Text += "Факультет\t: " + resources[i].Faculty + "\n";
                    searchResultsViewer.Text += "Анотація\t: " + resources[i].Annotation + "\n";
                    searchResultsViewer.Text += "E-mail\t\t: " + resources[i].Email + "\n";
                    searchResultsViewer.Text += "----------------\n";
                    resultCount++;
                }
            }
        }

    }
}
