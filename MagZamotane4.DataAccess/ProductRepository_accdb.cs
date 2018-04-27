using MagZamotane4.Core;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Data.OleDb;

namespace MagZamotane4.DataAccess
{
    public class ProductRepository_accdb : IProductRepository
    {
        public bool ClearStocktaking()
        {
            throw new System.NotImplementedException();
        }

        public void Conect()
        {
            using (OleDbConnection db = new OleDbConnection(Helper.ConnectionString("kody_kreskowe_accdb")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();                                
            }
        }

        public bool Delete(int Identyfikator)
        {
            using (OleDbConnection db = new OleDbConnection(Helper.ConnectionString("kody_kreskowe_accdb")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                int result = db.Execute("delete from Produkty where Identyfikator = @Identyfikator", new { Identyfikator = Identyfikator }, commandType: CommandType.Text);
                return result != 0;
            }
        }

        public void Disconnect()
        {
            return;
        }

        public List<Product> GetAll()
        {
            using (OleDbConnection db = new OleDbConnection(Helper.ConnectionString("kody_kreskowe_accdb")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select *from Produkty";
                return db.Query<Product>(query, commandType: CommandType.Text).ToList();
            }
        }

        public List<Product> GetRecordByCode(string Kod)
        {
            using (OleDbConnection db = new OleDbConnection(Helper.ConnectionString("kody_kreskowe_accdb")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select *from Produkty where Kod = @Kod";
                return db.Query<Product>(query, new { Kod = Kod }, commandType: CommandType.Text).ToList();
            }
        }

        public int Insert(Product obj)
        {
            using (OleDbConnection db = new OleDbConnection(Helper.ConnectionString("kody_kreskowe_accdb")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "insert into Produkty(Nazwa, Kod, Cena, CenaNetto, CenaBrutto, Vat, Marza, Wartosc, Jednostka, Ilosc, NumFaktura, DataFaktura, Obrazek) values(@Nazwa, @Kod, @Cena, @CenaNetto, @CenaBrutto, @Vat, @Marza, @Wartosc, @Jednostka, @Ilosc, @NumFaktura, @DataFaktura, @Obrazek)";
                DynamicParameters p = new DynamicParameters();
                p.AddDynamicParams(new { Nazwa = obj.Nazwa, Kod = obj.Kod, Cena = obj.Cena, CenaNetto = obj.CenaNetto, CenaBrutto = obj.CenaBrutto, Vat = obj.Vat, Marza = obj.Marza, Wartosc = obj.Wartosc, Jednostka = obj.Jednostka, Ilosc = obj.Ilosc, NumFaktura = obj.NumFaktura, DataFaktura = obj.DataFaktura, Obrazek = obj.Obrazek });
                db.Execute(query, p, commandType: CommandType.Text);
                return 0;
            }
        }

        public bool Update(Product obj)
        {
            using (OleDbConnection db = new OleDbConnection(Helper.ConnectionString("kody_kreskowe_accdb")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "update Produkty set Cena = @Cena, CenaBrutto = @CenaBrutto, CenaNetto = @CenaNetto, DataFaktura = @DataFaktura, Ilosc = @Ilosc, Jednostka = @Jednostka, Kod = @Kod, Marza = @Marza, Nazwa = @Nazwa, NumFaktura = @NumFaktura, Obrazek = @Obrazek, Vat = @Vat, Wartosc = @Wartosc where Identyfikator = @Identyfikator";
                int result = db.Execute(query, new { Cena = obj.Cena, CenaBrutto = obj.CenaBrutto, CenaNetto = obj.CenaNetto, DataFaktura = obj.DataFaktura, Ilosc = obj.Ilosc, Jednostka = obj.Jednostka, Kod = obj.Kod, Marza = obj.Marza, Nazwa = obj.Nazwa, NumFaktura = obj.NumFaktura, Obrazek = obj.Obrazek, Vat = obj.Vat, Wartosc = obj.Wartosc, Identyfikator = obj.Identyfikator }, commandType: CommandType.Text);

                return result != 0;
            }
        }
    }
}
