using System;
using System.Linq;
using System.Reflection;

namespace _02.Black_Box_Integer
{
    public class BlackBoxIntegerTests
    {
        private const BindingFlags NonPulbicFlags = BindingFlags.Instance | BindingFlags.NonPublic;

        public static void Main()
        {
            Type blackBoxType = typeof(BlackBoxInt);
            BlackBoxInt myBlackBox = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] tokens = inputLine.Split('_');
                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                blackBoxType.GetMethod(methodName, NonPulbicFlags)
                    .Invoke(myBlackBox, new object[] { value });

                object innerStateValue = blackBoxType
                    .GetFields(NonPulbicFlags)
                    .First()
                    .GetValue(myBlackBox);

                Console.WriteLine(innerStateValue);
            }
        }
    }
}
