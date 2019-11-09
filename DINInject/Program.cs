using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DINInject
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            IProduct iproduct = kernel.Get<IProduct>();
            ILog ilog = kernel.Get<ILog>();
            BusinessLogic bl = new BusinessLogic(iproduct, ilog);
            bl.Create();
            bl.LogMessage();

            /*Dependency injection without any Container */
            //BusinessLogic obj = new BusinessLogic(new DataAccess());
            //obj.Create();
        }
    }
}
