using System.Collections.Generic;

namespace MagZamotane4.Core
{
    public interface IEnumeratorRepository
    {
        List<Enumerator> GetRecord(Enumerator obj);
        bool Update(Enumerator obj);
    }
}
