public class Citizen : IPerson, IIdentifiable, IBirthable
{
    private string name;
    private int age;
    private string id;
    private string birthdate;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.name = name;
        this.age = age;
        this.id = id;
        this.birthdate = birthdate;
    }
    public string Name { get; protected set; }
    public int Age { get; protected set; }
    public string Id { get; protected set; }
    public string Birthdate { get; protected set; }
}

