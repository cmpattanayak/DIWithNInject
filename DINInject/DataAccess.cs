using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINInject
{
    public class DataAccess : IProduct
    {
        public string CreateProduct()
        {
            var str = "Product Created Successfully.";
            Console.WriteLine(str);
            return str;
        }
    }
}
