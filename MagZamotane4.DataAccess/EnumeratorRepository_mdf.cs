using MagZamotane4.Core;
using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagZamotane4.DataAccess
{
    public class EnumeratorRepository_mdf : IEnumeratorRepository
    {
        public List<Enumerator> GetRecord(Enumerator obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<Enumerator>("sp_numerator_GetRecord", new { Identyfikator = obj.Identyfikator, grupa = obj.grupa }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public bool Update(Enumerator obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString("kody_kreskowe_mdf")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                int result = db.Execute("sp_numerator_Update", new { number = obj.numer, Identyfikator = obj.Identyfikator, grupa = obj.grupa }, commandType: CommandType.StoredProcedure);
                return result != 0;
            }
        }
    }
}
