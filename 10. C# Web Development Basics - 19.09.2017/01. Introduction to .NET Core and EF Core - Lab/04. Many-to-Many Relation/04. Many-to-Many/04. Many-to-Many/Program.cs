namespace _04._Many_to_Many
{
    public class Program
    {
        public static void Main()
        {
            AppDbContext context = new AppDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
