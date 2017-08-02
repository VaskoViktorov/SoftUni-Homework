
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

    public string AnalyzeAcessModifiers(string name)
    {
        Type classType = Type.GetType(name);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        foreach (FieldInfo field in classFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (MethodInfo method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }
        foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }
        return sb.ToString().Trim();
    }
}
