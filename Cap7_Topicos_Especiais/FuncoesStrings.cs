using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Topicos_Especiais
{
    class FuncoesStrings
    {
        static void Main(string[] args)
        {
            string original = "abcde ABCDE ABC abc DEFG";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("DE");

            string s4 = original.Substring(3, 5);

            string s5 = original.Replace('a', 'X');

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf: " + n1);
            Console.WriteLine("LastIndexOf: " + n2);
            Console.WriteLine("Substring: - " + s4);
            Console.WriteLine("Replace (a,x): - " + s5);
        }
    }
}
