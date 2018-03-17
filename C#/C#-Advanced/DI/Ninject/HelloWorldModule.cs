using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace DI.Ninject
{
    public class HelloWorldModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMessageWriter>().To<ConsoleMessageWriter>().Named("ConsoleWriter");
            this.Bind<IMessageWriter>().To<FileMessageWriter>().InSingletonScope().Named("FileWriter");
            this.Bind<IMessageWriter>().To<DatabaseMessageWriter>().Named("DatabaseWriter");
            this.Bind<ISalutation>().To<Salutation>().WithConstructorArgument(this.Kernel.Get<IMessageWriter>("ConsoleWriter"));
            //this.Bind<Salutation>().ToSelf();
        }
    }
}
