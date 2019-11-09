using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINInject
{
    public class NInjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IProduct>().To<DataAccess>();

            /*One to Many Interface Binding is not possible*/
            //Bind<IProduct>().To<ProductDataAccess>();

            Bind<ILog>().To<ProductDataAccess>();
        }
    }
}
