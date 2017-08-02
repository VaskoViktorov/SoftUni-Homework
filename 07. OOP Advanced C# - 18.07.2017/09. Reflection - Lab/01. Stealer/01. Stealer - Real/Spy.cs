
using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string name, params string[] info)
    {
        Type classType = Type.GetType(name);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic |
                                                      BindingFlags.Public | BindingFlags.Static);
        StringBuilder sb = new StringBuilder();
        Object classInstanse = Activator.CreateInstance(classType, new object[] { });

        sb.AppendLine($"Class under investigation: {name}");

        foreach (FieldInfo field in classFields.Where(f => info.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstanse)}");
        }
            return sb.ToString().Trim();
    }
}
