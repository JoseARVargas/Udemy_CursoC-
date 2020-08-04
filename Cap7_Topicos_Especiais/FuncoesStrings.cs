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
            #region funções string
            //string original = "abcde ABCDE ABC abc DEFG";

            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();

            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("DE");

            //string s4 = original.Substring(3, 5);

            //string s5 = original.Replace('a', 'X');

            //Console.WriteLine("Original: -" + original + "-");
            //Console.WriteLine("ToUpper: -" + s1 + "-");
            //Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");
            //Console.WriteLine("IndexOf: " + n1);
            //Console.WriteLine("LastIndexOf: " + n2);
            //Console.WriteLine("Substring: - " + s4);
            //Console.WriteLine("Replace (a,x): - " + s5);

            //Console.WriteLine("Bom dia a vcs!!!!");

            //Console.WriteLine("Outra mensagem!");

            //Console.WriteLine("Terceira mensagem!");

            //Console.WriteLine("Quarta mensagem!");
            #endregion

            #region DateTime
            DateTime d1 = new DateTime(2018,11,25);
            Console.WriteLine(d1);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 05, 3);
            Console.WriteLine(d2.TimeOfDay);
            Console.WriteLine(d2);

            DateTime d3 = DateTime.UtcNow;
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Parse("2000-08-15");
            DateTime d5 = DateTime.Parse("2000-08-15 13:05:58");
            #endregion
        }
    }
}
