using MagZamotane4.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace MagZamotane4.DataAccess
{
    public class ProductRepository_mdf : IProductRepository
    {

        public bool Delete(int Identyfikator)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                
                if (db.State == ConnectionState.Closed)
                    db.Open();
                
                int result = db.Execute("sp_Produkty_Delete", new { Identyfikator = Identyfikator }, commandType: CommandType.StoredProcedure);
                return result !=0 ;
            }
            
            
        }

        public List<Product> GetAll()
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<Product>("sp_Produkty_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public int Insert(Product obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Identyfikator", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.AddDynamicParams(new { Nazwa = obj.Nazwa, Kod = obj.Kod, Cena = obj.Cena, CenaNetto = obj.CenaNetto, CenaBrutto = obj.CenaBrutto, Vat = obj.Vat, Marza = obj.Marza, Wartosc = obj.Wartosc, Jednostka = obj.Jednostka, Ilosc = obj.Ilosc, NumFaktura = obj.NumFaktura, DataFaktura = obj.DataFaktura, Obrazek = obj.Obrazek });
                    db.Execute("sp_Produkty_Insert", p, commandType: CommandType.StoredProcedure);
                    return p.Get<int>("@Identyfikator");
            }
        }

        public bool Update(Product obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                int result = db.Execute("sp_Produkty_Update", new { Identyfikator = obj.Identyfikator, Nazwa = obj.Nazwa, Kod = obj.Kod, Cena = obj.Cena, CenaNetto = obj.CenaNetto, CenaBrutto = obj.CenaBrutto, Vat = obj.Vat, Marza = obj.Marza, Wartosc = obj.Wartosc, Jednostka = obj.Jednostka, Ilosc = obj.Ilosc, NumFaktura = obj.NumFaktura, DataFaktura = obj.DataFaktura, Obrazek = obj.Obrazek }, commandType: CommandType.StoredProcedure);
                return result != 0;
            }
        }

        public void Disconnect()
        {
            using (SqlConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                SqlConnection.ClearPool(db);
            }
        }

        public List<Product> GetRecordByCode(string Kod)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<Product>("sp_Produkty_GetRecordByCode", new { Kod = Kod }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void Conect()
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();               
            }
        }
    }
}
