using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OtpNet;

namespace Tamrin1
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputs = Util.Inpute();
            var c = 0;
            foreach (var input in inputs)
            {
                c++;
                int page = 1;
                int pageSize = 2;
                var listStrHex = new List<string>();
                for (int i = 0; i < input.Length/2; i++)
                {
                    var listcharHex = input.ToCharArray().Skip((page - 1) * pageSize).Take(pageSize).ToList();
                    listStrHex.Add($"{listcharHex[0]}{listcharHex[1]}");
                    page++;
                }

                Console.WriteLine(input);
                Console.WriteLine("***********");
                string result = "";
                foreach (var item in listStrHex)
                {
                    int intValue = int.Parse(item, System.Globalization.NumberStyles.HexNumber);
                    result += $"{intValue}";
                    Console.Write(intValue);
                }


                File.WriteAllText(@$"C:\Users\NOVIN RAYAN\source\repos\Tamrin1\Tamrin1\Input\{c}.txt", result);
                Console.WriteLine("___________________");
                
            }
        }
    }
}
