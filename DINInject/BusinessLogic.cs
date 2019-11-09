using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINInject
{
    public class BusinessLogic
    {
        public static IProduct _product;
        private static ILog _log;

        public BusinessLogic(IProduct product, ILog log)
        {
            _product = product;
            _log = log;
        }

        public void Create()
        {
            var res = _product.CreateProduct();
        }

        public void LogMessage()
        {
            _log.Log();
        }
    }
}
