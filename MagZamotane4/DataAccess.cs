using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.OleDb;

namespace FormUI
{
    public class DataAccess
    {
        public List<Produkty> getProduct(string code)
        {
            using (OleDbConnection connection = new OleDbConnection(Helper.ConnVal("kody_kreskowe")))
            {
                //return connection.Query<Produkty>($"select * from Produkty where Kod = '{code}'").ToList();
                return connection.Query<Produkty>($"select * from Produkty where Kod = @Kod", new { Kod = code }).ToList();
            }
        }

        public void insertProduct(string code, string name)
        {
            using (OleDbConnection connection = new OleDbConnection(Helper.ConnVal("kody_kreskowe")))
            {
                //Produkty newProduct = new Produkty { Kod = code, Nazwa = name };
                List<Produkty> produkty = new List<Produkty>();
                produkty.Add(new Produkty { Kod = code, Nazwa = name });

                connection.Execute($"insert into Produkty(Kod, Nazwa)  values (@Kod,@Nazwa)", produkty);
            }
        }

        public void updateProduct(List<Produkty> productList)
        {
            using (OleDbConnection connection = new OleDbConnection(Helper.ConnVal("kody_kreskowe")))
            {
                var barCode =  productList[0].Kod;
                connection.Execute($"UPDATE Produkty SET Cena = @Cena, CenaBrutto = @CenaBrutto, CenaNetto = @CenaNetto, DataFaktura = @DataFaktura, Ilosc = @Ilosc, Jednostka = @Jednostka, Kod = @Kod, Marza = @Marza, Nazwa = @Nazwa, NumFaktura = @NumFaktura, Vat = @Vat, Wartosc = @Wartosc  where Kod = '{barCode}'", productList);
            }
        }
    }
}
