using WinForm.DataAccess;
using WinForm.Models;

namespace WinForm.Repositories
{
    public sealed class RepositoryPeople(OracleDataAccess Context) : RepositoryBase<People>(Context)
    {
        public bool CreateOrUpdate(People people)
        {
            if (people == null) return false;
            if (people.Id == 0) return Create(people);
            return Update(people);
        }

        public People? Get(int id)
        {
            return Query().FirstOrDefault(p => p.Id == id);
        }

        public List<People> Get(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return [.. Query().OrderBy(p => p.Name)];
            }
            return [.. Query().Where(p => p.Name.ToUpper().Contains(name.ToUpper())).OrderBy(p => p.Name)];
        }
    }
}
