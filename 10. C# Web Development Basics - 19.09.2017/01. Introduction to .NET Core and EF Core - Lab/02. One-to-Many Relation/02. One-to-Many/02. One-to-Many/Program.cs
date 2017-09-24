namespace _02._One_to_Many
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            context.Database.EnsureCreated();
        }
    }
}
