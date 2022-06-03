using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    internal class Service
    {

        private readonly IProductRepos _productRepos;

        public Service(IProductRepos productRepos)
        {
            _productRepos = productRepos;
        }

        public List<string> GetNames()
        {

            return _productRepos.GetList();
        }


    }
}
