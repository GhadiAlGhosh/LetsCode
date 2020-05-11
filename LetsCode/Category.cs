using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCode
{
    public class Category
    {
        public string CategoryName { get; set; }
        public ObservableCollection<string> CategoryItems { get; set; }
        public Category(string categoryname,ObservableCollection<string> categoryitems)
        {
            this.CategoryItems = categoryitems;
            this.CategoryName = categoryname;
        }
    }
}
