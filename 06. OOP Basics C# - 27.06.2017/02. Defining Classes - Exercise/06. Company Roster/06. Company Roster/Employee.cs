
public class Employee
{
    private string name;
    private double salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee()
    {        
    }
    public Employee(string name, double salary, string position, string department) : this(name,
        salary, position, department, "n/a", -1)
    { }
    public Employee(string name, double salary, string position, string department,string email) : this(name,
        salary, position, department, email, -1)
    { }
    public Employee(string name, double salary, string position, string department, int age) : this(name,
        salary, position, department,"n/a", age)
    { }
    public Employee(string name, double salary, string position, string department, string email, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }
    public string Name { get { return this.name; } set { this.Name = value; } }
    public double Salary { get { return this.salary; } set { this.Salary = value; } }
    public string Position { get { return this.position; } set { this.Position = value; } }
    public string Department { get { return this.department; } set { this.Department = value; } }
    public string Email { get { return this.email; } set { this.Email = value; } }
    public int Age { get { return this.age; } set { this.Age = value; } }

}

