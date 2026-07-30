using Oracle.DatabaseAccess;
using Oracle.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Context context = ConnectionOracle.Create();
        //context.Database.EnsureCreated();
        //People p = new People();
        //p.Name = "Hugo Leonardo Canducci Dias";
        //p.CreatedAt = null;
        //context.Peoples.Add(p);
        //context.SaveChanges();

        Option<People> p = context.Peoples.Find(3);
        if (p)
        {
            //p.Value.Name = "Maria Apª Dias Cintra";
            p.Value.CreatedAt = DateTime.Now;
            context.SaveChanges();
        }
        foreach (var item in context.Peoples.ToList())
        {
            Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.CreatedAt);
        }

        Console.ReadKey();
    }
}