namespace _03._Self_Ref
{
    public class Program
    {
       public static void Main()
        {
            AppDbContext context = new AppDbContext();
            context.Database.EnsureCreated();
        }
    }
}
