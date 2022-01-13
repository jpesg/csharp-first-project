using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Book
    {
        public string title;
        public string author;
        private int pages;

        //onstructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Creating Book:");
            title = aTitle;
            author = aAuthor;
            //pages = aPages;
            Pages = aPages;//using getter & setter

        }

        public bool HasPages()
        {
            return pages > 0;
        }
        public int Pages
        {
            get { return pages; }
            set {
                if (value > 0) {
                    pages = value;
                }
                else
                {
                    pages = -9999;
                }
            }        
        }
    }
}
