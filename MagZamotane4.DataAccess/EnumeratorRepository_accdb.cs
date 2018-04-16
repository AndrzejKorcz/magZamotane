using MagZamotane4.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Dapper;
using System.Data;

namespace MagZamotane4.DataAccess
{
    public class EnumeratorRepository_accdb : IEnumeratorRepository
    {
        public List<Enumerator> GetRecord(Enumerator obj)
        {
            using (OleDbConnection db = new OleDbConnection(Helper.ConnectionString("kody_kreskowe_accdb")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select *from numerator where Identyfikator = @Identyfikator and grupa = @grupa";
                return db.Query<Enumerator>(query, new { Identyfikator = obj.Identyfikator, grupa = obj.grupa }, commandType: CommandType.Text).ToList();
            }
        }

        public bool Update(Enumerator obj)
        {
            using (OleDbConnection db = new OleDbConnection(Helper.ConnectionString("kody_kreskowe_accdb")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "UPDATE numerator SET numer = @number WHERE Identyfikator = @Identyfikator AND grupa = @grupa";

                int result = db.Execute(query, new { number = obj.numer, Identyfikator = obj.Identyfikator, grupa = obj.grupa }, commandType: CommandType.Text);

                return result != 0;
            }
        }
    }
}
