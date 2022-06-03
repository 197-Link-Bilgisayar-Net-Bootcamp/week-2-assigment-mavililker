using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Other: IProductRepos
    {
        public List<String> GetList()
        {
            return new List<String>() { "İlkerother", "Ozanother" };
        }
    }
}
