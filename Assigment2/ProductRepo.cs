using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ProductRepo:IProductRepos
    {
        public List<String> GetList()
        {
            return new List<String>() { "İlker", "Ozan"};
        }
    }
}
