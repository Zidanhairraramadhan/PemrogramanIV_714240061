using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240061
{
    public class Book_714240061 : Product_714240061
    {
        protected string pageCount;

        public Book_714240061(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }
        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} calles \"{1}\" and has {2} page", MyType, MyTitle, PageCount);
        }
    }
}