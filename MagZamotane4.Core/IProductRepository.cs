using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagZamotane4.Core
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        List<Product> GetRecordByCode(string Kod);
        int Insert(Product obj);
        bool Update(Product obj);
        bool Delete(int Identyfikator);
        void Conect();
        void Disconnect();
        bool ClearStocktaking();
    }
}
