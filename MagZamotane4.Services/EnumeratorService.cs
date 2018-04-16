using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MagZamotane4.Core;
using MagZamotane4.DataAccess;

namespace MagZamotane4.Services
{
    public class EnumeratorService
    {
        static IContainer _container;
        static EnumeratorService()
        {
            ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<EnumeratorRepository_accdb>().As<IEnumeratorRepository>();
            builder.RegisterType<EnumeratorRepository_mdf>().As<IEnumeratorRepository>();
            _container = builder.Build();
        }


        public static List<Enumerator> GetNumber(Enumerator obj)
        {
            return _container.Resolve<IEnumeratorRepository>().GetRecord(obj);
        }

        public static bool Update(Enumerator obj)
        {
           return _container.Resolve<IEnumeratorRepository>().Update(obj);
        }


    }
}
