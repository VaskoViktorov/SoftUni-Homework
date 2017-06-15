using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication261
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list =  Console.ReadLine().Split(' ').ToList();
            List<string> endList = list;
            var index = 0;
            while (list[0] != "print")
            {
                if (list[0] == "add")
                {
                    index = int.Parse(list[1]);
                    endList.Add("");
                    for (int i = endList.Count - 1; i > index ; i--)
                    {
                        endList[i] = endList[i-1];
                    }        
                    endList[index] = list[2];
                }

                else if (list[0] == "addMany")
                {
                    index = int.Parse(list[1]);
                    for (int i = 0; i < list.Count-2; i++)
                    {
                        endList.Add("");
                    }
                    if (index > endList.Count - 1 || index <= endList.Count)
                    {
                        for (int i = endList.Count - 1; i > index; i--)
                        {
                            if (i - (list.Count - 2) >= 0)
                            {
                                endList[i] = endList[i - (list.Count - 2)];
                            }
                        }
                    }
                    var h = 2;
                    if (index <= endList.Count)
                    {
                        for (int i = 0; i < list.Count - 2; i++)
                        {
                            endList[index+i] = list[h];
                            h++;
                        }
                    }
                    else
                    {
                        for (int i = index; i < endList.Count; i++)
                        {
                            endList[i] = list[h];
                            h++;
                        }
                    }
                    
                }

                else if (list[0] == "contains")
                {
                    if (endList.Contains(list[1]) == true)
                    {
                        for (int i = 0; i < endList.Count; i++)
                        {
                            if (endList[i] == list[1])
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                  
                }

                else if (list[0] == "remove")
                {
                    index = int.Parse(list[1]);
                    endList.RemoveAt(index);
                }

                else if (list[0] == "shift")
                {
                    index = int.Parse(list[1]);
                    
                    
                    for (int j = 0; j < index; j++)
                    {
                        endList.Add("");
                        endList[endList.Count - 1] = endList[0];
                        
                        for (int i = 0; i < endList.Count - 1; i++)
                        {
                            endList[i] = endList[i + 1];

                        }
                        endList.RemoveAt(endList.Count - 1);
                    }
                }
                else if (list[0] == "sumPairs")
                {
                   List <int> sum = endList.Select(int.Parse).ToList();

                    for (int i = 0; i < sum.Count-1; i++)
                    {
                        sum[i] = sum[i] + sum[i + 1];
                        (sum[i + 1]) = -12346;                      
                        i += 1;
                    }

                    sum.RemoveAll(i => i == -12346);
                    endList = sum.Select(item => item.ToString()).ToList();
                }




                list = Console.ReadLine().Split(' ').ToList();
                
            }
            Console.WriteLine($"[{string.Join(", ",endList)}]");

        }
    }
}
