using Autofac;
using MagZamotane4.Core;
using MagZamotane4.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagZamotane4.Services
{
    public class ProductService
    {
        static IContainer _container;
        static ProductService()
        {
            ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<ProductRepository_accdb>().As<IProductRepository>();
            builder.RegisterType<ProductRepository_mdf>().As<IProductRepository>();
            _container = builder.Build();
        }

        public static bool Delete(int Identyfikator)
        {
            return _container.Resolve<IProductRepository>().Delete(Identyfikator);
        }

        public static List<Product> GetRecordByCode(string Kod)
        {
            return _container.Resolve<IProductRepository>().GetRecordByCode(Kod);
        }

        public static List<Product> GetAll()
        {
           return _container.Resolve<IProductRepository>().GetAll();
        }

        public static Product Save(Product obj, EntityState state)
        {
            if (state == EntityState.Added)
                obj.Identyfikator = _container.Resolve<IProductRepository>().Insert(obj);
            else if (state == EntityState.Changed)
                _container.Resolve<IProductRepository>().Update(obj);
            return obj;
        }

        public static void Disconnect()
        {
            _container.Resolve<IProductRepository>().Disconnect();
        }

        public static void Connect()
        {
            _container.Resolve<IProductRepository>().Conect();
        }

    }
}
