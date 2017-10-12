using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Ninject
{
    public class HelloWorldModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMessageWriter>().To<ConsoleMessageWriter>();
            this.Bind<Salutation>().ToSelf();
        }
    }
}
