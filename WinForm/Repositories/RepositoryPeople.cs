using Microsoft.EntityFrameworkCore;
using WinForm.DataAccess;
using WinForm.Models;
using WinForm.Records.People;

namespace WinForm.Repositories;

public sealed class RepositoryPeople(OracleDataAccess Context) : RepositoryBase<People>(Context)
{
    public bool CreateOrUpdate(People people)
    {
        if (people == null) return false;
        if (people.Id == 0) return Create(people);
        return Update(people);
    }

    public async Task<bool> CreateOrUpdateAsync(People people)
    {
        if (people == null) return false;
        if (people.Id == 0) return await CreateAsync(people);
        return await UpdateAsync(people);
    }

    public People? Get(int id)
    {
        return Query().FirstOrDefault(p => p.Id == id);
    }

    public async Task<People?> GetAsync(int id)
    {
        return await Query().FirstOrDefaultAsync(p => p.Id == id);
    }

    public List<PeopleList> Get(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return [.. Query().OrderBy(p => p.Name).Select(c => new PeopleList(c.Id, c.Name))];
        }
        return [.. Query().Where(p => p.Name.ToUpper().Contains(name.ToUpper())).OrderBy(p => p.Name).Select(c => new PeopleList(c.Id, c.Name))];
    }

    public async Task<List<PeopleList>> GetAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return await Query().OrderBy(p => p.Name).Select(c => new PeopleList(c.Id, c.Name)).ToListAsync();
        }
        return await Query().Where(p => p.Name.ToUpper().Contains(name.ToUpper())).OrderBy(p => p.Name).Select(c => new PeopleList(c.Id, c.Name)).ToListAsync();
    }
}
