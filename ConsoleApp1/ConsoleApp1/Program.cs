using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };
            string[][] change(string[] arr)
            {
                var obj = new Dictionary<string, string[]>();
                var result = new string[][] {};
                for (var i= 0; i < arr.Length; i++)
                {
                    var charArrayOfElement = arr[i].ToLower().ToCharArray();
                    Array.Sort(charArrayOfElement);
                    var elKey = new string(charArrayOfElement);
                    if (obj.ContainsKey(elKey))
                    {
                        var val = obj[elKey].ToList();
                        val.Add(arr[i]);
                        obj[elKey] = val.ToArray();
                    }
                    else
                    {
                        obj.Add(elKey, new[] {arr[i]});
                    }                
                }
                foreach(var k in obj.Keys)
                {
                    var values = obj[k];
                    var resultList = result.ToList();
                    resultList.Add(values);
                    result = resultList.ToArray();
                }
                return result;
            }
            var resultArray = change(a);
            Console.ReadKey();
        }
    }
}
